using DevExpress.XtraCharts.Native;

namespace CsvTool
{
    partial class frmConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguration));
            lblrowcount = new Label();
            txtDelimiter = new DevExpress.XtraEditors.TextEdit();
            lbldelimiter = new DevExpress.XtraEditors.LabelControl();
            Layout = new TableLayoutPanel();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            lbloutput = new DevExpress.XtraEditors.LabelControl();
            chlistOutput = new CheckedListBox();
            lblExportPath = new DevExpress.XtraEditors.LabelControl();
            btnSelectPath = new DevExpress.XtraEditors.SimpleButton();
            txtTableName = new DevExpress.XtraEditors.TextEdit();
            BtnSave = new DevExpress.XtraEditors.SimpleButton();
            txtExportPath = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            BtnSetColNames = new DevExpress.XtraEditors.SimpleButton();
            ChboxColsAvailable = new DevExpress.XtraEditors.CheckEdit();
            btnBack = new DevExpress.XtraEditors.SimpleButton();
            ChboxAddId = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)txtDelimiter.Properties).BeginInit();
            Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTableName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtExportPath.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChboxColsAvailable.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChboxAddId.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblrowcount
            // 
            lblrowcount.AutoSize = true;
            lblrowcount.Location = new Point(12, 345);
            lblrowcount.Name = "lblrowcount";
            lblrowcount.Size = new Size(0, 13);
            lblrowcount.TabIndex = 0;
            // 
            // txtDelimiter
            // 
            txtDelimiter.Location = new Point(140, 3);
            txtDelimiter.Name = "txtDelimiter";
            txtDelimiter.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            txtDelimiter.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            txtDelimiter.Properties.MaskSettings.Set("mask", ".+");
            txtDelimiter.Size = new Size(137, 20);
            txtDelimiter.TabIndex = 1;
            // 
            // lbldelimiter
            // 
            lbldelimiter.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lbldelimiter.Location = new Point(3, 3);
            lbldelimiter.Name = "lbldelimiter";
            lbldelimiter.Size = new Size(94, 13);
            lbldelimiter.TabIndex = 2;
            lbldelimiter.Text = "Select a Delimiter :";
            // 
            // Layout
            // 
            Layout.AutoScroll = true;
            Layout.ColumnCount = 2;
            Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.6692924F));
            Layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.3307076F));
            Layout.Controls.Add(labelControl1, 0, 2);
            Layout.Controls.Add(lbloutput, 0, 1);
            Layout.Controls.Add(lbldelimiter, 0, 0);
            Layout.Controls.Add(txtDelimiter, 1, 0);
            Layout.Controls.Add(chlistOutput, 1, 1);
            Layout.Controls.Add(lblExportPath, 0, 3);
            Layout.Controls.Add(btnSelectPath, 1, 3);
            Layout.Controls.Add(txtTableName, 1, 2);
            Layout.Location = new Point(12, 19);
            Layout.Name = "Layout";
            Layout.RowCount = 4;
            Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 76F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Layout.Size = new Size(302, 156);
            Layout.TabIndex = 3;
            // 
            // labelControl1
            // 
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(3, 90);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(94, 29);
            labelControl1.TabIndex = 8;
            labelControl1.Text = "Table Name :";
            // 
            // lbloutput
            // 
            lbloutput.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lbloutput.Location = new Point(3, 24);
            lbloutput.Name = "lbloutput";
            lbloutput.Size = new Size(94, 57);
            lbloutput.TabIndex = 3;
            lbloutput.Text = "What should the\r\noutput be like? :";
            // 
            // chlistOutput
            // 
            chlistOutput.FormattingEnabled = true;
            chlistOutput.Items.AddRange(new object[] { "Mongo", "Sql", "Model" });
            chlistOutput.Location = new Point(140, 24);
            chlistOutput.Name = "chlistOutput";
            chlistOutput.Size = new Size(137, 52);
            chlistOutput.TabIndex = 2;
            chlistOutput.ItemCheck += chlistOutput_ItemCheck;
            // 
            // lblExportPath
            // 
            lblExportPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblExportPath.Location = new Point(3, 125);
            lblExportPath.Name = "lblExportPath";
            lblExportPath.Size = new Size(94, 28);
            lblExportPath.TabIndex = 5;
            lblExportPath.Text = "Export Path :";
            // 
            // btnSelectPath
            // 
            btnSelectPath.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnSelectPath.Appearance.Options.UseFont = true;
            btnSelectPath.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSelectPath.ImageOptions.SvgImage");
            btnSelectPath.Location = new Point(140, 125);
            btnSelectPath.Name = "btnSelectPath";
            btnSelectPath.RightToLeft = RightToLeft.Yes;
            btnSelectPath.Size = new Size(137, 28);
            btnSelectPath.TabIndex = 4;
            btnSelectPath.Text = "Select Path";
            btnSelectPath.Click += btnSelectPath_Click;
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(140, 90);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(137, 20);
            txtTableName.TabIndex = 3;
            // 
            // BtnSave
            // 
            BtnSave.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            BtnSave.Appearance.Options.UseFont = true;
            BtnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            BtnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnSave.ImageOptions.SvgImage");
            BtnSave.Location = new Point(9, 313);
            BtnSave.Name = "BtnSave";
            BtnSave.RightToLeft = RightToLeft.Yes;
            BtnSave.Size = new Size(305, 32);
            BtnSave.TabIndex = 6;
            BtnSave.Text = "Save";
            BtnSave.Click += BtnSave_Click;
            // 
            // txtExportPath
            // 
            txtExportPath.Enabled = false;
            txtExportPath.Location = new Point(12, 201);
            txtExportPath.Name = "txtExportPath";
            txtExportPath.Size = new Size(302, 20);
            txtExportPath.TabIndex = 10;
            // 
            // labelControl2
            // 
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(15, 175);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(94, 20);
            labelControl2.TabIndex = 11;
            labelControl2.Text = "Path :";
            // 
            // BtnSetColNames
            // 
            BtnSetColNames.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            BtnSetColNames.Appearance.Options.UseFont = true;
            BtnSetColNames.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            BtnSetColNames.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnSetColNames.ImageOptions.SvgImage");
            BtnSetColNames.Location = new Point(9, 273);
            BtnSetColNames.Name = "BtnSetColNames";
            BtnSetColNames.RightToLeft = RightToLeft.Yes;
            BtnSetColNames.Size = new Size(305, 32);
            BtnSetColNames.TabIndex = 7;
            BtnSetColNames.Text = "Set new Column names manually";
            BtnSetColNames.Click += BtnSetColNames_Click;
            // 
            // ChboxColsAvailable
            // 
            ChboxColsAvailable.EditValue = true;
            ChboxColsAvailable.Location = new Point(9, 227);
            ChboxColsAvailable.Name = "ChboxColsAvailable";
            ChboxColsAvailable.Properties.Caption = "Are the column names available in the first row of the csv?";
            ChboxColsAvailable.Size = new Size(305, 20);
            ChboxColsAvailable.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            btnBack.Appearance.Options.UseFont = true;
            btnBack.ImageOptions.Image = (Image)resources.GetObject("btnBack.ImageOptions.Image");
            btnBack.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            btnBack.Location = new Point(214, 357);
            btnBack.Name = "btnBack";
            btnBack.RightToLeft = RightToLeft.Yes;
            btnBack.Size = new Size(100, 32);
            btnBack.TabIndex = 8;
            btnBack.Text = "Restart";
            btnBack.Click += btnBack_Click;
            // 
            // ChboxAddId
            // 
            ChboxAddId.Enabled = false;
            ChboxAddId.Location = new Point(9, 249);
            ChboxAddId.Name = "ChboxAddId";
            ChboxAddId.Properties.Caption = "Add Id? (Mongo Only)";
            ChboxAddId.Size = new Size(132, 20);
            ChboxAddId.TabIndex = 12;
            // 
            // frmConfiguration
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 396);
            Controls.Add(ChboxAddId);
            Controls.Add(btnBack);
            Controls.Add(ChboxColsAvailable);
            Controls.Add(BtnSetColNames);
            Controls.Add(labelControl2);
            Controls.Add(txtExportPath);
            Controls.Add(BtnSave);
            Controls.Add(Layout);
            Controls.Add(lblrowcount);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("frmConfiguration.IconOptions.SvgImage");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConfiguration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuration";
            FormClosed += frmConfiguration_FormClosed;
            ((System.ComponentModel.ISupportInitialize)txtDelimiter.Properties).EndInit();
            Layout.ResumeLayout(false);
            Layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTableName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtExportPath.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChboxColsAvailable.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChboxAddId.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblrowcount;
        private DevExpress.XtraEditors.TextEdit txtDelimiter;
        private DevExpress.XtraEditors.LabelControl lbldelimiter;
        private TableLayoutPanel Layout;
        private DevExpress.XtraEditors.LabelControl lbloutput;
        private CheckedListBox chlistOutput;
        private DevExpress.XtraEditors.LabelControl lblExportPath;
        private DevExpress.XtraEditors.SimpleButton btnSelectPath;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTableName;
        private DevExpress.XtraEditors.TextEdit txtExportPath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnSetColNames;
        private DevExpress.XtraEditors.CheckEdit ChboxColsAvailable;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.CheckEdit ChboxAddId;
    }
}