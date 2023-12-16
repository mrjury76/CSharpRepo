using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class MyFirstProgram : Form
    {
        string testingOuput = "You have output a string";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dont click that");
        }

        private void flagLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            flagLabel.Text = "Canada";
        }

        private void usaFlag_Click(object sender, EventArgs e)
        {
            flagLabel.Text = "USA";
        }

        private void mexicanFlag_Click(object sender, EventArgs e)
        {
            flagLabel.Text = "Mexico";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readInput_Click(object sender, EventArgs e)
        {
            nameDisplay.Text = firstName.Text + lastName.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nameDisplay.Text = "";
            firstName.Focus();
        }

        private void testOutput_Click(object sender, EventArgs e)
        {
            outputBoxTest.Text = "He" + "ll" + "o";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bmiOutputTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void bmiCalculateButton_Click(object sender, EventArgs e)
        {
            int bmi = int.Parse(weightTextBox.Text) * 703 / int.Parse(heightTextBox.Text);
            string output = bmi.ToString();
            bmiOutputTextBox.Text = output;
        }
    }
}
