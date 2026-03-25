namespace EchoMessenger
{
    partial class Form1
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
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            EchoMessenger = new ListBox();
            txtPassword = new TextBox();
            btnSaved = new Button();
            labelStatus = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelCount = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 50);
            label1.TabIndex = 0;
            label1.Text = "EchoMeaggenger";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // EchoMessenger
            // 
            EchoMessenger.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            EchoMessenger.ForeColor = SystemColors.ControlText;
            EchoMessenger.FormattingEnabled = true;
            EchoMessenger.Location = new Point(83, 72);
            EchoMessenger.Name = "EchoMessenger";
            EchoMessenger.Size = new Size(622, 279);
            EchoMessenger.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(83, 383);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(484, 23);
            txtPassword.TabIndex = 6;
            // 
            // btnSaved
            // 
            btnSaved.BackColor = Color.FromArgb(128, 255, 128);
            btnSaved.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSaved.Location = new Point(596, 370);
            btnSaved.Name = "btnSaved";
            btnSaved.Size = new Size(109, 46);
            btnSaved.TabIndex = 8;
            btnSaved.Text = "전송";
            btnSaved.UseVisualStyleBackColor = false;
            btnSaved.Click += button1_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            labelStatus.ForeColor = Color.Black;
            labelStatus.Location = new Point(83, 420);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(78, 21);
            labelStatus.TabIndex = 9;
            labelStatus.Text = "현재대화:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            labelCount.ForeColor = Color.Black;
            labelCount.Location = new Point(720, 420);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(35, 21);
            labelCount.TabIndex = 10;
            labelCount.Text = "0개";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(710, 370);
            button2.Name = "button2";
            button2.Size = new Size(75, 46);
            button2.TabIndex = 11;
            button2.Text = "삭제";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonDelete_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.Location = new Point(492, 415);
            button3.Name = "button3";
            button3.Size = new Size(150, 30);
            button3.TabIndex = 12;
            button3.Text = "대화기록삭제";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonClearAll_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSaved;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaved);
            Controls.Add(txtPassword);
            Controls.Add(EchoMessenger);
            Controls.Add(label1);
            Controls.Add(labelStatus);
            Controls.Add(labelCount);
            Controls.Add(button2);
            Controls.Add(button3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ListBox EchoMessenger;
        private TextBox txtPassword;
        private Button btnSaved;
        private Label labelStatus;
        private Label labelCount;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Button button3;
    }
}
