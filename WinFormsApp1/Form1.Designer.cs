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
            SuspendLayout();
            // 
            // notification
            // 
            notification.Text = "You have been hacked :)";
            notification.Visible = true;
            // 
            // testButton
            // 
            testButton.Location = new Point(122, 219);
            testButton.Name = "testButton";
            testButton.Size = new Size(346, 93);
            testButton.TabIndex = 0;
            testButton.Text = "Click this for Hello World";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // rickRollButton
            // 
            rickRollButton.Location = new Point(157, 342);
            rickRollButton.Name = "rickRollButton";
            rickRollButton.Size = new Size(281, 40);
            rickRollButton.TabIndex = 2;
            rickRollButton.Text = "Calculate Net Worth";
            rickRollButton.UseVisualStyleBackColor = true;
            rickRollButton.Click += rickRollButton_Click;
            // 
            // MyFirstProgram
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 428);
            Controls.Add(rickRollButton);
            Controls.Add(testButton);
            Name = "MyFirstProgram";
            Text = "My First Program";
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notification;
        private Button testButton;
        private Button rickRollButton;
    }
}
