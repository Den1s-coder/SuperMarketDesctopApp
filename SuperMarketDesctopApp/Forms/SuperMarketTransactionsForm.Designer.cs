namespace SuperMarketDesctopApp.Forms
{
    partial class SuperMarketTransactionsForm
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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(26, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(560, 244);
            listBox1.TabIndex = 0;
            // 
            // SuperMarketTransactionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 300);
            Controls.Add(listBox1);
            Name = "SuperMarketTransactionsForm";
            Text = "SuperMarketTransactionsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}