﻿using DevExpress.XtraCharts.Native;

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
            ((System.ComponentModel.ISupportInitialize)txtDelimiter.Properties).BeginInit();
            Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTableName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtExportPath.Properties).BeginInit();
            SuspendLayout();
            // 
            // lblrowcount
            // 
            lblrowcount.AutoSize = true;
            lblrowcount.Location = new Point(12, 310);
            lblrowcount.Name = "lblrowcount";
            lblrowcount.Size = new Size(57, 13);
            lblrowcount.TabIndex = 0;
            lblrowcount.Text = "RowCount";
            // 
            // txtDelimiter
            // 
            txtDelimiter.Location = new Point(123, 3);
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
            Layout.Location = new Point(12, 12);
            Layout.Name = "Layout";
            Layout.RowCount = 4;
            Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Percent, 76F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            Layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Layout.Size = new Size(263, 156);
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
            chlistOutput.Location = new Point(123, 24);
            chlistOutput.Name = "chlistOutput";
            chlistOutput.Size = new Size(137, 52);
            chlistOutput.TabIndex = 4;
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
            btnSelectPath.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSelectPath.ImageOptions.SvgImage");
            btnSelectPath.Location = new Point(123, 125);
            btnSelectPath.Name = "btnSelectPath";
            btnSelectPath.RightToLeft = RightToLeft.Yes;
            btnSelectPath.Size = new Size(137, 28);
            btnSelectPath.TabIndex = 6;
            btnSelectPath.Text = "Select Path";
            btnSelectPath.Click += btnSelectPath_Click;
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(123, 90);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(137, 20);
            txtTableName.TabIndex = 9;
            // 
            // BtnSave
            // 
            BtnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            BtnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnSave.ImageOptions.SvgImage");
            BtnSave.Location = new Point(9, 275);
            BtnSave.Name = "BtnSave";
            BtnSave.RightToLeft = RightToLeft.Yes;
            BtnSave.Size = new Size(266, 32);
            BtnSave.TabIndex = 7;
            BtnSave.Text = "Save";
            BtnSave.Click += BtnSave_Click;
            // 
            // txtExportPath
            // 
            txtExportPath.Enabled = false;
            txtExportPath.Location = new Point(12, 194);
            txtExportPath.Name = "txtExportPath";
            txtExportPath.Size = new Size(260, 20);
            txtExportPath.TabIndex = 10;
            // 
            // labelControl2
            // 
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(15, 168);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(94, 20);
            labelControl2.TabIndex = 11;
            labelControl2.Text = "Path :";
            // 
            // BtnSetColNames
            // 
            BtnSetColNames.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            BtnSetColNames.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnSetColNames.ImageOptions.SvgImage");
            BtnSetColNames.Location = new Point(9, 220);
            BtnSetColNames.Name = "BtnSetColNames";
            BtnSetColNames.RightToLeft = RightToLeft.Yes;
            BtnSetColNames.Size = new Size(266, 32);
            BtnSetColNames.TabIndex = 12;
            BtnSetColNames.Text = "Set new Column names manually";
            BtnSetColNames.Click += BtnSetColNames_Click;
            // 
            // frmConfiguration
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 359);
            Controls.Add(BtnSetColNames);
            Controls.Add(labelControl2);
            Controls.Add(txtExportPath);
            Controls.Add(BtnSave);
            Controls.Add(Layout);
            Controls.Add(lblrowcount);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IconOptions.Image = (Image)resources.GetObject("frmConfiguration.IconOptions.Image");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConfiguration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)txtDelimiter.Properties).EndInit();
            Layout.ResumeLayout(false);
            Layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTableName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtExportPath.Properties).EndInit();
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
    }
}