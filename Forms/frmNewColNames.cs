﻿using DevExpress.XtraEditors;
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
        string[] _headers;
        public frmNewColNames(int count,string[] headers)
        {
            _count = count;
            _headers = headers;
            InitializeComponent();
            LblColCount.Text += _count.ToString();
        }
        char delimiter;
        public string[] NewCols;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (char.TryParse(txtDelimiter.Text, out delimiter))
            {
                NewCols = TxtNewColNames.Text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                NewCols = NewCols.Take(_count).ToArray();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                if (string.IsNullOrEmpty(txtDelimiter.Text))
                {
                    MessageBox.Show("The delimiter cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
                else if (txtDelimiter.Text.Length > 1)
                {
                    MessageBox.Show("Delimiter must be maximum 1 character", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (NewCols.Length > _count)
            {
                MessageBox.Show("You have entered more column names than the number of columns in the CSV file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void frmNewColNames_Load(object sender, EventArgs e)
        {
            DgwHeaders.Columns.Add("Headers", "Headers");
            foreach (var item in _headers)
            {
                DgwHeaders.Rows.Add(item);
            }
        }

        private void DgwHeaders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && DgwHeaders.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DgwHeaders.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        DgwHeaders.Rows.Remove(row);
                    }
                }
            }
        }

        private void DgwHeaders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DgwHeaders.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}