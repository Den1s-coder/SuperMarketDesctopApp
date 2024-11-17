namespace SuperMarketDesctopApp
{
    partial class MainForm
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
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(90, 56);
            button1.Name = "button1";
            button1.Size = new Size(146, 43);
            button1.TabIndex = 0;
            button1.Text = "Замовлення";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(351, 56);
            button2.Name = "button2";
            button2.Size = new Size(151, 43);
            button2.TabIndex = 1;
            button2.Text = "Кошти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(90, 129);
            button3.Name = "button3";
            button3.Size = new Size(146, 43);
            button3.TabIndex = 2;
            button3.Text = "Транзакції";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(351, 129);
            button4.Name = "button4";
            button4.Size = new Size(151, 43);
            button4.TabIndex = 3;
            button4.Text = "Додати товар";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(21, 178);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Оплата карткою";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(170, 178);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(163, 24);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "online-замовлення";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(339, 178);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(252, 24);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "online-замовлення з доставкою";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(105, 208);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(420, 24);
            checkBox4.TabIndex = 15;
            checkBox4.Text = "Розрахунок готівкою при online-замовленні та доставці";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 251);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Каса";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}
