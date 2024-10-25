using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
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

        public bool ViewReport(string reportName, string selectionFormula = "", string param = "")
        {
            ReportDocument objReport = new ReportDocument();
            string[] parValPair;
            string[] val;
            int index;
            ParameterDiscreteValue paraValue = new ParameterDiscreteValue();
            ParameterValues currValue;
            int intCounter;

            try
            {
                objReport.Load(reportName);
                objReport.SetDatabaseLogon("ajax", "Forward@123");
                intCounter = objReport.DataDefinition.ParameterFields.Count;

                if (intCounter == 1)
                {
                    if (objReport.DataDefinition.ParameterFields[0].ParameterFieldName.Contains("."))
                    {
                        intCounter = 0;
                    }
                }

                if (intCounter > 0 && !string.IsNullOrWhiteSpace(param))
                {
                    parValPair = param.Split('&');
                    for (index = 0; index < parValPair.Length; index++)
                    {
                        if (parValPair[index].Contains("="))
                        {
                            val = parValPair[index].Split('=');
                            for (int j = 0; j < val.Length; j++)
                            {
                                if (j == 1)
                                {
                                    if (val[j].Contains("/"))
                                    {
                                        DateTime dt = DateTime.Parse(val[j]);
                                        paraValue.Value = dt;
                                    }
                                    else
                                    {
                                        paraValue.Value = val[j];
                                    }
                                }
                            }
                        }

                        currValue = objReport.DataDefinition.ParameterFields[index].CurrentValues;
                        currValue.Clear();
                        currValue.Add(paraValue);
                        objReport.DataDefinition.ParameterFields[index].ApplyCurrentValues(currValue);
                    }
                }

                if (!string.IsNullOrWhiteSpace(selectionFormula))
                {
                    objReport.RecordSelectionFormula = selectionFormula;
                }

                crystalReportViewer1.ReportSource = null;
                crystalReportViewer1.ReportSource = objReport;

                if (string.IsNullOrWhiteSpace(param))
                {
                    crystalReportViewer1.RefreshReport();
                }

                crystalReportViewer1.Show();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }




        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
