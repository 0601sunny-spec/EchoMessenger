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
            textBox1 = new TextBox();
            button1 = new Button();
            labelStatus = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelCount = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(83, 383);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(484, 23);
            textBox1.MaxLength = 50;
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(596, 370);
            button1.Name = "button1";
            button1.Size = new Size(109, 46);
            button1.TabIndex = 8;
            button1.Text = "전송";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonDelete
            // 
            buttonDelete = new Button();
            buttonDelete.BackColor = Color.FromArgb(255, 192, 192);
            buttonDelete.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            buttonDelete.Location = new Point(710, 370);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 46);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "삭제";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClearAll
            // 
            buttonClearAll = new Button();
            buttonClearAll.BackColor = Color.FromArgb(192, 192, 255);
            buttonClearAll.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            buttonClearAll.Location = new Point(492, 415);
            buttonClearAll.Name = "buttonClearAll";
            buttonClearAll.Size = new Size(150, 30);
            buttonClearAll.TabIndex = 12;
            buttonClearAll.Text = "대화기록삭제";
            buttonClearAll.UseVisualStyleBackColor = false;
            buttonClearAll.Click += buttonClearAll_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            labelStatus.ForeColor = Color.Black;
            labelStatus.Location = new Point(83, 420);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(150, 21);
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
            labelCount.Size = new Size(50, 21);
            labelCount.TabIndex = 10;
            labelCount.Text = "0개";
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(EchoMessenger);
            Controls.Add(label1);
            Controls.Add(labelStatus);
            Controls.Add(labelCount);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClearAll);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ListBox EchoMessenger;
        private TextBox textBox1;
        private Button button1;
        private Label labelStatus;
        private Label labelCount;
        private System.Windows.Forms.Timer timer1;
        private Button buttonDelete;
        private Button buttonClearAll;
    }
}
