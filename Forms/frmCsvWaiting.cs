﻿using DevExpress.Utils.Compress;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvTool
{
    public partial class frmCsvWaiting : DevExpress.XtraEditors.XtraForm
    {
        public frmCsvWaiting()
        {
            InitializeComponent();
        }

        private void frmCsvWaiting_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string file = files[0];
            frmConfiguration frm = new frmConfiguration(file);
            this.Hide();
            frm.Show();
        }

        private void frmCsvWaiting_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1)
                {
                    if (Path.GetExtension(files[0]).Equals(".csv", StringComparison.OrdinalIgnoreCase))
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                    else
                    {
                        e.Effect = DragDropEffects.None;
                    }
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private async void frmCsvWaiting_Load(object sender, EventArgs e)
        {
            //var client = new HttpClient();
            //var request = new HttpRequestMessage(HttpMethod.Get, "https://raw.githubusercontent.com/Eneswunbeaten/CsvTool/master/Version.txt");
            //request.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36");
            //request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
            //request.Headers.Add("sec-gpc", "1");
            //request.Headers.Add("accept-language", "tr-TR,tr;q=0.5");
            //var response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            //var responseBody = await response.Content.ReadAsStringAsync();
            //string AppdataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //string path = Path.Combine(AppdataPath, "CsvToolVersion.txt");
            //if (!File.Exists(path))
            //{
            //    using (StreamWriter writer = new StreamWriter(path))
            //    {
            //        writer.Write("0.1");
            //    };
            //}
            //else
            //{
            //    StreamReader reader = new StreamReader(path);
            //    string currentVersion = reader.ReadLine();
            //    reader.Dispose();
            //    StreamWriter writer = new StreamWriter(path);
            //    if (string.IsNullOrWhiteSpace(currentVersion))
            //    {
            //        writer.Write("0.1");
            //    }
            //    else if (currentVersion.Trim() == responseBody.Trim())
            //    {
            //        LblDragCsv.Text = "You are using the last version.";
            //        await Task.Delay(2000);
            //        LblDragCsv.Text = "Please drag the .csv file to the screen.";
            //    }
            //    else if (decimal.TryParse(currentVersion, out decimal currentdec) && decimal.TryParse(responseBody, out decimal responsedec))
            //    {
            //        if (responsedec > currentdec)
            //        {
            //            DialogResult dr = MessageBox.Show("A new version is available. Would you like to update it?", "Update Available", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //            switch (dr)
            //            {
            //                case DialogResult.OK:
            //                    LblDragCsv.Text = "Updating to the latest version.";
            //                    string zipUrl = $"https://codeload.github.com/Eneswunbeaten/CsvTool/zip/refs/heads/master";
            //                    HttpResponseMessage zipResponse = await client.GetAsync(zipUrl);
            //                    if (zipResponse.IsSuccessStatusCode)
            //                    {
            //                        byte[] zipBytes = await zipResponse.Content.ReadAsByteArrayAsync();
            //                        string zipFileName = $"CsvTool_{responseBody.Trim()}.zip";
            //                        path = Path.Combine(AppdataPath, zipFileName);
            //                        File.WriteAllBytes(path, zipBytes);
            //                        List<string> txtVersion = File.ReadAllLines(path).ToList();
            //                        txtVersion.Insert(0, responseBody);
            //                        LblDragCsv.Text = ($"New version is downloaded succesfully.");
            //                        string extractPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CsvTool");
            //                        System.IO.Compression.ZipFile.ExtractToDirectory(path, extractPath,true);
            //                        extractPath = Path.Combine(extractPath, "CsvTool-master");
            //                        dr = MessageBox.Show("The update is complete. Click OK to use the new version.", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //                        switch (dr)
            //                        {
            //                            case DialogResult.OK:
            //                                ProcessStartInfo startInfo = new ProcessStartInfo
            //                                {
            //                                    Arguments = $"{extractPath}",
            //                                    FileName = "explorer.exe"
            //                                };
            //                                Process.Start(startInfo);
            //                                break;
            //                            case DialogResult.Cancel:
            //                                break;
            //                            default:
            //                                break;
            //                        }
            //                    }
            //                    break;
            //                case DialogResult.Cancel:
            //                    break;
            //                default:
            //                    break;
            //            }

            //        }
            //        else
            //        {
            //            throw new Exception("The current version cannot be bigger than the one in the github repository.");
            //        }

                //}
            //}
        }
    }
}