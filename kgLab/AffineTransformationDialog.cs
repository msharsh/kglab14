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
    public partial class AffineTransformationDialog : Form
    {
        public AffineTransformationInfo affineInfo;
        public AffineTransformationDialog()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            int _angle = (int) numericUpDown2.Value;
            double _scale = (double) numericUpDown1.Value;
            int _vertex = comboBox1.SelectedIndex;
            affineInfo = new AffineTransformationInfo { vertex = _vertex, angle = _angle, scale = _scale };
        }

        private void AffineTransformationDialog_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            StaticMethods.RoundButton(button1);
            StaticMethods.RoundButton(button3);
        }
    }

    public struct AffineTransformationInfo
    {
        public int vertex;
        public double angle;
        public double scale;
    }
}
