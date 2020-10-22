namespace Library
{
    partial class FormBook
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.controlTextBoxInput1 = new ClassLibraryVisualComponent.ControlTextBoxInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.controlCheckedListBox1 = new VisualComponentLibrary.ControlCheckedListBox();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(45, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(198, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(15, 249);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(106, 249);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // controlTextBoxInput1
            // 
            this.controlTextBoxInput1.InputText = new System.DateTime(((long)(0)));
            this.controlTextBoxInput1.Location = new System.Drawing.Point(27, 45);
            this.controlTextBoxInput1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlTextBoxInput1.Name = "controlTextBoxInput1";
            this.controlTextBoxInput1.Size = new System.Drawing.Size(269, 26);
            this.controlTextBoxInput1.TabIndex = 5;
            this.controlTextBoxInput1.typeDate = "dd MMMM yyyy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            // 
            // controlCheckedListBox1
            // 
            this.controlCheckedListBox1.Location = new System.Drawing.Point(46, 84);
            this.controlCheckedListBox1.Name = "controlCheckedListBox1";
            this.controlCheckedListBox1.SelectedIndex = 0;
            this.controlCheckedListBox1.Size = new System.Drawing.Size(153, 147);
            this.controlCheckedListBox1.TabIndex = 8;
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 282);
            this.Controls.Add(this.controlCheckedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controlTextBoxInput1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "FormBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private ClassLibraryVisualComponent.ControlTextBoxInput controlTextBoxInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private VisualComponentLibrary.ControlCheckedListBox controlCheckedListBox1;
    }
}