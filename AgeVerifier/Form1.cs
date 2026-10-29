namespace AgeVerifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxInputOutput.Text, out int age) || age < 0)
            {
                textBoxInputOutput.Text = "Enter a valid age!";
                return;
            }

            textBoxInputOutput.Text = age >= 16 ? "Of age" : "Not of age";
        }
    }
}
