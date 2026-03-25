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
            var message = txtPassword.Text?.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                if (message.Length > 50)
                {
                    MessageBox.Show("메시지는 최대 50자까지 입력할 수 있습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
                EchoMessenger.Items.Add($"[{System.DateTime.Now:HH:mm:ss}] {message}");
                txtPassword.Clear();
                txtPassword.Focus();
                UpdateStatus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateStatus();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var idx = EchoMessenger.SelectedIndex;
                if (idx >= 0 && idx < EchoMessenger.Items.Count)
                {
                    EchoMessenger.Items.RemoveAt(idx);
                    UpdateStatus();
                }
                else
                {
                    MessageBox.Show("삭제할 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"삭제 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (EchoMessenger.Items.Count > 0)
                {
                    EchoMessenger.Items.Clear();
                    UpdateStatus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"전체 삭제 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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