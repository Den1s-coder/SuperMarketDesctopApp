namespace SuperMarketDesctopApp.Forms
{
    partial class CashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 56);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Всього на рахунку:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 56);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "amount";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(144, 133);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(40, 202);
            button1.Name = "button1";
            button1.Size = new Size(134, 59);
            button1.TabIndex = 3;
            button1.Text = "Поповнити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(243, 202);
            button2.Name = "button2";
            button2.Size = new Size(134, 59);
            button2.TabIndex = 4;
            button2.Text = "Зняти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 300);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CashForm";
            Text = "CashForm";
            Load += CashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Button button2;
    }
}