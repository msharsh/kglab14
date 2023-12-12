using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace kgLab
{
    public partial class MovingImageForm : Form
    {
        int height = 1024;
        int width = 1024;
        int step = 30;
        PointF center;
        Bitmap picture = new Bitmap(1024, 1024);
        AffineTransformationInfo affineInfo;
        Timer animationTimer;
        PointF[] vertices;
        int fps = 24;
        int duration = 2;
        int fd;
        public MovingImageForm()
        {
            InitializeComponent();
            using (Graphics g = Graphics.FromImage(picture))
            {
                drawGrid(g);
            }
            animationTimer = new Timer();
            animationTimer.Interval = 1000 / fps;
            animationTimer.Tick += AnimationTimer_Tick;
            trackBar1.Value = 32;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            performAffine();
            fd++;
            if (fd == fps * duration)
            {
                animationTimer.Stop();
            }
        }
        private void performAffine()
        {
            double alpha = affineInfo.angle;
            double[,] mrotate = new double[,]
            {
                {Math.Cos(alpha), -Math.Sin(alpha), 0 },
                {Math.Sin(alpha), Math.Cos(alpha), 0 },
                {0,0,1 }
            };
            Matrix<double> Mrotate = DenseMatrix.OfArray(mrotate);
            double m = affineInfo.scale;
            double[,] mscale = new double[,]
            {
                {m,0,0 },
                {0,m,0 },
                {0,0,1 }
            };
            Matrix<double> Mscale = DenseMatrix.OfArray(mscale);
            float px;
            float py;
            if (affineInfo.vertex==0)
            {
                px = center.X;
                py = center.Y;
            }
            else
            {
                px = vertices[affineInfo.vertex - 1].X;
                py = vertices[affineInfo.vertex-1].Y;
            }
            double[,] mtoorigin = new double[,]
            {
                {1, 0, -px},
                {0,1, -py},
                {0,0,1 }
            };
            Matrix<double> Morigin = DenseMatrix.OfArray(mtoorigin);
            double[,] mback = new double[,]
            {
                {1, 0, px},
                {0,1, py},
                {0,0,1 }
            };
            Matrix<double> Mback = DenseMatrix.OfArray(mback);
            Matrix<double> result;
            result = Mback*Mrotate*Mscale*Morigin;
            
            Vector<double> pointVector = Vector<double>.Build.DenseOfArray(new double[] { center.X, center.Y, 1.0 });
            Vector<double> transformedPoint = result.Multiply(pointVector);
            center.X = (float)transformedPoint[0];
            center.Y = (float)transformedPoint[1];

            pointVector = Vector<double>.Build.DenseOfArray(new double[] { vertices[0].X, vertices[0].Y, 1.0 });
            transformedPoint = result.Multiply(pointVector);
            vertices[0].X = (float)transformedPoint[0];
            vertices[0].Y = (float)transformedPoint[1];
            
            using (Graphics graphics = Graphics.FromImage(picture))
            {
                drawGrid(graphics);
                DrawHexagon(graphics, center, vertices[0]);
            }
            pictureBox1.Image = picture;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AffineTransformationDialog dialog = new AffineTransformationDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (vertices == null)
                {
                    MessageBox.Show("NO HEXAGON GENERATED", "ERROR");

                }
                else
                {
                    affineInfo = dialog.affineInfo;
                    affineInfo.angle = affineInfo.angle * Math.PI / 180;
                    affineInfo.angle = affineInfo.angle / (fps * duration);
                    affineInfo.scale = Math.Pow(affineInfo.scale, 1.0 / (fps * duration));
                    fd = 0;
                    animationTimer.Start();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            center = new PointF((float)(numericUpDown1.Value *step)+width/2, -(float)(numericUpDown2.Value * step) + height / 2);
            PointF vertice = new PointF((float)(numericUpDown3.Value * step) + width / 2, -(float)(numericUpDown4.Value * step) + height / 2);
            
            using (Graphics graphics = Graphics.FromImage(picture))
            {

                drawGrid(graphics);
                DrawHexagon(graphics, center, vertice);
            }
            pictureBox1.Image = picture;
        }
        private void drawGrid(Graphics graphics)
        {
            
                // Clear the background
                graphics.Clear(Color.White);

                // Set up the pen for the grid
                using (Pen gridPen = new Pen(Color.DarkGray, 1))
                {
                    // Set up the pen for the thicker axes
                    using (Pen axisPen = new Pen(Color.DarkGray, 2))
                    {
                        // Set up the font for axis labels
                        Font font = new Font("Arial", 14);
                        SolidBrush brush = new SolidBrush(Color.Black);
                        SolidBrush textbrush = new SolidBrush(Color.Red);
                        // Draw the thicker X-axis

                        graphics.DrawLine(axisPen, 0, height / 2, width, height / 2);

                        // Draw the thicker Y-axis
                        graphics.DrawLine(axisPen, width / 2, 0, width / 2, height);

                        // Draw the grid
                        for (int x = 0, xcoord = 0; x <= width / 2; x += step, xcoord++)
                        {
                            graphics.DrawLine(gridPen, x + width / 2, 0, x + width / 2, height);
                            if(xcoord == 0)
                            {
                                graphics.DrawLine(axisPen, x + width / 2, 0, x + width / 2, height);
                            }
                            // Draw labels on the X-axis with a step of 5

                            if (step < 64)
                            {
                                if (xcoord % (64 / step) == 0 && xcoord != 0)
                                    graphics.DrawString(xcoord.ToString(), font, textbrush, x + width / 2 - 10, height / 2 + 5);
                            }
                            else
                                    if (xcoord != 0)
                                graphics.DrawString(xcoord.ToString(), font, textbrush, x + width / 2 - 10, height / 2 + 5);
                        }
                        for (int x = 0, xcoord = 0; x >= -width / 2; x -= step, xcoord--)
                        {
                            graphics.DrawLine(gridPen, x + width / 2, 0, x + width / 2, height);
                            if (xcoord == 0)
                            {
                                graphics.DrawLine(axisPen, x + width / 2, 0, x + width / 2, height);
                            }
                            // Draw labels on the X-axis with a step of 5

                            if (step < 64)
                            {
                                if (xcoord % (64 / step) == 0 && xcoord != 0)
                                    graphics.DrawString(xcoord.ToString(), font, textbrush, x + width / 2 - 10, height / 2 + 5);
                            }
                            else
                                    if (xcoord != 0)
                                graphics.DrawString(xcoord.ToString(), font, textbrush, x + width / 2 - 10, height / 2 + 5);
                        }

                        for (int y = 0, ycoord=0; y <= height / 2; y += step, ycoord++)
                        {
                            graphics.DrawLine(gridPen, 0, y + height / 2, width, y + height / 2);
                            if (ycoord == 0)
                            {
                                graphics.DrawLine(axisPen, 0, y + height / 2, width, y + height / 2);
                            }
                            // Draw labels on the Y-axis with a step of 5
                            if (step < 64)
                            {
                                if (ycoord % (64 / step) == 0 && ycoord != 0)
                                    graphics.DrawString((-ycoord).ToString(), font, textbrush, width / 2 + 5, y + height / 2 - 10);
                            }
                            else
                                    if (ycoord != 0)
                                graphics.DrawString((-ycoord).ToString(), font, textbrush, width / 2 + 5, y + height / 2 - 10);
                        }
                        for (int y = 0, ycoord = 0; y >= -height / 2; y -= step, ycoord--)
                        {
                            graphics.DrawLine(gridPen, 0, y + height / 2, width, y + height / 2);
                            if (ycoord == 0)
                            {
                                graphics.DrawLine(axisPen, 0, y + height / 2, width, y + height / 2);
                            }
                            // Draw labels on the Y-axis with a step of 5
                            if (step < 64)
                            {
                                if (ycoord % (64 / step) == 0 && ycoord != 0)
                                    graphics.DrawString((-ycoord).ToString(), font, textbrush, width / 2 + 5, y + height / 2 - 10);
                            }
                            else
                                    if (ycoord != 0)
                                graphics.DrawString((-ycoord).ToString(), font, textbrush, width / 2 + 5, y + height / 2 - 10);
                        }
                    }
                }
                pictureBox1.Image = picture;
            
        }
        private void DrawHexagon(Graphics graphics, PointF center, PointF vertex)
        {
            // Calculate other vertices based on the given center and one vertex
            CalculateHexagonVertices(center, vertex);

            // Draw lines connecting the vertices to form the hexagon
            using (Pen pen = new Pen(Color.Purple, 2))
            {
                Font font = new Font("Arial", 14);
                SolidBrush textbrush = new SolidBrush(Color.Blue);
                for (int i = 0; i < 6; i++)
                {
                    int nextIndex = (i + 1) % 6;
                    graphics.DrawLine(pen, vertices[i], vertices[nextIndex]);
                    Vector2 vector = new Vector2();
                    vector /= vector.Length();

                    graphics.DrawString(((char)('A' + i)).ToString(), font, textbrush, vertices[i].X+5, vertices[i].Y+5);  
                }
                graphics.DrawEllipse(pen, center.X, center.Y, 2, 2);
                graphics.DrawString("O", font, textbrush, center.X + 5, center.Y + 5);
            }
        }

        private void CalculateHexagonVertices(PointF center, PointF vertex)
        {
            PointF[] resultPoints = new PointF[6];
            resultPoints[0] = vertex;
            double angle = 60;

            System.Drawing.Drawing2D.Matrix rotationMatrix = new System.Drawing.Drawing2D.Matrix();

            for (int i = 1; i <= 5; i++)
            {
                rotationMatrix.Reset();
                rotationMatrix.RotateAt((float)(angle), center);

                // Apply the rotation to the previous point
                PointF[] pointArray = { resultPoints[i - 1] };
                rotationMatrix.TransformPoints(pointArray);
                resultPoints[i] = pointArray[0];
            }

            vertices = resultPoints;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = "Grid Scale(pixels per step):" + trackBar1.Value;
            if (vertices != null)
            {
                center = new PointF((float)(center.X - width / 2)/step, -(float)(center.Y - height / 2)/step);
                PointF vertice = new PointF((float)(vertices[0].X - width / 2)/step, -(float)(vertices[0].Y  - height / 2)/step);

                step = trackBar1.Value;

                center = new PointF((float)(center.X * step) + width / 2, -(float)(center.Y * step) + height / 2);
                vertice = new PointF((float)(vertice.X * step) + width / 2, -(float)(vertice.Y * step) + height / 2);
                
                using (Graphics graphics = Graphics.FromImage(picture))
                {

                    drawGrid(graphics);
                    DrawHexagon(graphics, center, vertice);
                }
                pictureBox1.Image = picture;
            }
            else
            {
                step = trackBar1.Value;
                using (Graphics graphics = Graphics.FromImage(picture))
                {
                    drawGrid(graphics);
                }
            }
        }

        private void MovingImageForm_Load(object sender, EventArgs e)
        {
            StaticMethods.RoundButton(button1);
            StaticMethods.RoundButton(button2);
            StaticMethods.RoundButton(button3);
            StaticMethods.RoundButton(button4);
            StaticMethods.RoundButton(button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm(InfoType.Moving_Images);
            infoForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap savingPicture = new Bitmap(1024, 1024);
            center = new PointF((float)(numericUpDown1.Value * step) + width / 2, -(float)(numericUpDown2.Value * step) + height / 2);
            PointF vertice = new PointF((float)(numericUpDown3.Value * step) + width / 2, -(float)(numericUpDown4.Value * step) + height / 2);

            using (Graphics graphics = Graphics.FromImage(savingPicture))
            {
                drawGrid(graphics);
                DrawHexagon(graphics, center, vertice);
            }
            saveFileDialog1.Filter = "PNG Image|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                savingPicture.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
