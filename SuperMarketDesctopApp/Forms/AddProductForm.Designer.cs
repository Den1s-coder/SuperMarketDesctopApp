namespace SuperMarketDesctopApp.Forms
{
    partial class AddProductForm
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
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(75, 200);
            button1.Name = "button1";
            button1.Size = new Size(141, 34);
            button1.TabIndex = 0;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(48, 71);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(196, 27);
            maskedTextBox1.TabIndex = 1;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(48, 125);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(196, 27);
            maskedTextBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 48);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 3;
            label1.Text = "Назва товару";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 102);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "Ціна товару";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 286);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Name = "AddProductForm";
            Text = "Додавання товару";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label1;
        private Label label2;
    }
}