using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Reporting.WebForms;

namespace MvcReportViewer
{
    internal class ReportViewerParameters
    {
        public ReportViewerParameters()
        {
            InitialParameters = new Dictionary<string, ReportParameter>();
            ReportParameters = new Dictionary<string, ReportParameter>();
        }

        public string ReportServerUrl { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string ReportPath { get; set; }

        public Guid? ControlId { get; set; }

        public ProcessingMode ProcessingMode { get; set; }

        public bool IsAzureSsrs { get; set; }

        public IDictionary<string, ReportParameter>  InitialParameters { get; set; }

        public IDictionary<string, ReportParameter> ReportParameters { get; set; }

        public IDictionary<string, DataTable> LocalReportDataSources { get; set; }

        public bool IsReportRunnerExecution { get; set; }

        public ControlSettings ControlSettings { get; set; }
    }
}
