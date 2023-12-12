using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace kgLab
{
    internal class NewtonsFractal
    {
        Color[] solutionColors;
        Complex[] solutions;
        Complex eqConst = new Complex(1, 1);
        PictureBox panel;

        double startX;
        double startY;
        double range;

        Mutex mut = new Mutex();
        int newtonsFractalLine = 0;
        public NewtonsFractal(PictureBox pb)
        {
            solutionColors = new Color[5];
            solutionColors[0] = Color.FromArgb(172, 146, 235);
            solutionColors[1] = Color.FromArgb(79, 193, 232);
            solutionColors[2] = Color.FromArgb(160, 213, 104);
            solutionColors[3] = Color.FromArgb(255, 206, 84);
            solutionColors[4] = Color.FromArgb(237, 55, 100);

            solutions = new Complex[5];

            this.panel = pb;

            Reset();
        }
        public void Reset()
        {
            startX = -3;
            startY = 3;
            range = 6;
            CalculateSolutions();
        }
        private void CalculateSolutions()
        {
            double radius = Math.Pow(eqConst.Magnitude, 1 / 5);
            double phaseStep = 2 * Math.PI / 5;
            double offset = Math.PI / 5;
            Complex[] roots = new Complex[5];
            for (int i = 0; i < 5; i++)
                roots[i] = Complex.FromPolarCoordinates(radius, i * phaseStep + offset);

            solutions = AberthMethod.FindRoots(roots, eqConst);
        }
        public Bitmap CreateFractal()
        {
            // Init
            Bitmap bmp = new Bitmap(panel.Width, panel.Height, PixelFormat.Format24bppRgb);
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData =
                bmp.LockBits(rect, ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            IntPtr ptr = bmpData.Scan0;
            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            int stride = Math.Abs(bmpData.Stride);
            int width = bmp.Width;
            int height = bmp.Height;
            byte[] rgbValues = new byte[bytes];

            // Every Thread Fills One Line
            Thread[] threads = new Thread[16];
            newtonsFractalLine = 0;
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() => ThreadLineColoring(rgbValues, stride, width, height));
                threads[i].Start();
            }
            foreach (Thread thread in threads)
                thread.Join();

            // Copy Back
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
            return bmp;
        }
        private void ThreadLineColoring(byte[] rgbValues, int stride, int width, int height)
        {
            while (newtonsFractalLine < height)
            {
                mut.WaitOne();
                int currentLine = newtonsFractalLine++;
                mut.ReleaseMutex();

                if (currentLine >= height)
                    break;

                for (int x = 0; x < width; x++)
                {
                    Color current = FindSolutionForPoint(x, currentLine);

                    int pixelIndex = currentLine * stride + x * 3;
                    rgbValues[pixelIndex + 2] = current.R;          // Red
                    rgbValues[pixelIndex + 1] = current.G;        // Green
                    rgbValues[pixelIndex] = current.B;              // Blue
                }
            }
        }
        private Color FindSolutionForPoint(int x, int y)
        {
            if (eqConst == 0) return solutionColors[0];

            Complex current = PixelToComplex(x, y);
            Complex final = NewtonsMethod.FindRoot(current, eqConst);
            int index = FindClosestSolution(final);
            return solutionColors[index];
        }
        private int FindClosestSolution(Complex a)
        {
            int index = 0;
            double minDistance = (a - solutions[0]).Magnitude;
            for (int i = 1; i < 5; i++)
            {
                double newDistance = (a - solutions[i]).Magnitude;
                if (newDistance < minDistance)
                {
                    index = i;
                    minDistance = newDistance;
                }
            }
            return index;
        }
        private Complex PixelToComplex(int x, int y)
        {
            double X = startX + range * ((double)x / panel.Width);
            double Y = startY - range * ((double)y / panel.Height);
            return new Complex(X, Y);
        }
        public void Zoom(int x, int y, bool zoomIn)
        {
            Complex point = PixelToComplex(x, y);
            if (zoomIn)
                range /= 2;
            else
                range *= 2;
            startX = point.Real - range / 2;
            startY = point.Imaginary + range / 2;
        }
        public void SetSolutionColor(Color color, int index)
        {
            solutionColors[index] = color;
        }
        public void SetConst(double r, double i)
        {
            eqConst = new Complex(r, i);
        }
        public void SetStartingPoint(double x, double y)
        {
            startX = x;
            startY = y;
        }
        public void SetRange(double range)
        {
            this.range = range;
        }
    }
}
