using DevExpress.CodeParser;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraSpreadsheet.Model.History;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvTool.Forms
{
    public partial class frmCustomPrinting : Form
    {
        string[] _headers;
        string _exportPath;
        string _tableName;
        List<Dictionary<string, string>> _dataList;
        List<string?> neededHeaders;
        char delimiter;
        public frmCustomPrinting(string[] headers, string exportPath, string tableName, List<Dictionary<string, string>> dataList)
        {
            _dataList = dataList;
            _headers = headers;
            _exportPath = exportPath;
            _tableName = tableName;
            InitializeComponent();
        }
        public static void StartWork()
        {
            SplashScreenManager.ShowForm(Form.ActiveForm, typeof(frmLoad), true, true, false);
        }
        public static void EndWork()
        {
            SplashScreenManager.CloseForm(false);
        }
        void SetDelimiter()
        {
            foreach (int index in ClBoxDelimiter.CheckedIndices)
            {
                var selecteditem = ClBoxDelimiter.Items[index].ToString();
                if (selecteditem == " ")
                    delimiter = ' ';
                if (selecteditem == ",")
                    delimiter = ',';
                if (selecteditem == ":")
                    delimiter = ':';
                if (selecteditem == ";")
                    delimiter = ';';
                if (selecteditem == "|")
                    delimiter = '|';
            }
            #region Error Handling
            if (ClBoxDelimiter.SelectedItems.Count > 1)
            {
                MessageBox.Show("Maximum 1 delimiter selectable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ClBoxDelimiter.SelectedItems.Count == 0)
            {
                MessageBox.Show("Delimiter selection is mandatory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
        }
        private void frmCustomPrinting_Load(object sender, EventArgs e)
        {
            foreach (string header in _headers)
            {
                CLboxHeaders.Items.Add(header);
            }
        }

        private void BtnSelectAndPrint_Click(object sender, EventArgs e)
        {
            if (CLboxHeaders.CheckedItemsCount < 1)
            {
                MessageBox.Show("Please select at least 1 header", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            neededHeaders = CLboxHeaders.CheckedItems.OfType<object>().Select(item => item.ToString()).ToList();
            foreach (var item in neededHeaders)
            {
                RboxCustom.Text += item + " ";
            }
        }
        private void BtnInsertAll_Click(object sender, EventArgs e)
        {
            foreach (var item in _headers)
            {
                RboxCustom.Text += item + " ";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SetDelimiter();
            string newModelDataPath = Path.Combine(_exportPath, $"{_tableName}_Custom.txt");
            using (StreamWriter writer = new StreamWriter(newModelDataPath))
            {
                writer.Write(RboxCustom.Text);
            }
            MessageBox.Show($"File Saved To \n{_exportPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult dr = MessageBox.Show("Will you continue with the same file?\n(Closes the program when the Cancel button is clicked.)", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (dr)
            {
                case DialogResult.Yes:
                    Refresh();
                    break;
                case DialogResult.No:
                    Application.Restart();
                    Environment.Exit(0);
                    break;
                case DialogResult.Cancel:
                    Environment.Exit(0);
                    break;
            }
        }

        private void LblValuesInsertAll_Click(object sender, EventArgs e)
        {
            StartWork();
            SetDelimiter();
            foreach (var rowData in _dataList)
            {
                foreach (var header in _headers)
                    RboxCustom.Text += rowData[header] + delimiter + " ";
            }
            EndWork();
        }

        private void LblInsertSelectedValue_Click(object sender, EventArgs e)
        {
            StartWork();
            SetDelimiter();
            int i;
            neededHeaders = CLboxHeaders.CheckedItems.OfType<object>().Select(item => item.ToString()).ToList();
            foreach (var rowData in _dataList)
            {
                i = 0;
                foreach (var header in neededHeaders)
                {
                    i++;
                    string value = rowData.ContainsKey(header) ? rowData[header] : "NULL";
                    if (i < rowData.Count)
                        RboxCustom.Text += value + delimiter + " ";
                    else
                        RboxCustom.Text += value+" ";
                }
            }
            EndWork();
        }
    }
}
