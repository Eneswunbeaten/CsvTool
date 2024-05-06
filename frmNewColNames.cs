using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvTool
{
    public partial class frmNewColNames : DevExpress.XtraEditors.XtraForm
    {
        int _count;
        public frmNewColNames(int count)
        {
            _count = count;
            InitializeComponent();
            LblColCount.Text += _count.ToString();
        }
        public string[] NewCols;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            NewCols = TxtNewColNames.Text.Split(',');
            if (NewCols.Length > _count)
            {
                MessageBox.Show("You have entered more column names than the number of columns in the CSV file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NewCols = NewCols.Take(_count).ToArray();
            Close();
        }
    }
}