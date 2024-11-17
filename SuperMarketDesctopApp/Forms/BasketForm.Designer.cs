namespace SuperMarketDesctopApp.Forms
{
    partial class BasketForm
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
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(39, 45);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(312, 384);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(455, 217);
            button1.Name = "button1";
            button1.Size = new Size(195, 51);
            button1.TabIndex = 1;
            button1.Text = "Додати в кошик";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(455, 378);
            button2.Name = "button2";
            button2.Size = new Size(195, 51);
            button2.TabIndex = 2;
            button2.Text = "Оплата";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(406, 45);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(294, 124);
            listBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 22);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 4;
            label1.Text = "Доступні товари";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 22);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 5;
            label2.Text = "Товари в кошику";
            // 
            // button3
            // 
            button3.Location = new Point(455, 295);
            button3.Name = "button3";
            button3.Size = new Size(195, 51);
            button3.TabIndex = 6;
            button3.Text = "Видалити з кошика";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BasketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 450);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "BasketForm";
            Text = "Basket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}