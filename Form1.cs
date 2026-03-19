namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                EchoMessenger.Items.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}