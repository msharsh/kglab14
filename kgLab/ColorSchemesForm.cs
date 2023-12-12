using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgLab
{
    public partial class ColorSchemesForm : Form
    {
        Color SelectedColor = Color.FromArgb(0,0,0,0);
        HSLColor SelectedColorHSL;
        bool colorPickingMode = false;
        Bitmap originalImage;
        Point fragmentTopLeft, fragmentBottomRight;
        int mouseStartX, mouseStartY;
        bool isBeingSelected = false;
        bool isColorChange = true;
        public ColorSchemesForm()
        {
            InitializeComponent();
            originalImage = new Bitmap(pictureBox1.Height, pictureBox1.Width);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorPickingMode = !colorPickingMode;
            if(colorPickingMode)
            {
                this.Cursor = new Cursor("cursor.cur");
                pictureBox1.MouseClick += pictureBox1_MouseClick;
            }
            else
            {
                this.Cursor = Cursors.Default;
                pictureBox1.MouseClick -= pictureBox1_MouseClick;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            SelectedColor = originalImage.GetPixel(e.X, e.Y);
            ColorPictureBox.BackColor= SelectedColor;
            colorPickingMode = false;
            this.Cursor = Cursors.Default;
            RGBTB.Text = SelectedColor.R + ", " + SelectedColor.G + ", " + SelectedColor.B;
            SelectedColorHSL = HSLColor.FromRGB(SelectedColor);
            HSLTB.Text = Math.Round(SelectedColorHSL.H*360) + "°, " + Math.Round(SelectedColorHSL.S, 3) + ", " + Math.Round(SelectedColorHSL.L,3);
            LightnessBar.Value = 0;
            pictureBox1.MouseClick -= pictureBox1_MouseClick;
            pictureBox1.DrawToBitmap(originalImage, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path and display it in the PictureBox.
                string selectedFilePath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(selectedFilePath);
                originalImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(originalImage, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            }
        }

        private void LightnessBar_ValueChanged(object sender, EventArgs e)
        {
            int value = LightnessBar.Value;
            LightnessPercentage.Text = value + "%";
            
            if (LightnessBar.Value != 0)
            {
                Bitmap image = new Bitmap(originalImage);
                if (isColorChange)
                {
                    if (SelectedColor != Color.FromArgb(0,0,0,0))
                    {
                        for (int i = 0; i < originalImage.Height; i++)
                        {
                            for (int j = 0; j < originalImage.Width; j++)
                            {
                                HSLColor newColor = HSLColor.FromRGB(SelectedColor);
                                if (value > 0)
                                {
                                    newColor.L = newColor.L + ((1.0 - newColor.L) * (value / 100.0));
                                }
                                if (value < 0)
                                {
                                    newColor.L = newColor.L + (newColor.L * (value / 100.0));
                                }
                                if (originalImage.GetPixel(i, j) == SelectedColor)
                                {
                                    image.SetPixel(i, j, newColor.ToRGB());

                                    RGBTB.Text = newColor.ToRGB().R + ", " + newColor.ToRGB().G + ", " + newColor.ToRGB().B;
                                    HSLTB.Text = Math.Round(newColor.H * 360) + "°, " + Math.Round(newColor.S , 3) + ", " + Math.Round(newColor.L, 3);
                                    ColorPictureBox.BackColor = newColor.ToRGB();
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = fragmentTopLeft.X; i < fragmentBottomRight.X; i++)
                    {
                        for (int j = fragmentTopLeft.Y; j < fragmentBottomRight.Y; j++)
                        {
                            HSLColor curColor = HSLColor.FromRGB(originalImage.GetPixel(i,j));
                            if (value > 0)
                            {
                                curColor.L = curColor.L + ((1.0 - curColor.L) * (value / 100.0));
                            }
                            if (value < 0)
                            {
                                curColor.L = curColor.L + (curColor.L * (value / 100.0));
                            }
                            image.SetPixel(i, j, curColor.ToRGB());
                        }
                    }
                }
                pictureBox1.Image = image;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Image|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                pictureBox1.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isColorChange)
            {
                if (isBeingSelected)
                {
                    using(Graphics g =  pictureBox1.CreateGraphics())
                    {
                        Pen bluePen = new Pen(Color.Blue, 2);
                        bluePen.DashStyle = DashStyle.Dash;

                        int x = Math.Min(mouseStartX, e.X);
                        int y = Math.Min(mouseStartY, e.Y);
                        int width = Math.Abs(mouseStartX - e.X);
                        int height = Math.Abs(mouseStartY - e.Y);

                        g.DrawRectangle(bluePen, x, y, width, height);

                        bluePen.Dispose();
                    }
                    pictureBox1.Invalidate();
                }
            }
        }

        private void ColorRB_CheckedChanged(object sender, EventArgs e)
        {
            isColorChange = !isColorChange;
            pictureBox1.Invalidate();
            pictureBox1.DrawToBitmap(originalImage, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            LightnessBar.Value = 0;
        }

        private void LightnessBar_Scroll(object sender, EventArgs e)
        {

        }

        private void ColorSchemesForm_Load(object sender, EventArgs e)
        {
            StaticMethods.RoundButton(button1);
            StaticMethods.RoundButton(button2);
            StaticMethods.RoundButton(button3);
            StaticMethods.RoundButton(button4);
            //StaticMethods.RoundButton(button5);
            StaticMethods.RoundButton(button6);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm(InfoType.Color_Schemes);
            infoForm.Show();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isColorChange)
            {
                mouseStartX = e.X;
                mouseStartY = e.Y;
                isBeingSelected = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isColorChange)
            {
                isBeingSelected = false;
                
                int  mouseEndX = e.X;
                int mouseEndY = e.Y;
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    Pen bluePen = new Pen(Color.Red, 1);
                    bluePen.DashStyle = DashStyle.Dash;

                    int x = Math.Min(mouseStartX, e.X);
                    int y = Math.Min(mouseStartY, e.Y);
                    int width = Math.Abs(mouseStartX - e.X);
                    int height = Math.Abs(mouseStartY - e.Y);

                    g.DrawRectangle(bluePen, x, y, width, height);

                    bluePen.Dispose();
                }

                int xTopLeft = Math.Max(Math.Min(mouseStartX, mouseEndX), 0);
                int yTopLeft = Math.Max(Math.Min(mouseStartY, mouseEndY), 0);
                int xBottomRight = Math.Min(Math.Max(mouseStartX, mouseEndX), pictureBox1.Width);
                int yBottomRight = Math.Min(Math.Max(mouseStartY, mouseEndY), pictureBox1.Height);

                fragmentTopLeft = new Point(xTopLeft, yTopLeft);
                fragmentBottomRight = new Point(xBottomRight, yBottomRight);

                pictureBox1.DrawToBitmap(originalImage, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            }
        }
    }
}
