using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private const string DatabaseUsername = "ajax";
        private const string DatabasePassword = "Forward@123";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization code, if needed
        }

        public bool ViewReport(string reportPath, string selectionFormula = "", string param = "")
        {
            try
            {
                if (string.IsNullOrEmpty(reportPath) || !File.Exists(reportPath))
                {
                    MessageBox.Show("Report file does not exist or path is invalid.");
                    return false;
                }

                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(reportPath);
                SetDatabaseLogon(reportDocument);

                if (!string.IsNullOrEmpty(param))
                {
                    ApplyParameters(reportDocument, param);
                }

                if (!string.IsNullOrEmpty(selectionFormula))
                {
                    reportDocument.RecordSelectionFormula = selectionFormula;
                }

                // Set the report source and refresh the viewer
                CRViewer.ReportSource = reportDocument;
                CRViewer.RefreshReport(); // Use RefreshReport instead of Refresh
                MessageBox.Show("Report loaded successfully in CrystalReportViewer.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}\n{ex.StackTrace}");
                return false;
            }
        }

        private void SetDatabaseLogon(ReportDocument reportDocument)
        {
            try
            {
                foreach (Table table in reportDocument.Database.Tables)
                {
                    var logOnInfo = table.LogOnInfo;
                    logOnInfo.ConnectionInfo.ServerName = "10.10.100.4"; // Update with your server name
                    logOnInfo.ConnectionInfo.DatabaseName = "MIS"; // Update with your database name
                    logOnInfo.ConnectionInfo.UserID = DatabaseUsername;
                    logOnInfo.ConnectionInfo.Password = DatabasePassword;
                    table.ApplyLogOnInfo(logOnInfo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error setting database logon: {ex.Message}", ex);
            }
        }

        private void ApplyParameters(ReportDocument reportDocument, string param)
        {
            string[] paramPairs = param.Split('&');
            foreach (var paramPair in paramPairs)
            {
                string[] keyValue = paramPair.Split('=');
                if (keyValue.Length == 2)
                {
                    string paramName = keyValue[0].Trim();
                    string paramValue = keyValue[1].Trim();

                    try
                    {
                        var paramFieldDefinition = reportDocument.DataDefinition.ParameterFields[paramName];
                        if (paramFieldDefinition != null)
                        {
                            var paramValues = paramFieldDefinition.CurrentValues;
                            var paramDiscreteValue = new ParameterDiscreteValue
                            {
                                Value = TryParseParameter(paramValue)
                            };

                            paramValues.Clear();
                            paramValues.Add(paramDiscreteValue);
                            paramFieldDefinition.ApplyCurrentValues(paramValues);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error applying parameter '{paramName}': {ex.Message}", ex);
                    }
                }
            }
        }

        private object TryParseParameter(string paramValue)
        {
            if (DateTime.TryParse(paramValue, out var dateValue))
            {
                return dateValue;
            }
            else if (double.TryParse(paramValue, out var numericValue))
            {
                return numericValue;
            }
            else
            {
                return paramValue;
            }
        }

        private void ExportReportToPdf(ReportDocument reportDocument, string fileName)
        {
            var exportOptions = reportDocument.ExportOptions;
            var diskOptions = new DiskFileDestinationOptions { DiskFileName = fileName };
            var formatOptions = new PdfRtfWordFormatOptions();

            exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            exportOptions.DestinationOptions = diskOptions;
            exportOptions.FormatOptions = formatOptions;

            reportDocument.Export();
        }

        private string GeneratePdfFileName(string pdfPath)
        {
            string timestamp = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");
            return Path.Combine(pdfPath, $"Report_{timestamp}.pdf");
        }
    }
}
