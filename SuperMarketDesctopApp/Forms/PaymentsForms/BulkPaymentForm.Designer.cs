namespace SuperMarketDesctopApp.Forms
{
    partial class BulkPaymentForm
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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(109, 104);
            button1.Name = "button1";
            button1.Size = new Size(192, 110);
            button1.TabIndex = 0;
            button1.Text = "Готівка в магазині";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(307, 104);
            button2.Name = "button2";
            button2.Size = new Size(192, 110);
            button2.TabIndex = 1;
            button2.Text = "Картка в магазині";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(505, 104);
            button3.Name = "button3";
            button3.Size = new Size(192, 110);
            button3.TabIndex = 2;
            button3.Text = "Готівка кур'єром";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 81);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 7;
            label1.Text = "Оплата оптом";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(157, 364);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(157, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Картка лояльності";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(357, 364);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(334, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Кур'єрська доставка(для оплати в магазині)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(109, 224);
            button4.Name = "button4";
            button4.Size = new Size(192, 100);
            button4.TabIndex = 12;
            button4.Text = "Готівкою онлайн";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(307, 224);
            button5.Name = "button5";
            button5.Size = new Size(192, 100);
            button5.TabIndex = 13;
            button5.Text = "Карткою онлайн";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(505, 224);
            button6.Name = "button6";
            button6.Size = new Size(192, 100);
            button6.TabIndex = 14;
            button6.Text = "Кур'єром онлайн";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // BulkPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BulkPaymentForm";
            Text = "BulkPaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}