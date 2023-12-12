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
    public partial class ColorPickerForm : Form
    {
        public Color[] colors = new Color[5];
        PictureBox[] pictureBoxes;
        public ColorPickerForm(Color[] colors)
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[5] {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5};
            for(int i=0; i<colors.Length; i++)
            {
                this.colors[i] = colors[i];
                pictureBoxes[i].BackColor = colors[i];
            }
        }

        private void ChangeColor(int ind)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colors[ind] = colorDialog1.Color;
            }
            pictureBoxes[ind].BackColor = colors[ind];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChangeColor(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChangeColor(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChangeColor(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChangeColor(3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeColor(4);
        }

        private void ColorPickerForm_Load(object sender, EventArgs e)
        {
            StaticMethods.RoundButton(button2);
            StaticMethods.RoundButton(button3);
        }
    }
}
