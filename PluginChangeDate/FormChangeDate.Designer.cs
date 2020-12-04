namespace PluginChangeDate
{
    partial class FormChangeDate
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
            this.label4 = new System.Windows.Forms.Label();
            this.controlTextBoxDate = new ClassLibraryVisualComponent.ControlTextBoxInput();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // controlTextBoxDate
            // 
            this.controlTextBoxDate.InputText = null;
            this.controlTextBoxDate.Location = new System.Drawing.Point(65, 11);
            this.controlTextBoxDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlTextBoxDate.Name = "controlTextBoxDate";
            this.controlTextBoxDate.Size = new System.Drawing.Size(283, 72);
            this.controlTextBoxDate.TabIndex = 9;
            this.controlTextBoxDate.typeDate = null;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 99);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormChangeDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 133);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.controlTextBoxDate);
            this.Controls.Add(this.label4);
            this.Name = "FormChangeDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChangeDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private ClassLibraryVisualComponent.ControlTextBoxInput controlTextBoxDate;
        private System.Windows.Forms.Button buttonOk;
    }
}