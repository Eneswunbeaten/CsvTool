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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewColNames));
            TxtNewColNames = new RichTextBox();
            BtnSave = new DevExpress.XtraEditors.SimpleButton();
            LblInformation = new DevExpress.XtraEditors.LabelControl();
            LblColCount = new DevExpress.XtraEditors.LabelControl();
            toolTip1 = new ToolTip(components);
            LblWriteaDelimiter = new DevExpress.XtraEditors.LabelControl();
            txtDelimiter = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)txtDelimiter.Properties).BeginInit();
            SuspendLayout();
            // 
            // TxtNewColNames
            // 
            TxtNewColNames.Location = new Point(12, 12);
            TxtNewColNames.Name = "TxtNewColNames";
            TxtNewColNames.Size = new Size(521, 266);
            TxtNewColNames.TabIndex = 0;
            TxtNewColNames.Text = "";
            toolTip1.SetToolTip(TxtNewColNames, "Enter the new column names separated by commas (in case of missing /_/, you can edit them manually later).");
            // 
            // BtnSave
            // 
            BtnSave.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSave.Appearance.Options.UseFont = true;
            BtnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnSave.ImageOptions.SvgImage");
            BtnSave.Location = new Point(293, 319);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(240, 34);
            BtnSave.TabIndex = 1;
            BtnSave.Text = "Save";
            toolTip1.SetToolTip(BtnSave, "You can save new column names here.");
            BtnSave.Click += BtnSave_Click;
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
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Information";
            // 
            // LblWriteaDelimiter
            // 
            LblWriteaDelimiter.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            LblWriteaDelimiter.Location = new Point(12, 318);
            LblWriteaDelimiter.Name = "LblWriteaDelimiter";
            LblWriteaDelimiter.Size = new Size(88, 35);
            LblWriteaDelimiter.TabIndex = 7;
            LblWriteaDelimiter.Text = "Write a Delimiter :";
            // 
            // txtDelimiter
            // 
            txtDelimiter.Location = new Point(119, 326);
            txtDelimiter.Name = "txtDelimiter";
            txtDelimiter.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            txtDelimiter.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            txtDelimiter.Properties.MaskSettings.Set("mask", ".+");
            txtDelimiter.Size = new Size(77, 20);
            txtDelimiter.TabIndex = 8;
            toolTip1.SetToolTip(txtDelimiter, "Enter the symbol that separates each column in the csv file.");
            // 
            // frmNewColNames
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 367);
            Controls.Add(txtDelimiter);
            Controls.Add(LblWriteaDelimiter);
            Controls.Add(LblColCount);
            Controls.Add(LblInformation);
            Controls.Add(BtnSave);
            Controls.Add(TxtNewColNames);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("frmNewColNames.IconOptions.SvgImage");
            Name = "frmNewColNames";
            Text = "New Column Names";
            ((System.ComponentModel.ISupportInitialize)txtDelimiter.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox TxtNewColNames;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.LabelControl LblInformation;
        private DevExpress.XtraEditors.LabelControl LblColCount;
        private ToolTip toolTip1;
        private DevExpress.XtraEditors.LabelControl LblWriteaDelimiter;
        private DevExpress.XtraEditors.TextEdit txtDelimiter;
    }
}