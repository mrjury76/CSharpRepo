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
            ((System.ComponentModel.ISupportInitialize)canadaFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usaFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mexicanFlag).BeginInit();
            SuspendLayout();
            // 
            // notification
            // 
            notification.Text = "You have been hacked :)";
            notification.Visible = true;
            // 
            // rickRollButton
            // 
            rickRollButton.Location = new Point(12, 347);
            rickRollButton.Name = "rickRollButton";
            rickRollButton.Size = new Size(119, 79);
            rickRollButton.TabIndex = 2;
            rickRollButton.Text = "Rick Roll Button";
            rickRollButton.UseVisualStyleBackColor = true;
            rickRollButton.Click += rickRollButton_Click;
            // 
            // germanButton
            // 
            germanButton.Location = new Point(25, 267);
            germanButton.Name = "germanButton";
            germanButton.Size = new Size(131, 40);
            germanButton.TabIndex = 3;
            germanButton.Text = "German";
            germanButton.UseVisualStyleBackColor = true;
            germanButton.Click += germanButton_Click;
            // 
            // spanishButton
            // 
            spanishButton.Location = new Point(235, 267);
            spanishButton.Name = "spanishButton";
            spanishButton.Size = new Size(131, 40);
            spanishButton.TabIndex = 4;
            spanishButton.Text = "Spanish";
            spanishButton.UseVisualStyleBackColor = true;
            spanishButton.Click += spanishButton_Click;
            // 
            // italianButton
            // 
            italianButton.Location = new Point(422, 267);
            italianButton.Name = "italianButton";
            italianButton.Size = new Size(131, 40);
            italianButton.TabIndex = 5;
            italianButton.Text = "Italian";
            italianButton.UseVisualStyleBackColor = true;
            italianButton.Click += italianButton_Click;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(95, 33);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(448, 30);
            instructionLabel.TabIndex = 6;
            instructionLabel.Text = "Select a language and I will say Good Morning.";
            // 
            // translationLabel
            // 
            translationLabel.BorderStyle = BorderStyle.FixedSingle;
            translationLabel.Location = new Point(107, 143);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(411, 37);
            translationLabel.TabIndex = 7;
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
            usaFlag.Location = new Point(763, 97);
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
            countryQuestion.Location = new Point(816, 41);
            countryQuestion.Name = "countryQuestion";
            countryQuestion.Size = new Size(207, 30);
            countryQuestion.TabIndex = 11;
            countryQuestion.Text = "What country is this?";
            // 
            // flagLabel
            // 
            flagLabel.BorderStyle = BorderStyle.FixedSingle;
            flagLabel.Location = new Point(656, 281);
            flagLabel.Name = "flagLabel";
            flagLabel.Size = new Size(379, 69);
            flagLabel.TabIndex = 12;
            flagLabel.TextAlign = ContentAlignment.MiddleCenter;
            flagLabel.Click += flagLabel_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(375, 360);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(131, 40);
            exitButton.TabIndex = 13;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MyFirstProgram
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 438);
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
    }
}
