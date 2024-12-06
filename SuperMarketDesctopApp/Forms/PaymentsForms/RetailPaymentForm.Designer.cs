namespace SuperMarketDesctopApp.Forms
{
    partial class RetailPaymentForm
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(498, 111);
            button3.Name = "button3";
            button3.Size = new Size(192, 110);
            button3.TabIndex = 5;
            button3.Text = "Готівка кур'єром";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(300, 111);
            button2.Name = "button2";
            button2.Size = new Size(192, 110);
            button2.TabIndex = 4;
            button2.Text = "Картка в магазині";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(102, 111);
            button1.Name = "button1";
            button1.Size = new Size(192, 110);
            button1.TabIndex = 3;
            button1.Text = "Готівка в магазині";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 84);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 6;
            label1.Text = "Оплата роздріб";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(341, 341);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(334, 24);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Кур'єрська доставка(для оплати в магазині)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(141, 341);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(157, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Картка лояльності";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(498, 227);
            button6.Name = "button6";
            button6.Size = new Size(192, 100);
            button6.TabIndex = 17;
            button6.Text = "Кур'єром онлайн";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(300, 227);
            button5.Name = "button5";
            button5.Size = new Size(192, 100);
            button5.TabIndex = 16;
            button5.Text = "Карткою онлайн";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(102, 227);
            button4.Name = "button4";
            button4.Size = new Size(192, 100);
            button4.TabIndex = 15;
            button4.Text = "Готівкою онлайн";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // RetailPaymentForm
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
            Name = "RetailPaymentForm";
            Text = "Формат оплати роздріб";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}