using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
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
        private static string[] headers;
        string[] cols;
        char delimiter;
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        List<Dictionary<string, string>> dataList = new List<Dictionary<string, string>>();
        Dictionary<string, Type> valtypes = new Dictionary<string, Type>();

        void LoadCsvData()
        {
            try
            {
                char.TryParse(txtDelimiter.Text, out delimiter);
                using (StreamReader sr = new StreamReader(filePath))
                {
                    if (ChboxColsAvailable.Checked)
                    {
                        headers = sr.ReadLine().Split(delimiter);
                    }
                    //else
                    //{
                    //    headers = frm.NewCols;
                    //}
                    foreach (string header in headers)
                    {
                        valtypes.Add(header.Trim(), typeof(string));
                    }
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cols = line.Split(delimiter);
                        Dictionary<string, string> rowData = new Dictionary<string, string>();

                        for (int i = 0; i < headers.Length; i++)
                        {
                            if (i < cols.Length)
                            {
                                rowData.Add(headers[i].Trim(), cols[i].Trim());

                                // Veri tipini günceller
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
        void LoadForNewCols()
        {
            try
            {
                char.TryParse(txtDelimiter.Text, out delimiter);
                using (StreamReader sr = new StreamReader(filePath))
                {
                    headers = sr.ReadLine().Split(delimiter);

                    foreach (string header in headers)
                    {
                        valtypes.Add(header.Trim(), typeof(string));
                    }
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cols = line.Split(delimiter);
                        Dictionary<string, string> rowData = new Dictionary<string, string>();

                        for (int i = 0; i < headers.Length; i++)
                        {
                            if (i < cols.Length)
                            {
                                rowData.Add(headers[i].Trim(), cols[i].Trim());

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

        public static void StartWork()
        {
            SplashScreenManager.ShowForm(Form.ActiveForm, typeof(frmLoad), true, true, false);
        }
        public static void EndWork()
        {
            SplashScreenManager.CloseForm(false);
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
        void ModelSelected()
        {
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
        void SqlSelected()
        {
            string newModelDataPath = Path.Combine(txtExportPath.Text, $"{txtTableName.Text}NewSql.txt");
            using (StreamWriter writer = new StreamWriter(newModelDataPath))
            {
                writer.WriteLine($"INSERT INTO {txtTableName.Text} (");
                int i = 0;
                foreach (var header in headers)
                {
                    i++;
                    writer.Write(header.Trim() + ((i < headers.Length) ? ", " : ")"));
                }

                writer.WriteLine(" VALUES");

                bool isFirstRow = true;
                foreach (var rowData in dataList)
                {
                    if (isFirstRow)
                    {
                        writer.Write("(");
                        isFirstRow = false;
                    }
                    else
                    {
                        writer.Write(",\n(");
                    }

                    i = 0;
                    foreach (var header in headers)
                    {
                        i++;
                        string value = rowData.ContainsKey(header) ? rowData[header] : "NULL";
                        writer.Write($"'{value.Replace("'", "''")}'");
                        if (i < headers.Length)
                        {
                            writer.Write(", ");
                        }
                    }
                    writer.Write(")");
                }

                writer.WriteLine(";");
            }
        }
        void MongoSelected()
        {
            string newModelDataPath = Path.Combine(txtExportPath.Text, $"{txtTableName.Text}NewMongo.txt");
            using (StreamWriter writer = new StreamWriter(newModelDataPath))
            {
                writer.WriteLine($"db.getCollection(\"{txtTableName.Text}\").insert([");

                bool isFirstRow = true;
                foreach (var rowData in dataList)
                {
                    if (isFirstRow)
                    {
                        writer.Write("{ ");
                        isFirstRow = false;
                    }
                    else
                    {
                        writer.Write(", { ");
                    }

                    int i = 0;
                    foreach (var header in headers)
                    {
                        i++;
                        string value = rowData.ContainsKey(header) ? rowData[header] : "null";
                        writer.Write($"\"{header.Trim()}\": \"{value.Replace("\"", "\"\"")}\"");
                        if (i < headers.Length)
                        {
                            writer.Write(", ");
                        }
                    }
                    writer.Write(" }");
                }

                writer.WriteLine("]);");
            }
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

        List<int> selectedIndices = new List<int>();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDelimiter.Text))
            {
                MessageBox.Show("Delimiter Cannot Be Empty","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDelimiter.Text.Length >= 2)
            {
                MessageBox.Show("The Delimiter Can Consist Of Up To 1 Character","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            StartWork();
            LoadCsvData();
            foreach (int index in chlistOutput.CheckedIndices)
            {
                string selectedItem = chlistOutput.Items[index].ToString();

                if (selectedItem == "Model")
                {
                    ModelSelected();
                }
                else if(selectedItem=="Sql")
                {
                    SqlSelected();
                }
                else if (selectedItem == "Mongo")
                {
                    MongoSelected();
                }

                selectedIndices.Add(index);
            }
            EndWork();
            MessageBox.Show($"File Saved To \n{txtExportPath.Text}","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnSetColNames_Click(object sender, EventArgs e)
        {
            StartWork();
            LoadForNewCols();
            EndWork();
            int headercount = headers.Count();
            frmNewColNames frm = new frmNewColNames(headercount);
            frm.Show();
        }
    }
}