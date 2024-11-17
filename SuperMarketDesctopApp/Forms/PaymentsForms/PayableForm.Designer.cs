namespace SuperMarketDesctopApp.Forms.PaymentsForms
{
    partial class PayableForm
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
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 93);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "До сплати";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 93);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(123, 144);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(135, 27);
            maskedTextBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(144, 237);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Оплатити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 121);
            label3.Name = "label3";
            label3.Size = new Size(186, 20);
            label3.TabIndex = 4;
            label3.Text = "Готівка надано покупцем";
            // 
            // PayableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 409);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PayableForm";
            Text = "PayableForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Label label3;
    }
}