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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(41, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(280, 364);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(436, 63);
            button1.Name = "button1";
            button1.Size = new Size(257, 95);
            button1.TabIndex = 1;
            button1.Text = "Перейти до касси";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(436, 186);
            button2.Name = "button2";
            button2.Size = new Size(257, 95);
            button2.TabIndex = 2;
            button2.Text = "Додати кассу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(436, 308);
            button3.Name = "button3";
            button3.Size = new Size(257, 95);
            button3.TabIndex = 3;
            button3.Text = "Видалити кассу";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SuperMarketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "SuperMarketForm";
            Text = "SuperMarketForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}