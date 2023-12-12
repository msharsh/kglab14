using kgLab.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgLab
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FractalsForm fractalForm = new FractalsForm();
            fractalForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorSchemesForm colorSchemesForm = new ColorSchemesForm();
            colorSchemesForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovingImageForm movingImageForm = new MovingImageForm();
            movingImageForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            StaticMethods.RoundButton(button1);
            StaticMethods.RoundButton(button2);
            StaticMethods.RoundButton(button3);
            StaticMethods.RoundButton(button4);
        }

        private void FontInit()
        {
            
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
