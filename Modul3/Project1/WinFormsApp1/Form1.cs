namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            string Input = textBox1.Text;

            
            string message = "Halo " + Input;

           
            MessageBox.Show(message, "User Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
