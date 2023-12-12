using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgLab
{
    
    public partial class FractalsForm : Form
    {
        NewtonsFractal newtonsFractal;
        Color[] colors;
        FractalType type = FractalType.Blank;
        public FractalsForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            newtonsFractal = new NewtonsFractal(pictureBox1);
            colors = new Color[5];
            colors[0] = Color.FromArgb(172, 146, 235);
            colors[1] = Color.FromArgb(79, 193, 232);
            colors[2] = Color.FromArgb(160, 213, 104);
            colors[3] = Color.FromArgb(255, 206, 84);
            colors[4] = Color.FromArgb(237, 55, 100);

            StaticMethods.RoundButton(button1);
            StaticMethods.RoundButton(button2);
            StaticMethods.RoundButton(button3);
            StaticMethods.RoundButton(button4);
            StaticMethods.RoundButton(button5);
            StaticMethods.RoundButton(button6);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            newtonsFractal.SetConst((double)numericUpDown1.Value, (double)numericUpDown2.Value);
            newtonsFractal.Reset();
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = newtonsFractal.CreateFractal();
            type = FractalType.Newton;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrostyFractal fractal = new FrostyFractal(1000, (int)numericUpDown3.Value, pictureBox1, colors[0]);
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = fractal.CreateFractal(colors[1]);
            type = FractalType.Frosty;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (type == FractalType.Newton)
            {
                if (e.Button == MouseButtons.Left)
                    newtonsFractal.Zoom(e.Location.X, e.Location.Y, true);
                if (e.Button == MouseButtons.Right)
                    newtonsFractal.Zoom(e.Location.X, e.Location.Y, false);
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();
                pictureBox1.Image = newtonsFractal.CreateFractal();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorPickerForm colorPickerForm= new ColorPickerForm(colors);
            if(colorPickerForm.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i<colors.Length; i++)
                {
                    colors[i] = colorPickerForm.colors[i];
                    newtonsFractal.SetSolutionColor(colors[i], i);
                }
                if (type == FractalType.Newton)
                {
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();
                    pictureBox1.Image = newtonsFractal.CreateFractal();
                }
                if(type == FractalType.Frosty)
                {
                    FrostyFractal fractal = new FrostyFractal(1000, (int)numericUpDown3.Value, pictureBox1, colors[0]);
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();
                    pictureBox1.Image = fractal.CreateFractal(colors[1]);
                }
            }
        }
        enum FractalType
        {
            Blank,
            Newton,
            Frosty
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "BMP Image|*.bmp";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                pictureBox1.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Bmp);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InfoForm fractalInfo = new InfoForm(InfoType.Fractal);
            fractalInfo.Show();
        }
    }
}
