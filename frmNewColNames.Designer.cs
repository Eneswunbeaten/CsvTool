namespace CsvTool
{
    partial class frmNewColNames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewColNames));
            TxtNewColNames = new RichTextBox();
            BtnSave = new DevExpress.XtraEditors.SimpleButton();
            LblInformation = new DevExpress.XtraEditors.LabelControl();
            LblColCount = new DevExpress.XtraEditors.LabelControl();
            SuspendLayout();
            // 
            // TxtNewColNames
            // 
            TxtNewColNames.Location = new Point(12, 12);
            TxtNewColNames.Name = "TxtNewColNames";
            TxtNewColNames.Size = new Size(521, 266);
            TxtNewColNames.TabIndex = 0;
            TxtNewColNames.Text = "";
            // 
            // BtnSave
            // 
            BtnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnSave.ImageOptions.SvgImage");
            BtnSave.Location = new Point(150, 303);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(240, 34);
            BtnSave.TabIndex = 1;
            BtnSave.Text = "Save";
            // 
            // LblInformation
            // 
            LblInformation.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            LblInformation.Location = new Point(276, 284);
            LblInformation.Name = "LblInformation";
            LblInformation.Size = new Size(257, 13);
            LblInformation.TabIndex = 2;
            LblInformation.Text = "The column names should be separated by commas.";
            // 
            // LblColCount
            // 
            LblColCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            LblColCount.Location = new Point(12, 284);
            LblColCount.Name = "LblColCount";
            LblColCount.Size = new Size(146, 13);
            LblColCount.TabIndex = 3;
            LblColCount.Text = "Required Column Names : ";
            // 
            // frmNewColNames
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 349);
            Controls.Add(LblColCount);
            Controls.Add(LblInformation);
            Controls.Add(BtnSave);
            Controls.Add(TxtNewColNames);
            IconOptions.Image = (Image)resources.GetObject("frmNewColNames.IconOptions.Image");
            Name = "frmNewColNames";
            Text = "New Column Names";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox TxtNewColNames;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.LabelControl LblInformation;
        private DevExpress.XtraEditors.LabelControl LblColCount;
    }
}