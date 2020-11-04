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
            this.controlTextBoxInput = new ClassLibraryVisualComponent.ControlTextBoxInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.controlCheckedListBox = new VisualComponentLibrary.ControlCheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxFresh = new System.Windows.Forms.ComboBox();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
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
            this.buttonSave.Location = new System.Drawing.Point(14, 319);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(105, 319);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // controlTextBoxInput
            // 
            this.controlTextBoxInput.InputText = new System.DateTime(((long)(0)));
            this.controlTextBoxInput.Location = new System.Drawing.Point(26, 115);
            this.controlTextBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlTextBoxInput.Name = "controlTextBoxInput";
            this.controlTextBoxInput.Size = new System.Drawing.Size(269, 26);
            this.controlTextBoxInput.TabIndex = 5;
            this.controlTextBoxInput.typeDate = "dd MMMM yyyy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            // 
            // controlCheckedListBox
            // 
            this.controlCheckedListBox.Location = new System.Drawing.Point(45, 154);
            this.controlCheckedListBox.Name = "controlCheckedListBox";
            this.controlCheckedListBox.SelectedIndex = 0;
            this.controlCheckedListBox.Size = new System.Drawing.Size(153, 147);
            this.controlCheckedListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Freshness";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Form";
            // 
            // comboBoxFresh
            // 
            this.comboBoxFresh.FormattingEnabled = true;
            this.comboBoxFresh.Location = new System.Drawing.Point(71, 47);
            this.comboBoxFresh.Name = "comboBoxFresh";
            this.comboBoxFresh.Size = new System.Drawing.Size(187, 21);
            this.comboBoxFresh.TabIndex = 11;
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.Location = new System.Drawing.Point(48, 77);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(210, 21);
            this.comboBoxForm.TabIndex = 12;
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 368);
            this.Controls.Add(this.comboBoxForm);
            this.Controls.Add(this.comboBoxFresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.controlCheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controlTextBoxInput);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "FormBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.FormBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private ClassLibraryVisualComponent.ControlTextBoxInput controlTextBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private VisualComponentLibrary.ControlCheckedListBox controlCheckedListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxFresh;
        private System.Windows.Forms.ComboBox comboBoxForm;
    }
}