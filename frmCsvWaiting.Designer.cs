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
            LblDragCsv.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            LblDragCsv.Location = new Point(159, 130);
            LblDragCsv.Name = "LblDragCsv";
            LblDragCsv.Size = new Size(189, 13);
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
            IconOptions.Image = (Image)resources.GetObject("frmCsvWaiting.IconOptions.Image");
            MaximizeBox = false;
            Name = "frmCsvWaiting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Csv Waiting...";
            DragDrop += frmCsvWaiting_DragDrop;
            DragEnter += frmCsvWaiting_DragEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblDragCsv;
    }
}