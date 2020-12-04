namespace Library
{
    partial class FormPlugins
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
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPlugin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(110, 12);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(150, 21);
            this.comboBoxBook.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book";
            // 
            // comboBoxPlugin
            // 
            this.comboBoxPlugin.FormattingEnabled = true;
            this.comboBoxPlugin.Location = new System.Drawing.Point(110, 42);
            this.comboBoxPlugin.Name = "comboBoxPlugin";
            this.comboBoxPlugin.Size = new System.Drawing.Size(150, 21);
            this.comboBoxPlugin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plugin";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(12, 82);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(328, 23);
            this.buttonRun.TabIndex = 8;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // FormPlugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 116);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPlugin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBook);
            this.Name = "FormPlugins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugins";
            this.Load += new System.EventHandler(this.FormPlugins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPlugin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRun;
    }
}