namespace TestingForms
{
    partial class FormTest
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSelectedIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSelectedValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCheckedIndices = new System.Windows.Forms.TextBox();
            this.textBoxCheckedValues = new System.Windows.Forms.TextBox();
            this.controlTreeViewOutput = new VisualComponentLibrary.ControlTreeViewOutput();
            this.controlTextBoxInput = new VisualComponentLibrary.ControlTextBoxInput();
            this.controlCheckedListBox = new VisualComponentLibrary.ControlCheckedListBox();
            this.textBoxSelectedNode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(207, 105);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(275, 20);
            this.textBoxResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Получение значения";
            // 
            // textBoxSelectedIndex
            // 
            this.textBoxSelectedIndex.Location = new System.Drawing.Point(16, 200);
            this.textBoxSelectedIndex.Name = "textBoxSelectedIndex";
            this.textBoxSelectedIndex.Size = new System.Drawing.Size(147, 20);
            this.textBoxSelectedIndex.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выбранный индекс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выбранное значение";
            // 
            // textBoxSelectedValue
            // 
            this.textBoxSelectedValue.Location = new System.Drawing.Point(19, 244);
            this.textBoxSelectedValue.Name = "textBoxSelectedValue";
            this.textBoxSelectedValue.Size = new System.Drawing.Size(144, 20);
            this.textBoxSelectedValue.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отмеченные индексы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Отмеченные значения";
            // 
            // textBoxCheckedIndices
            // 
            this.textBoxCheckedIndices.Location = new System.Drawing.Point(22, 288);
            this.textBoxCheckedIndices.Name = "textBoxCheckedIndices";
            this.textBoxCheckedIndices.Size = new System.Drawing.Size(141, 20);
            this.textBoxCheckedIndices.TabIndex = 10;
            // 
            // textBoxCheckedValues
            // 
            this.textBoxCheckedValues.Location = new System.Drawing.Point(22, 335);
            this.textBoxCheckedValues.Name = "textBoxCheckedValues";
            this.textBoxCheckedValues.Size = new System.Drawing.Size(141, 20);
            this.textBoxCheckedValues.TabIndex = 11;
            // 
            // controlTreeViewOutput
            // 
            this.controlTreeViewOutput.Location = new System.Drawing.Point(504, 12);
            this.controlTreeViewOutput.Name = "controlTreeViewOutput";
            this.controlTreeViewOutput.SelectedIndex = 0;
            this.controlTreeViewOutput.SelectedKey = null;
            this.controlTreeViewOutput.SelectedText = null;
            this.controlTreeViewOutput.Size = new System.Drawing.Size(284, 345);
            this.controlTreeViewOutput.TabIndex = 12;
            this.controlTreeViewOutput.TreeViewNodeMouseClick += new System.EventHandler(this.controlTreeViewOutput_TreeViewNodeMouseClick);
            // 
            // controlTextBoxInput
            // 
            this.controlTextBoxInput.InputText = null;
            this.controlTextBoxInput.Location = new System.Drawing.Point(207, 13);
            this.controlTextBoxInput.Name = "controlTextBoxInput";
            this.controlTextBoxInput.Size = new System.Drawing.Size(275, 54);
            this.controlTextBoxInput.TabIndex = 1;
            this.controlTextBoxInput.TextInputHappened += new System.EventHandler(this.controlTextBoxInput_TextInputHappened);
            // 
            // controlCheckedListBox
            // 
            this.controlCheckedListBox.Location = new System.Drawing.Point(13, 13);
            this.controlCheckedListBox.Name = "controlCheckedListBox";
            this.controlCheckedListBox.SelectedIndex = 0;
            this.controlCheckedListBox.Size = new System.Drawing.Size(150, 147);
            this.controlCheckedListBox.TabIndex = 0;
            this.controlCheckedListBox.CheckedListBoxSelectedElementChanged += new System.EventHandler(this.controlCheckedListBox_CheckedListBoxSelectedElementChanged);
            // 
            // textBoxSelectedNode
            // 
            this.textBoxSelectedNode.Location = new System.Drawing.Point(504, 387);
            this.textBoxSelectedNode.Name = "textBoxSelectedNode";
            this.textBoxSelectedNode.Size = new System.Drawing.Size(284, 20);
            this.textBoxSelectedNode.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Выбранный узел";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSelectedNode);
            this.Controls.Add(this.controlTreeViewOutput);
            this.Controls.Add(this.textBoxCheckedValues);
            this.Controls.Add(this.textBoxCheckedIndices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSelectedValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSelectedIndex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.controlTextBoxInput);
            this.Controls.Add(this.controlCheckedListBox);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VisualComponentLibrary.ControlCheckedListBox controlCheckedListBox;
        private VisualComponentLibrary.ControlTextBoxInput controlTextBoxInput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSelectedIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSelectedValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCheckedIndices;
        private System.Windows.Forms.TextBox textBoxCheckedValues;
        private VisualComponentLibrary.ControlTreeViewOutput controlTreeViewOutput;
        private System.Windows.Forms.TextBox textBoxSelectedNode;
        private System.Windows.Forms.Label label6;
    }
}