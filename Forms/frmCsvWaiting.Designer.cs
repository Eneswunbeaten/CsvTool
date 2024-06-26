namespace CsvTool
{
    partial class frmCsvWaiting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCsvWaiting));
            LblDragCsv = new DevExpress.XtraEditors.LabelControl();
            SuspendLayout();
            // 
            // LblDragCsv
            // 
            LblDragCsv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LblDragCsv.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblDragCsv.Appearance.Options.UseFont = true;
            LblDragCsv.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            LblDragCsv.Location = new Point(128, 127);
            LblDragCsv.Name = "LblDragCsv";
            LblDragCsv.Size = new Size(255, 16);
            LblDragCsv.TabIndex = 0;
            LblDragCsv.Text = "Please drag the .csv file to the screen. ";
            // 
            // frmCsvWaiting
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 307);
            Controls.Add(LblDragCsv);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("frmCsvWaiting.IconOptions.SvgImage");
            MaximizeBox = false;
            Name = "frmCsvWaiting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Csv Waiting...";
            Load += frmCsvWaiting_Load;
            DragDrop += frmCsvWaiting_DragDrop;
            DragEnter += frmCsvWaiting_DragEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblDragCsv;
    }
}