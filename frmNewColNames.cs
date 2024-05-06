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
            Load();
        }
        void Load()
        {
            LblColCount.Text+=_count.ToString();
        }
    }
}