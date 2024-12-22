namespace SuperMarketDesctopApp.Forms
{
    partial class SuperMarketForm
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(41, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(280, 344);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(351, 39);
            button1.Name = "button1";
            button1.Size = new Size(257, 95);
            button1.TabIndex = 1;
            button1.Text = "Перейти до касси";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(351, 164);
            button2.Name = "button2";
            button2.Size = new Size(257, 95);
            button2.TabIndex = 2;
            button2.Text = "Додати кассу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(351, 288);
            button3.Name = "button3";
            button3.Size = new Size(257, 95);
            button3.TabIndex = 3;
            button3.Text = "Видалити кассу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(54, 398);
            button4.Name = "button4";
            button4.Size = new Size(116, 45);
            button4.TabIndex = 4;
            button4.Text = "Зберегти";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(191, 398);
            button5.Name = "button5";
            button5.Size = new Size(116, 45);
            button5.TabIndex = 5;
            button5.Text = "Завантажити";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 6;
            label1.Text = "Готівки в супермаркеті -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 9);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // button6
            // 
            button6.Location = new Point(329, 398);
            button6.Name = "button6";
            button6.Size = new Size(116, 45);
            button6.TabIndex = 8;
            button6.Text = "Logs";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // SuperMarketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 490);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "SuperMarketForm";
            Text = "СуперМаркет";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Button button6;
    }
}