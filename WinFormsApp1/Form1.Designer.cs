namespace WinFormsApp1
{
    partial class MyFirstProgram
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyFirstProgram));
            notification = new NotifyIcon(components);
            rickRollButton = new Button();
            germanButton = new Button();
            spanishButton = new Button();
            italianButton = new Button();
            instructionLabel = new Label();
            translationLabel = new Label();
            canadaFlag = new PictureBox();
            usaFlag = new PictureBox();
            mexicanFlag = new PictureBox();
            countryQuestion = new Label();
            flagLabel = new Label();
            exitButton = new Button();
            firstName = new TextBox();
            nameDisplay = new Label();
            readInput = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            outputBoxTest = new Label();
            lastName = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            bmiCalculateButton = new Button();
            bmiOutputTextBox = new Label();
            label4 = new Label();
            label3 = new Label();
            heightTextBox = new TextBox();
            weightTextBox = new TextBox();
            Dogs = new ListBox();
            ((System.ComponentModel.ISupportInitialize)canadaFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usaFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mexicanFlag).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // notification
            // 
            notification.Text = "You have been hacked :)";
            notification.Visible = true;
            // 
            // rickRollButton
            // 
            rickRollButton.Location = new Point(12, 682);
            rickRollButton.Name = "rickRollButton";
            rickRollButton.Size = new Size(119, 79);
            rickRollButton.TabIndex = 11;
            rickRollButton.Text = "Rick Roll Button";
            rickRollButton.UseVisualStyleBackColor = true;
            rickRollButton.Click += rickRollButton_Click;
            // 
            // germanButton
            // 
            germanButton.Location = new Point(12, 129);
            germanButton.Name = "germanButton";
            germanButton.Size = new Size(131, 40);
            germanButton.TabIndex = 1;
            germanButton.Text = "German";
            germanButton.UseVisualStyleBackColor = true;
            germanButton.Click += germanButton_Click;
            // 
            // spanishButton
            // 
            spanishButton.Location = new Point(170, 129);
            spanishButton.Name = "spanishButton";
            spanishButton.Size = new Size(131, 40);
            spanishButton.TabIndex = 2;
            spanishButton.Text = "Spanish";
            spanishButton.UseVisualStyleBackColor = true;
            spanishButton.Click += spanishButton_Click;
            // 
            // italianButton
            // 
            italianButton.Location = new Point(317, 129);
            italianButton.Name = "italianButton";
            italianButton.Size = new Size(131, 40);
            italianButton.TabIndex = 3;
            italianButton.Text = "Italian";
            italianButton.UseVisualStyleBackColor = true;
            italianButton.Click += italianButton_Click;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(12, 24);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(448, 30);
            instructionLabel.TabIndex = 14;
            instructionLabel.Text = "Select a language and I will say Good Morning.";
            // 
            // translationLabel
            // 
            translationLabel.BorderStyle = BorderStyle.FixedSingle;
            translationLabel.Location = new Point(12, 77);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(411, 37);
            translationLabel.TabIndex = 0;
            translationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // canadaFlag
            // 
            canadaFlag.Image = (Image)resources.GetObject("canadaFlag.Image");
            canadaFlag.Location = new Point(547, 97);
            canadaFlag.Name = "canadaFlag";
            canadaFlag.Size = new Size(188, 113);
            canadaFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            canadaFlag.TabIndex = 8;
            canadaFlag.TabStop = false;
            canadaFlag.Click += pictureBox1_Click_1;
            // 
            // usaFlag
            // 
            usaFlag.Image = (Image)resources.GetObject("usaFlag.Image");
            usaFlag.Location = new Point(755, 97);
            usaFlag.Name = "usaFlag";
            usaFlag.Size = new Size(176, 113);
            usaFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            usaFlag.TabIndex = 9;
            usaFlag.TabStop = false;
            usaFlag.Click += usaFlag_Click;
            // 
            // mexicanFlag
            // 
            mexicanFlag.Image = (Image)resources.GetObject("mexicanFlag.Image");
            mexicanFlag.Location = new Point(954, 97);
            mexicanFlag.Name = "mexicanFlag";
            mexicanFlag.Size = new Size(193, 113);
            mexicanFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            mexicanFlag.TabIndex = 10;
            mexicanFlag.TabStop = false;
            mexicanFlag.Click += mexicanFlag_Click;
            // 
            // countryQuestion
            // 
            countryQuestion.AutoSize = true;
            countryQuestion.Location = new Point(755, 24);
            countryQuestion.Name = "countryQuestion";
            countryQuestion.Size = new Size(207, 30);
            countryQuestion.TabIndex = 15;
            countryQuestion.Text = "What country is this?";
            // 
            // flagLabel
            // 
            flagLabel.BorderStyle = BorderStyle.FixedSingle;
            flagLabel.Location = new Point(656, 281);
            flagLabel.Name = "flagLabel";
            flagLabel.Size = new Size(379, 69);
            flagLabel.TabIndex = 13;
            flagLabel.TextAlign = ContentAlignment.MiddleCenter;
            flagLabel.Click += flagLabel_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1110, 721);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(131, 40);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // firstName
            // 
            firstName.Location = new Point(238, 274);
            firstName.Name = "firstName";
            firstName.Size = new Size(175, 35);
            firstName.TabIndex = 4;
            // 
            // nameDisplay
            // 
            nameDisplay.BackColor = SystemColors.ButtonFace;
            nameDisplay.BorderStyle = BorderStyle.FixedSingle;
            nameDisplay.Location = new Point(385, 360);
            nameDisplay.Name = "nameDisplay";
            nameDisplay.Size = new Size(184, 40);
            nameDisplay.TabIndex = 8;
            // 
            // readInput
            // 
            readInput.Location = new Point(248, 356);
            readInput.Name = "readInput";
            readInput.Size = new Size(131, 40);
            readInput.TabIndex = 6;
            readInput.Text = "Read Input";
            readInput.UseVisualStyleBackColor = true;
            readInput.Click += readInput_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 274);
            label1.Name = "label1";
            label1.Size = new Size(212, 30);
            label1.TabIndex = 16;
            label1.Text = "Enter your first name:";
            // 
            // button1
            // 
            button1.Location = new Point(238, 448);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 18;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(268, 486);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 19;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(248, 402);
            button3.Name = "button3";
            button3.Size = new Size(131, 40);
            button3.TabIndex = 7;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // outputBoxTest
            // 
            outputBoxTest.BorderStyle = BorderStyle.FixedSingle;
            outputBoxTest.Location = new Point(24, 474);
            outputBoxTest.Name = "outputBoxTest";
            outputBoxTest.Size = new Size(321, 43);
            outputBoxTest.TabIndex = 10;
            // 
            // lastName
            // 
            lastName.Location = new Point(238, 315);
            lastName.Name = "lastName";
            lastName.Size = new Size(175, 35);
            lastName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 315);
            label2.Name = "label2";
            label2.Size = new Size(209, 30);
            label2.TabIndex = 17;
            label2.Text = "Enter your last name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bmiCalculateButton);
            groupBox1.Controls.Add(bmiOutputTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(heightTextBox);
            groupBox1.Controls.Add(weightTextBox);
            groupBox1.Location = new Point(649, 458);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 245);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "BMI Calculator";
            // 
            // bmiCalculateButton
            // 
            bmiCalculateButton.Location = new Point(186, 181);
            bmiCalculateButton.Name = "bmiCalculateButton";
            bmiCalculateButton.Size = new Size(131, 40);
            bmiCalculateButton.TabIndex = 5;
            bmiCalculateButton.Text = "Calculate";
            bmiCalculateButton.UseVisualStyleBackColor = true;
            bmiCalculateButton.Click += bmiCalculateButton_Click;
            // 
            // bmiOutputTextBox
            // 
            bmiOutputTextBox.Location = new Point(33, 182);
            bmiOutputTextBox.Name = "bmiOutputTextBox";
            bmiOutputTextBox.Size = new Size(111, 39);
            bmiOutputTextBox.TabIndex = 4;
            bmiOutputTextBox.Click += bmiOutputTextBox_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 118);
            label4.Name = "label4";
            label4.Size = new Size(75, 30);
            label4.TabIndex = 3;
            label4.Text = "Height";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 62);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 2;
            label3.Text = "Weight";
            label3.Click += label3_Click;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(142, 115);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(175, 35);
            heightTextBox.TabIndex = 1;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(142, 59);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(175, 35);
            weightTextBox.TabIndex = 0;
            // 
            // Dogs
            // 
            Dogs.BorderStyle = BorderStyle.FixedSingle;
            Dogs.FormattingEnabled = true;
            Dogs.ItemHeight = 30;
            Dogs.Items.AddRange(new object[] { "Doggies", "Paper", "Cocker Spaniel" });
            Dogs.Location = new Point(375, 536);
            Dogs.Name = "Dogs";
            Dogs.Size = new Size(210, 92);
            Dogs.TabIndex = 21;
            // 
            // MyFirstProgram
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = exitButton;
            ClientSize = new Size(1273, 773);
            Controls.Add(Dogs);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(lastName);
            Controls.Add(outputBoxTest);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(readInput);
            Controls.Add(nameDisplay);
            Controls.Add(firstName);
            Controls.Add(exitButton);
            Controls.Add(flagLabel);
            Controls.Add(countryQuestion);
            Controls.Add(mexicanFlag);
            Controls.Add(usaFlag);
            Controls.Add(canadaFlag);
            Controls.Add(translationLabel);
            Controls.Add(instructionLabel);
            Controls.Add(italianButton);
            Controls.Add(spanishButton);
            Controls.Add(germanButton);
            Controls.Add(rickRollButton);
            Name = "MyFirstProgram";
            Text = "My First Program";
            Load += MyFirstProgram_Load;
            ((System.ComponentModel.ISupportInitialize)canadaFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)usaFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)mexicanFlag).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NotifyIcon notification;
        private Button rickRollButton;
        private Button germanButton;
        private Button spanishButton;
        private Button italianButton;
        private Label instructionLabel;
        private Label translationLabel;
        private PictureBox canadaFlag;
        private PictureBox usaFlag;
        private PictureBox mexicanFlag;
        private Label countryQuestion;
        private Label flagLabel;
        private Button exitButton;
        private TextBox firstName;
        private Label nameDisplay;
        private Button readInput;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label outputBoxTest;
        private TextBox lastName;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox heightTextBox;
        private TextBox weightTextBox;
        private Label bmiOutputTextBox;
        private Label label4;
        private Button bmiCalculateButton;
        private ListBox Dogs;
    }
}
