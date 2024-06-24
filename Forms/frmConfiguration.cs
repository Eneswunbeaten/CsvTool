using CsvTool.Forms;
using DevExpress.Mvvm.Native;
using DevExpress.XtraSplashScreen;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using System.Data;
using System.IO;
using System.Text;

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
        void Refresh()
        {
            _csvPath = filePath;
            headers = null;
            dataList.Clear();
            valtypes.Clear();
        }
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
                    if (ChboxAvailableOnFirstRow.CheckState == CheckState.Checked)
                    {
                        headers = sr.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(_ => _.Trim('\"')).ToArray();
                    }
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cols = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                        Dictionary<string, string> rowData = new Dictionary<string, string>();

                        for (int i = 0; i < headers.Length; i++)
                        {
                            if (i < cols.Length)
                            {
                                string trimmedValue = cols[i].Trim('\"');
                                rowData.Add(headers[i].Trim(), trimmedValue.Trim());
                                Type valueType = DetermineValueType(trimmedValue);
                                if (!valtypes.ContainsKey(headers[i].Trim()))
                                {
                                    valtypes.Add(headers[i].Trim(), valueType);
                                }
                                else if (valueType != valtypes[headers[i].Trim()])
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

            lblrowcount.Text = "Row Count :" + dataList.Count().ToString();
        }
        void LoadHeaders()
        {
            filePath = _csvPath;
            try
            {
                char.TryParse(txtDelimiter.Text, out delimiter);
                using (StreamReader sr = new StreamReader(filePath))
                {
                    headers = sr.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(h => h.Trim('\"')).ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred. Error Message:" + ex, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RemoveHeader(string headerToRemove)
        {
            if (headers != null && headers.Length > 0)
            {
                int Index = Array.IndexOf(headers, headerToRemove);
                if (Index >= 0)
                {
                    headers = headers.Where((h, i) => i != Index).ToArray();
                }
                foreach (var rowData in dataList)
                {
                    rowData.Remove(headerToRemove);
                }
                if (valtypes.ContainsKey(headerToRemove))
                {
                    valtypes.Remove(headerToRemove);
                }
            }
        }
        public string[] InsertAtBeginning()
        {
            var Idname = "id";
            if (ChboxAddId.CheckState == CheckState.Checked)
            {
                if (!string.IsNullOrEmpty(TxtIdName.Text))
                {
                    Idname = TxtIdName.Text;   
                }
            }
            string[] newArray = new string[headers.Length + 1];
            newArray[0] = Idname;

            for (int i = 0; i < headers.Length; i++)
            {
                newArray[i + 1] = headers[i];
            }
            foreach (var rowData in dataList)
            {
                rowData[Idname] = ObjectId.GenerateNewId().ToString();
            }

            return newArray;
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

            else if (type1 == typeof(double) || type2 == typeof(double))
                return typeof(double);

            else if (type1 == typeof(float) || type2 == typeof(float))
                return typeof(float);

            else if (type1 == typeof(decimal) || type2 == typeof(decimal))
                return typeof(decimal);

            else if (type1 == typeof(long) || type2 == typeof(long))
                return typeof(long);
            return typeof(int);
        }
        private Type DetermineValueType(string value)
        {
            if (int.TryParse(value, out _))
                return typeof(int);

            else if (long.TryParse(value, out _))
                return typeof(long);

            else if (decimal.TryParse(value, out _))
                return typeof(decimal);

            else if (bool.TryParse(value, out _))
                return typeof(bool);

            else if (DateTime.TryParse(value, out _))
                return typeof(DateTime);
            else
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
        #region ConvertMethods
        void ModelSelected()
        {
            string newModelDataPath = Path.Combine(txtExportPath.Text, $"{txtTableName.Text}_Model.txt");
            using (StreamWriter writer = new StreamWriter(newModelDataPath))
            {
                foreach (string header in headers)
                {
                    string propertyName = GetValidIdentifier(header);
                    Type columnType;
                    if (valtypes.TryGetValue(header, out columnType))
                    {
                        writer.WriteLine($"public {columnType.Name} {propertyName} {{ get; set; }}");
                    }
                    else
                    {
                        writer.WriteLine($"public string {propertyName} {{ get; set; }}");
                    }
                }
            }
        }
        void SqlSelected()
        {
            string newModelDataPath = Path.Combine(txtExportPath.Text, $"{txtTableName.Text}_Sql.txt");
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
            string newModelDataPath = Path.Combine(txtExportPath.Text, $"{txtTableName.Text}_Mongo.txt");
            using (StreamWriter writer = new StreamWriter(newModelDataPath))
            {
                writer.WriteLine($"db.getCollection(\"{txtTableName.Text}\").insert([");

                if (headers == null || headers.Length == 0)
                {
                    MessageBox.Show("Headers are empty. Please check the CSV file and delimiter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dataList == null || dataList.Count == 0)
                {
                    MessageBox.Show("Data list is empty. Please check the CSV file and delimiter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
                        writer.Write(", \n{ ");
                    }

                    //if (ChboxAddId.CheckState == CheckState.Checked)
                    //{
                    //    writer.Write($"{(string.IsNullOrEmpty(TxtIdName.Text) ? "_id" : TxtIdName.Text)}: \"{ObjectId.GenerateNewId()}\", ");
                    //}

                    int i = 0;
                    foreach (var header in headers)
                    {
                        i++;
                        string value = rowData.ContainsKey(header) ? rowData[header] : "null";
                        writer.Write($"\"{header.Trim()}\": \"{value.Replace("\"", "\\\"")}\"");
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

        void CustomSelected()
        {
            StartWork();
            //IdColumnInserting();
            //LoadHeaders();
            headers = InsertAtBeginning();
            frmCustomPrinting frm = new frmCustomPrinting(headers, txtExportPath.Text, txtTableName.Text, dataList);
            frm.Show();
            EndWork();
        }

        #endregion

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = Path.GetDirectoryName(filePath);
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtExportPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        List<int> selectedIndices = new List<int>();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            filePath = _csvPath;
            #region Possible Exception Control
            if (string.IsNullOrEmpty(txtDelimiter.Text))
            {
                MessageBox.Show("Delimiter Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDelimiter.Text.Length >= 2)
            {
                MessageBox.Show("The Delimiter Can Consist Of Up To 1 Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTableName.Text))
            {
                MessageBox.Show("Table Name Field Is Left Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(txtExportPath.Text))
            {
                txtExportPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
            #endregion

            StartWork();
            LoadCsvData();
            //RemoveHeader("inCode");

            LoadHeaders();
            foreach (int index in chlistOutput.CheckedIndices)
            {
                string selectedItem = chlistOutput.Items[index].ToString();

                if (selectedItem.Contains("Model"))
                {
                    ModelSelected();
                }
                else if (selectedItem.Contains("Sql"))
                {
                    SqlSelected();
                }
                else if (selectedItem.Contains("Mongo"))
                {
                    if (ChboxAddId.CheckState == CheckState.Checked)
                        headers = InsertAtBeginning();
                    MongoSelected();
                }
                else if (selectedItem.Contains("Custom"))
                {
                    CustomSelected();
                    return;
                }
                selectedIndices.Add(index);
            }
            EndWork();
            MessageBox.Show($"File Saved To \n{txtExportPath.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnSetColNames_Click(object sender, EventArgs e)
        {
            StartWork();
            headers = InsertAtBeginning();
            RemoveHeader("inCode");
            EndWork();
            int headerCount = headers.Count();
            frmNewColNames frm = new frmNewColNames(headerCount, headers);
            frm.Visible = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                headers = frm.NewCols;
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void frmConfiguration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chlistOutput_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool isMongoSelected = true;
            foreach (int index in chlistOutput.CheckedIndices)
            {
                if (chlistOutput.Items[index].ToString().Contains("Mongo"))
                {
                    isMongoSelected = false;
                    break;
                }
            }
            ChboxAddId.Enabled = isMongoSelected;
        }

        private void ChboxAddId_CheckedChanged(object sender, EventArgs e)
        {
            if (ChboxAddId.CheckState == CheckState.Checked)
                TxtIdName.Enabled = true;
            else
                TxtIdName.Enabled = false;
        }
    }
}
