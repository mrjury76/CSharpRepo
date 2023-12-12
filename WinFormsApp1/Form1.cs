using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class MyFirstProgram : Form
    {
        public MyFirstProgram()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
        }


        private void rickRollButton_Click(object sender, EventArgs e)
        {
            string youtubeLink = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";

            openYouTubeLink(youtubeLink);
        }

        private void openYouTubeLink(string link)
        {
            try
            {
                // Use Process.Start to open the default web browser with the YouTube link
                Process.Start(new ProcessStartInfo { FileName = link, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                // Handle exceptions if the browser cannot be opened
                MessageBox.Show("Error opening the link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyFirstProgram_Load(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos Dias";
        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buongiorno";
        }
    }
}
