using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvTool
{
    public partial class frmConfiguration : DevExpress.XtraEditors.XtraForm
    {
        string _csvPath;
        public frmConfiguration(string csvPath)
        {
            _csvPath = csvPath;
            InitializeComponent();
        }
        string filePath;
        string[] headers;
        string[] cols;
        char delimiter;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();
        Dictionary<string, Type> valtypes = new Dictionary<string, Type>();

        void LoadCsvData()
        {
            try
            {
                char.TryParse(txtDelimiter.Text, out delimiter);
                string a = "";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    //Eğer ilk veride column nameleri yoksa ilk veriyi column name olarak atar.
                    headers = sr.ReadLine().Split(txtDelimiter.Text);

                    foreach (string header in headers)
                    {
                        valtypes.Add(header.Trim(), typeof(string));
                    }
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cols = line.Split(txtDelimiter.Text);
                        Dictionary<string, string> rowData = new Dictionary<string, string>();

                        for (int i = 0; i < headers.Length; i++)
                        {
                            if (i < cols.Length)
                            {
                                rowData.Add(headers[i].Trim(), cols[i].Trim());

                                // Veri tipini güncelle
                                Type valueType = DetermineValueType(cols[i].Trim());
                                if (valueType != valtypes[headers[i].Trim()])
                                {
                                    valtypes[headers[i].Trim()] = GetCommonType(valueType, valtypes[headers[i].Trim()]);
                                }
                            }
                            else
                            {
                                rowData.Add(headers[i].Trim(), "");
                            }
                        }

                        dataList.Add(rowData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred. Error Message:" + ex, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            lblrowcount.Text = dataList.Count().ToString();
        }
        private Type GetCommonType(Type type1, Type type2)
        {
            if (type1 == typeof(string) || type2 == typeof(string))
                return typeof(string);

            if (type1 == typeof(double) || type2 == typeof(double))
                return typeof(double);

            if (type1 == typeof(float) || type2 == typeof(float))
                return typeof(float);

            if (type1 == typeof(decimal) || type2 == typeof(decimal))
                return typeof(decimal);

            if (type1 == typeof(long) || type2 == typeof(long))
                return typeof(long);

            return typeof(int);
        }
        private Type DetermineValueType(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return typeof(string);

            if (int.TryParse(value, out _))
                return typeof(int);

            if (long.TryParse(value, out _))
                return typeof(long);

            if (float.TryParse(value, out _))
                return typeof(float);

            if (double.TryParse(value, out _))
                return typeof(double);

            if (decimal.TryParse(value, out _))
                return typeof(decimal);

            if (bool.TryParse(value, out _))
                return typeof(bool);

            if (DateTime.TryParse(value, out _))
                return typeof(DateTime);

            return typeof(string);
        }
        private string GetValidIdentifier(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c) || c == '_')
                {
                    sb.Append(c);
                }
                else if (sb.Length == 0 || !char.IsDigit(c))
                {
                    sb.Append('_');
                }
            }
            if (char.IsDigit(sb[0]))
            {
                sb.Insert(0, '_');
            }
            return sb.ToString();
        }
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            filePath = _csvPath;
            folderBrowserDialog.SelectedPath = Path.GetDirectoryName(filePath);
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtExportPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            LoadCsvData();
            string newModelDataPath = Path.Combine(txtExportPath.Text, $"{txtTableName.Text}NewModel.txt");
            using (StreamWriter writer = new StreamWriter(newModelDataPath))
            {
                foreach (string header in headers)
                {
                    string propertyName = GetValidIdentifier(header);
                    Type columnType = valtypes[header];
                    writer.WriteLine($"public {columnType.Name} {propertyName} {{ get; set; }}");
                }
            }
        }


    }
}