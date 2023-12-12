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
    public partial class QuizForm : Form
    {
        InfoType infoType;
        List<List<RadioButton>> answers;
        int result = 0;
        public QuizForm(InfoType infoType)
        {
            InitializeComponent();
            answers = new List<List<RadioButton>>();
            this.infoType = infoType;
            switch (infoType)
            {
                case InfoType.Fractal:
                    InitializeQuizFractal();
                    label1.Text = "POP-QUIZ ON FRACTALS";
                    break;
                case InfoType.Color_Schemes:
                    InitializeQuizColorSchemes();
                    label1.Text = "POP-QUIZ ON COLOR SCHEMES";
                    break;
                case InfoType.Moving_Images:
                    InitializeQuizMovingImagesl();
                    label1.Text = "POP-QUIZ ON MOVING IMAGES";
                    break;
            }
            FontInit();
            StaticMethods.RoundButton(button1);
            StaticMethods.RoundButton(button2);
        }

        private void InitializeQuizMovingImagesl()
        {
            int ihms = 370;
            panelQuiz.AutoScroll = true;
            Controls.Add(panelQuiz);
            int i = 1;
            // q1
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"How is translation achieved in affine transformations?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                _answers.Add(radioA);
                radioA.Text = "Multiplying coordinates by scaling factors";
                RadioButton radioB = new RadioButton();
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                _answers.Add(radioB);
                radioB.Text = "Adding a translation vector to coordinates";
                RadioButton radioC = new RadioButton();
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                _answers.Add(radioC);
                radioC.Text = "Rotating objects about a chosen point";
                RadioButton radioD = new RadioButton();
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;
                _answers.Add(radioD);
                radioD.Text = "Shearing along the x-axis";

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 150;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q2
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What matrix represents a rotation transformation by an angle θ";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "[cos(θ) -sin(θ)]\r\n[sin(θ) cos(θ)]";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "[cos(θ) -sin(θ) 0]\r\n[-sin(θ) cos(θ) 0]\r\n";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "[cos(θ) -sin(θ) 0]\r\n[sin(θ) cos(θ) 0]\r\n[0 0 1]\r\n";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "[cos(θ) -sin(θ) 0]\r\n[sin(θ) cos(θ) 0]\r\n";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 110);
                radioC.Location = new System.Drawing.Point(10, yOffset + 180);
                radioD.Location = new System.Drawing.Point(10, yOffset + 280);
                i++;
            }
            // q3
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"Scaling transforms objects by multiplying their coordinates by scaling factors along which axes?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "x-axis";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "y-axis";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Both x-axis and y-axis";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "z-axis";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170+190;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q4
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What matrix represents a scaling transformation with scaling factors sx and sy?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "[sx 0]\r\n[0sy]";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "[sx 0 0]\r\n[0 sy 0]\r\n[0 0 1]";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "[sx 0]\r\n[0 sy]\r\n[0 0]";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "[sx sy 0]\r\n[sy sx 0]\r\n[0 0 1]";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170+180;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 100);
                radioC.Location = new System.Drawing.Point(10, yOffset + 200);
                radioD.Location = new System.Drawing.Point(10, yOffset + 300);
                i++;
            }
            // q5
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What does shearing do in affine transformations?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Adds translation to coordinates";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Rotates objects about a chosen point";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Skews the shape of objects along an axis";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Changes the vividness of colors";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170+160+140+110;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q6
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What matrix represents shearing along the x-axis with a shear factor k?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "[1 k]\r\n[0 1]\r\n";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "[1 0 0]\r\n[k 1 0]\r\n[0 0 1]";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "[1 k 0]\r\n[0 1 0]\r\n[0 0 1]";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "[1 0 0]\r\n[0 1 k]";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170+160+240;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 110);
                radioC.Location = new System.Drawing.Point(10, yOffset + 210);
                radioD.Location = new System.Drawing.Point(10, yOffset + 310);
                i++;
            }
            // q7
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"Which transformation is associated with a tilt of objects?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Translation";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Rotation";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Scaling";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Shearing";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170+240+ihms;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q8
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What is the purpose of the third row in transformation matrices?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Controls translation";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Defines scaling factors";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Maintains object orientation";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Handles 3D transformations";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170 + 240 + ihms;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q9
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"Affine transformations operate in which-dimensional space?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "One-dimensional";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Two-dimensional";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Three-dimensional";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Any dimensions";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170 + 240 + ihms;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q10
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"In the rotation matrix, what are the roles of cos(θ) and sin(θ)?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Control scaling factors";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Influence rotation angle";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Determine shear factors";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Specify translation vector";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170 + 240 + ihms;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
        }

        private void InitializeQuizColorSchemes()
        {
            panelQuiz.AutoScroll = true;
            Controls.Add(panelQuiz);
            int i = 1;
            // q1
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What does RGB stand for in computer graphics?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                _answers.Add(radioA);
                radioA.Text = "Red, Green, Black";
                RadioButton radioB = new RadioButton();
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                _answers.Add(radioB);
                radioB.Text = "Red, Green, Blue";
                RadioButton radioC = new RadioButton();
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                _answers.Add(radioC);
                radioC.Text = "Rainbow, Gold, Bronze";
                RadioButton radioD = new RadioButton();
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;
                _answers.Add(radioD);
                radioD.Text = "Royal, Green, Brown";

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 150;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q2
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"In the HSL color model, what does \"Saturation\" control?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Brightness";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Vividness";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Type of color";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Intensity";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q3
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What does the \"V\" stand for in the HSV color model?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Vibrance";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Value";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Variety";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Vividness";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q4
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"Which color space is designed to be more consistent with human vision?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "RGB";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "CMYK";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Lab";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "HSL";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q5
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What does the \"L*\" component represent in the Lab color space?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Lightness";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Luminosity";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Lavender";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Lime";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q6
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"Which color model operates in a cylindrical color space?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "RGB";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "HSL";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "HSV";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "CMYK";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q7
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What is the primary purpose of the CMYK color model?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Web design";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Printing";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Digital art";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Video editing";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q8
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"In the RGB color model, how are colors represented?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "By subtracting colors";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "By combining red, green, and yellow";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "By combining varying intensities of red, green, and blue";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "By using a grayscale spectrum";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q9
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What does the \"H\" in both HSL and HSV color models stand for?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Hue";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Highness";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Hyperactivity";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Harmony";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
            // q10
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"In the CMYK color model, what does the 'Key/Black' component represent?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Vividness of color";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Lightness of color";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Intensity of color";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Amount of black ink";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 30);
                radioB.Location = new System.Drawing.Point(10, yOffset + 60);
                radioC.Location = new System.Drawing.Point(10, yOffset + 90);
                radioD.Location = new System.Drawing.Point(10, yOffset + 120);
                i++;
            }
        }

        private void InitializeQuizFractal()
        {
            panelQuiz.AutoScroll = true;
            Controls.Add(panelQuiz);
            int i = 1;
            // q1
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What does the term \"fractal\" derive from?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                _answers.Add(radioA);
                radioA.Text = "Fractured";
                RadioButton radioB = new RadioButton();
                radioB.AutoSize = true; 
                radioB.AutoEllipsis = false;
                _answers.Add(radioB);
                radioB.Text = "Fractalus";
                RadioButton radioC = new RadioButton();
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                _answers.Add(radioC);
                radioC.Text = "Fractus";
                RadioButton radioD = new RadioButton();
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;
                _answers.Add(radioD);
                radioD.Text = "Fraction";

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 150;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 70);
                radioC.Location = new System.Drawing.Point(10, yOffset + 100);
                radioD.Location = new System.Drawing.Point(10, yOffset + 130);
                i++;
            }
            // q2
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"Which mathematician is associated with the Mandelbrot Set?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Albert Einstein";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Isaac Newton";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Benoît Mandelbrot";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Euclid";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 70);
                radioC.Location = new System.Drawing.Point(10, yOffset + 100);
                radioD.Location = new System.Drawing.Point(10, yOffset + 130);
                i++;
            }
            // q3
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"The Koch Snowflake is an example of a fractal curve constructed through:";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Recursion";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Integration";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Differentiation";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Interpolation";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 70);
                radioC.Location = new System.Drawing.Point(10, yOffset + 100);
                radioD.Location = new System.Drawing.Point(10, yOffset + 130);
                i++;
            }
            // q4
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What role does recursion play in fractal generation?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "It adds complexity";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "It removes patterns";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "It creates self-replicating structures";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "It simplifies shapes";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 70);
                radioC.Location = new System.Drawing.Point(10, yOffset + 100);
                radioD.Location = new System.Drawing.Point(10, yOffset + 130);
                i++;
            }
            // q5
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"Which complex number system is fundamental to the Mandelbrot and Julia sets?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Real numbers";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Imaginary numbers";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Prime numbers";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Complex numbers";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 70);
                radioC.Location = new System.Drawing.Point(10, yOffset + 100);
                radioD.Location = new System.Drawing.Point(10, yOffset + 130);
                i++;
            }
            // q6
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"The Sierpinski Triangle is formed by:";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Adding triangles";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Removing triangles";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Rotating triangles";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Expanding triangles";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 70);
                radioC.Location = new System.Drawing.Point(10, yOffset + 100);
                radioD.Location = new System.Drawing.Point(10, yOffset + 130);
                i++;
            }
            // q7
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What does the Julia Set exhibit?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Linear patterns";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Self-similarity";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Circular shapes";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Random configurations";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 70);
                radioC.Location = new System.Drawing.Point(10, yOffset + 100);
                radioD.Location = new System.Drawing.Point(10, yOffset + 130);
                i++;
            }
            // q8
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"What is the Koch Snowflake?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "A polynomial equation";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "A fractal curve";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "A geometric theorem";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "A trigonometric function";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 70);
                radioC.Location = new System.Drawing.Point(10, yOffset + 100);
                radioD.Location = new System.Drawing.Point(10, yOffset + 130);
                i++;
            }
            // q9
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"In fractal generation, what does the term \"iterative\" refer to?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Complex calculations";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Repetitive processes";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Recursive patterns";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Singular operations";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 70);
                radioC.Location = new System.Drawing.Point(10, yOffset + 100);
                radioD.Location = new System.Drawing.Point(10, yOffset + 130);
                i++;
            }
            // q10
            {
                Panel questionPanel = new Panel();
                List<RadioButton> _answers = new List<RadioButton>();
                panelQuiz.Controls.Add(questionPanel);
                questionPanel.AutoSize = true;
                // Create a label for the question
                Label lblQuestion = new Label();
                lblQuestion.Text = $"Which fractal is named after a Polish mathematician?";
                lblQuestion.AutoSize = true;
                // Create radio buttons for answer choices
                RadioButton radioA = new RadioButton();
                _answers.Add(radioA);
                radioA.Text = "Mandelbrot Set";
                RadioButton radioB = new RadioButton();
                _answers.Add(radioB);
                radioB.Text = "Koch Snowflake";
                RadioButton radioC = new RadioButton();
                _answers.Add(radioC);
                radioC.Text = "Julia Set";
                RadioButton radioD = new RadioButton();
                _answers.Add(radioD);
                radioD.Text = "Sierpinski Triangle";

                radioA.AutoSize = true;
                radioA.AutoEllipsis = false;
                radioB.AutoSize = true;
                radioB.AutoEllipsis = false;
                radioC.AutoSize = true;
                radioC.AutoEllipsis = false;
                radioD.AutoSize = true;
                radioD.AutoEllipsis = false;

                // Add controls to the panel
                questionPanel.Controls.Add(lblQuestion);
                questionPanel.Controls.Add(radioA);
                questionPanel.Controls.Add(radioB);
                questionPanel.Controls.Add(radioC);
                questionPanel.Controls.Add(radioD);
                answers.Add(_answers);

                // Set the position of controls based on the question number
                int yOffset = (i - 1) * 170;
                lblQuestion.Location = new System.Drawing.Point(10, yOffset);
                radioA.Location = new System.Drawing.Point(10, yOffset + 40);
                radioB.Location = new System.Drawing.Point(10, yOffset + 70);
                radioC.Location = new System.Drawing.Point(10, yOffset + 100);
                radioD.Location = new System.Drawing.Point(10, yOffset + 130);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] answerCodes = new int[] { };
            result = 0;
            switch(infoType)
            {
                case InfoType.Fractal:
                    answerCodes = new int[] { 2, 2, 0, 2, 3, 1, 1, 1, 1, 3 };
                    break;
                case InfoType.Color_Schemes:
                    answerCodes = new int[] { 1, 1, 1, 2, 0, 2, 1, 2, 0, 3 };
                    break;
                case InfoType.Moving_Images:
                    answerCodes = new int[] { 1, 2, 2, 1, 2, 2, 3, 2, 3, 1 };
                    break;
            }
            int i = 0;
            foreach(var questions in answers)
            {
                questions[answerCodes[i]].ForeColor = Color.Green;
                if (questions[answerCodes[i]].Checked)
                {
                    result++;
                }
                else
                {
                    foreach(var q in questions)
                    {
                        if(q.Checked)
                        {
                            q.ForeColor = Color.Red;
                        }
                    }
                }
                i++;
            }
            label2.Text = $"Your result: {result}/10";
        }
        private void FontInit()
        {
            foreach (Control c in panelQuiz.Controls)
            {
                c.Font = new Font("Comic Sans MS", 16);
            }
            label1.Font = new Font("Trebuchet MS", label1.Font.Size) ;
        }
    }
}
