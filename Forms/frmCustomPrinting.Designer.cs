namespace CsvTool.Forms
{
    partial class frmCustomPrinting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomPrinting));
            BtnSave = new DevExpress.XtraEditors.SimpleButton();
            CLboxHeaders = new DevExpress.XtraEditors.CheckedListBoxControl();
            BtnSelectAndPrint = new DevExpress.XtraEditors.SimpleButton();
            BtnInsertAll = new DevExpress.XtraEditors.SimpleButton();
            RboxCustom = new RichTextBox();
            LblHeader = new DevExpress.XtraEditors.LabelControl();
            LblValues = new DevExpress.XtraEditors.LabelControl();
            LblInsertSelectedValue = new DevExpress.XtraEditors.SimpleButton();
            LblValuesInsertAll = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ClBoxDelimiter = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)CLboxHeaders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClBoxDelimiter).BeginInit();
            SuspendLayout();
            // 
            // BtnSave
            // 
            BtnSave.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSave.Appearance.Options.UseFont = true;
            BtnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnSave.ImageOptions.SvgImage");
            BtnSave.Location = new Point(772, 130);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(389, 34);
            BtnSave.TabIndex = 22;
            BtnSave.Text = "Save";
            BtnSave.Click += BtnSave_Click;
            // 
            // CLboxHeaders
            // 
            CLboxHeaders.Location = new Point(772, 170);
            CLboxHeaders.Name = "CLboxHeaders";
            CLboxHeaders.Size = new Size(389, 425);
            CLboxHeaders.TabIndex = 21;
            // 
            // BtnSelectAndPrint
            // 
            BtnSelectAndPrint.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnSelectAndPrint.Appearance.Options.UseFont = true;
            BtnSelectAndPrint.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnSelectAndPrint.ImageOptions.SvgImage");
            BtnSelectAndPrint.Location = new Point(772, 88);
            BtnSelectAndPrint.Name = "BtnSelectAndPrint";
            BtnSelectAndPrint.Size = new Size(188, 34);
            BtnSelectAndPrint.TabIndex = 20;
            BtnSelectAndPrint.Text = "Select And Print";
            BtnSelectAndPrint.Click += BtnSelectAndPrint_Click;
            // 
            // BtnInsertAll
            // 
            BtnInsertAll.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnInsertAll.Appearance.Options.UseFont = true;
            BtnInsertAll.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("BtnInsertAll.ImageOptions.SvgImage");
            BtnInsertAll.Location = new Point(772, 48);
            BtnInsertAll.Name = "BtnInsertAll";
            BtnInsertAll.Size = new Size(188, 34);
            BtnInsertAll.TabIndex = 19;
            BtnInsertAll.Text = "Insert All";
            BtnInsertAll.Click += BtnInsertAll_Click;
            // 
            // RboxCustom
            // 
            RboxCustom.Location = new Point(2, 12);
            RboxCustom.Name = "RboxCustom";
            RboxCustom.Size = new Size(764, 583);
            RboxCustom.TabIndex = 0;
            RboxCustom.Text = "";
            // 
            // LblHeader
            // 
            LblHeader.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblHeader.Appearance.Options.UseFont = true;
            LblHeader.Appearance.Options.UseTextOptions = true;
            LblHeader.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LblHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            LblHeader.Location = new Point(772, 12);
            LblHeader.Name = "LblHeader";
            LblHeader.Size = new Size(188, 30);
            LblHeader.TabIndex = 25;
            LblHeader.Text = "Headers";
            // 
            // LblValues
            // 
            LblValues.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblValues.Appearance.Options.UseFont = true;
            LblValues.Appearance.Options.UseTextOptions = true;
            LblValues.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LblValues.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            LblValues.Location = new Point(973, 12);
            LblValues.Name = "LblValues";
            LblValues.Size = new Size(188, 30);
            LblValues.TabIndex = 30;
            LblValues.Text = "Values";
            // 
            // LblInsertSelectedValue
            // 
            LblInsertSelectedValue.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblInsertSelectedValue.Appearance.Options.UseFont = true;
            LblInsertSelectedValue.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("LblInsertSelectedValue.ImageOptions.SvgImage");
            LblInsertSelectedValue.Location = new Point(973, 88);
            LblInsertSelectedValue.Name = "LblInsertSelectedValue";
            LblInsertSelectedValue.Size = new Size(188, 34);
            LblInsertSelectedValue.TabIndex = 27;
            LblInsertSelectedValue.Text = "Select And Print";
            LblInsertSelectedValue.Click += LblInsertSelectedValue_Click;
            // 
            // LblValuesInsertAll
            // 
            LblValuesInsertAll.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblValuesInsertAll.Appearance.Options.UseFont = true;
            LblValuesInsertAll.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("LblValuesInsertAll.ImageOptions.SvgImage");
            LblValuesInsertAll.Location = new Point(973, 48);
            LblValuesInsertAll.Name = "LblValuesInsertAll";
            LblValuesInsertAll.Size = new Size(188, 34);
            LblValuesInsertAll.TabIndex = 26;
            LblValuesInsertAll.Text = "Insert All";
            LblValuesInsertAll.Click += LblValuesInsertAll_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(1167, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(131, 30);
            labelControl1.TabIndex = 31;
            labelControl1.Text = "Delimiter";
            // 
            // ClBoxDelimiter
            // 
            ClBoxDelimiter.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] { new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Space"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(","), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(";"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem(":"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("|") });
            ClBoxDelimiter.Location = new Point(1167, 48);
            ClBoxDelimiter.Name = "ClBoxDelimiter";
            ClBoxDelimiter.Size = new Size(131, 116);
            ClBoxDelimiter.TabIndex = 32;
            // 
            // frmCustomPrinting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 607);
            Controls.Add(ClBoxDelimiter);
            Controls.Add(labelControl1);
            Controls.Add(LblValues);
            Controls.Add(LblInsertSelectedValue);
            Controls.Add(LblValuesInsertAll);
            Controls.Add(LblHeader);
            Controls.Add(RboxCustom);
            Controls.Add(BtnSave);
            Controls.Add(CLboxHeaders);
            Controls.Add(BtnSelectAndPrint);
            Controls.Add(BtnInsertAll);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmCustomPrinting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Custom Printing";
            Load += frmCustomPrinting_Load;
            ((System.ComponentModel.ISupportInitialize)CLboxHeaders).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClBoxDelimiter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.CheckedListBoxControl CLboxHeaders;
        private DevExpress.XtraEditors.SimpleButton BtnSelectAndPrint;
        private DevExpress.XtraEditors.SimpleButton BtnInsertAll;
        private RichTextBox RboxCustom;
        private DevExpress.XtraEditors.LabelControl LblHeader;
        private DevExpress.XtraEditors.LabelControl LblValues;
        private DevExpress.XtraEditors.SimpleButton LblInsertSelectedValue;
        private DevExpress.XtraEditors.SimpleButton LblValuesInsertAll;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl ClBoxDelimiter;
    }
}