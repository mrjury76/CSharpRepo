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
            notification = new NotifyIcon(components);
            rickRollButton = new Button();
            germanButton = new Button();
            spanishButton = new Button();
            italianButton = new Button();
            instructionLabel = new Label();
            translationLabel = new Label();
            SuspendLayout();
            // 
            // notification
            // 
            notification.Text = "You have been hacked :)";
            notification.Visible = true;
            // 
            // rickRollButton
            // 
            rickRollButton.Location = new Point(3, 337);
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
            // MyFirstProgram
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 428);
            Controls.Add(translationLabel);
            Controls.Add(instructionLabel);
            Controls.Add(italianButton);
            Controls.Add(spanishButton);
            Controls.Add(germanButton);
            Controls.Add(rickRollButton);
            Name = "MyFirstProgram";
            Text = "My First Program";
            Load += MyFirstProgram_Load;
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
    }
}
