namespace TestingForms
{
    partial class FormNonVisual
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
            this.components = new System.ComponentModel.Container();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonHistogram = new System.Windows.Forms.Button();
            this.controlTreeViewOutput = new VisualComponentLibrary.ControlTreeViewOutput();
            this.componentBinaryRestore = new NonVisualComponentLibrary.ComponentBinaryRestore(this.components);
            this.componentWordHistogram = new NonVisualComponentLibrary.ComponentWordHistogram(this.components);
            this.componentPdfReport = new NonVisualComponentLibrary.ComponentPdfReport(this.components);
            this.buttonMakePdf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(13, 364);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(283, 25);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonHistogram
            // 
            this.buttonHistogram.Location = new System.Drawing.Point(321, 13);
            this.buttonHistogram.Name = "buttonHistogram";
            this.buttonHistogram.Size = new System.Drawing.Size(75, 46);
            this.buttonHistogram.TabIndex = 2;
            this.buttonHistogram.Text = "Создать диаграмму";
            this.buttonHistogram.UseVisualStyleBackColor = true;
            this.buttonHistogram.Click += new System.EventHandler(this.buttonHistogram_Click);
            // 
            // controlTreeViewOutput
            // 
            this.controlTreeViewOutput.Location = new System.Drawing.Point(12, 12);
            this.controlTreeViewOutput.Name = "controlTreeViewOutput";
            this.controlTreeViewOutput.SelectedIndex = 0;
            this.controlTreeViewOutput.SelectedKey = null;
            this.controlTreeViewOutput.SelectedText = null;
            this.controlTreeViewOutput.Size = new System.Drawing.Size(284, 345);
            this.controlTreeViewOutput.TabIndex = 0;
            // 
            // buttonMakePdf
            // 
            this.buttonMakePdf.Location = new System.Drawing.Point(424, 13);
            this.buttonMakePdf.Name = "buttonMakePdf";
            this.buttonMakePdf.Size = new System.Drawing.Size(75, 46);
            this.buttonMakePdf.TabIndex = 3;
            this.buttonMakePdf.Text = "Создать Pdf";
            this.buttonMakePdf.UseVisualStyleBackColor = true;
            this.buttonMakePdf.Click += new System.EventHandler(this.buttonMakePdf_Click);
            // 
            // FormNonVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMakePdf);
            this.Controls.Add(this.buttonHistogram);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.controlTreeViewOutput);
            this.Name = "FormNonVisual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNonVisual";
            this.ResumeLayout(false);

        }

        #endregion

        private NonVisualComponentLibrary.ComponentBinaryRestore componentBinaryRestore;
        private VisualComponentLibrary.ControlTreeViewOutput controlTreeViewOutput;
        private System.Windows.Forms.Button buttonLoad;
        private NonVisualComponentLibrary.ComponentWordHistogram componentWordHistogram;
        private System.Windows.Forms.Button buttonHistogram;
        private NonVisualComponentLibrary.ComponentPdfReport componentPdfReport;
        private System.Windows.Forms.Button buttonMakePdf;
    }
}