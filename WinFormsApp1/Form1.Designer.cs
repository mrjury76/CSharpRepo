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
            testButton = new Button();
            rickRollButton = new Button();
            outputLabel = new Label();
            SuspendLayout();
            // 
            // notification
            // 
            notification.Text = "You have been hacked :)";
            notification.Visible = true;
            // 
            // testButton
            // 
            testButton.BackgroundImageLayout = ImageLayout.Center;
            testButton.Location = new Point(177, 196);
            testButton.Name = "testButton";
            testButton.Size = new Size(233, 66);
            testButton.TabIndex = 0;
            testButton.Text = "Hello world";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // rickRollButton
            // 
            rickRollButton.Location = new Point(12, 12);
            rickRollButton.Name = "rickRollButton";
            rickRollButton.Size = new Size(119, 79);
            rickRollButton.TabIndex = 2;
            rickRollButton.Text = "Rick Roll Button";
            rickRollButton.UseVisualStyleBackColor = true;
            rickRollButton.Click += rickRollButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Font = new Font("Showcard Gothic", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outputLabel.Location = new Point(122, 81);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(0, 42);
            outputLabel.TabIndex = 3;
            outputLabel.Click += outputLabel_Click;
            // 
            // MyFirstProgram
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 428);
            Controls.Add(outputLabel);
            Controls.Add(rickRollButton);
            Controls.Add(testButton);
            Name = "MyFirstProgram";
            Text = "My First Program";
            Load += MyFirstProgram_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NotifyIcon notification;
        private Button testButton;
        private Button rickRollButton;
        private Label outputLabel;
    }
}
