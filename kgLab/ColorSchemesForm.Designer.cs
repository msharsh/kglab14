namespace kgLab
{
    partial class ColorSchemesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.RGBTB = new System.Windows.Forms.TextBox();
            this.HSLTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LightnessBar = new System.Windows.Forms.TrackBar();
            this.ColorPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LightnessPercentage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ColorRB = new System.Windows.Forms.RadioButton();
            this.FragmentRB = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(26)))));
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 110);
            this.label1.TabIndex = 5;
            this.label1.Text = "COLOR SCHEMES";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(116)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(26)))));
            this.button1.Location = new System.Drawing.Point(28, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 88);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pick color";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(26)))));
            this.button2.Location = new System.Drawing.Point(28, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(569, 88);
            this.button2.TabIndex = 10;
            this.button2.Text = "Load .png file";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(26)))));
            this.label2.Location = new System.Drawing.Point(354, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 60);
            this.label2.TabIndex = 11;
            this.label2.Text = "RGB:";
            // 
            // RGBTB
            // 
            this.RGBTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RGBTB.Location = new System.Drawing.Point(469, 169);
            this.RGBTB.Name = "RGBTB";
            this.RGBTB.ReadOnly = true;
            this.RGBTB.Size = new System.Drawing.Size(393, 56);
            this.RGBTB.TabIndex = 12;
            // 
            // HSLTB
            // 
            this.HSLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HSLTB.Location = new System.Drawing.Point(469, 231);
            this.HSLTB.Name = "HSLTB";
            this.HSLTB.ReadOnly = true;
            this.HSLTB.Size = new System.Drawing.Size(393, 56);
            this.HSLTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(26)))));
            this.label3.Location = new System.Drawing.Point(354, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 60);
            this.label3.TabIndex = 13;
            this.label3.Text = "HSL:";
            // 
            // LightnessBar
            // 
            this.LightnessBar.Location = new System.Drawing.Point(363, 332);
            this.LightnessBar.Maximum = 100;
            this.LightnessBar.Minimum = -100;
            this.LightnessBar.Name = "LightnessBar";
            this.LightnessBar.Size = new System.Drawing.Size(464, 45);
            this.LightnessBar.TabIndex = 15;
            this.LightnessBar.Scroll += new System.EventHandler(this.LightnessBar_Scroll);
            this.LightnessBar.ValueChanged += new System.EventHandler(this.LightnessBar_ValueChanged);
            // 
            // ColorPictureBox
            // 
            this.ColorPictureBox.Location = new System.Drawing.Point(28, 279);
            this.ColorPictureBox.Name = "ColorPictureBox";
            this.ColorPictureBox.Size = new System.Drawing.Size(320, 88);
            this.ColorPictureBox.TabIndex = 9;
            this.ColorPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(868, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 1024);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // LightnessPercentage
            // 
            this.LightnessPercentage.AutoSize = true;
            this.LightnessPercentage.Location = new System.Drawing.Point(822, 322);
            this.LightnessPercentage.Name = "LightnessPercentage";
            this.LightnessPercentage.Size = new System.Drawing.Size(21, 13);
            this.LightnessPercentage.TabIndex = 16;
            this.LightnessPercentage.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(496, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 33);
            this.label4.TabIndex = 17;
            this.label4.Text = "Change lightness";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(26)))));
            this.button4.Location = new System.Drawing.Point(28, 535);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(569, 88);
            this.button4.TabIndex = 18;
            this.button4.Text = "Save to .png";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ColorRB
            // 
            this.ColorRB.AutoSize = true;
            this.ColorRB.Checked = true;
            this.ColorRB.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorRB.Location = new System.Drawing.Point(363, 371);
            this.ColorRB.Name = "ColorRB";
            this.ColorRB.Size = new System.Drawing.Size(222, 30);
            this.ColorRB.TabIndex = 19;
            this.ColorRB.TabStop = true;
            this.ColorRB.Text = "Change color lightness";
            this.ColorRB.UseVisualStyleBackColor = true;
            this.ColorRB.CheckedChanged += new System.EventHandler(this.ColorRB_CheckedChanged);
            // 
            // FragmentRB
            // 
            this.FragmentRB.AutoSize = true;
            this.FragmentRB.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FragmentRB.Location = new System.Drawing.Point(363, 407);
            this.FragmentRB.Name = "FragmentRB";
            this.FragmentRB.Size = new System.Drawing.Size(260, 30);
            this.FragmentRB.TabIndex = 20;
            this.FragmentRB.TabStop = true;
            this.FragmentRB.Text = "Change fragment lightness";
            this.FragmentRB.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(28, 968);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 84);
            this.button3.TabIndex = 21;
            this.button3.Text = "< Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(26)))));
            this.button6.Location = new System.Drawing.Point(28, 753);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(429, 88);
            this.button6.TabIndex = 22;
            this.button6.Text = "Info";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ColorSchemesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(245)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FragmentRB);
            this.Controls.Add(this.ColorRB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LightnessPercentage);
            this.Controls.Add(this.LightnessBar);
            this.Controls.Add(this.HSLTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RGBTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ColorPictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorSchemesForm";
            this.Text = "ColorSchemesForm";
            this.Load += new System.EventHandler(this.ColorSchemesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ColorPictureBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RGBTB;
        private System.Windows.Forms.TextBox HSLTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar LightnessBar;
        private System.Windows.Forms.Label LightnessPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton ColorRB;
        private System.Windows.Forms.RadioButton FragmentRB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
    }
}