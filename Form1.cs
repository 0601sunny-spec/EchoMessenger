namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateStatus();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var message = textBox1.Text?.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                EchoMessenger.Items.Add($"[{System.DateTime.Now:HH:mm:ss}] {message}");
                textBox1.Clear();
                textBox1.Focus();
                UpdateStatus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            labelStatus.Text = "현재대화:";
            if (labelCount != null)
            {
                labelCount.Text = $"{EchoMessenger.Items.Count}개";
            }
        }
    }
}