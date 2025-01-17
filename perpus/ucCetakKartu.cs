﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace perpus
{
    public partial class ucCetakKartu : UserControl
    {
        public ucCetakKartu()
        {
            InitializeComponent();
        }

        public static int ID=0;
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void load()
        {
            if (ID != 0)
            {
                this.Controls.Add(reportViewer1);

                reportViewer1.Size = new Size(975, 419);
                reportViewer1.ZoomMode = ZoomMode.PageWidth;

                var report = from a in db.members
                             where a.nis == ID
                             select a;

                member memm = new member();
                memm = db.members.Single(x => x.nis == ID);

                reportViewer1.Reset();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.EnableHyperlinks = true;
                reportViewer1.LocalReport.EnableExternalImages = true;
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", report));
                reportViewer1.LocalReport.ReportEmbeddedResource = "perpus.Report2.rdlc";
                reportViewer1.LocalReport.SetParameters(new ReportParameter("test", new Uri(memm.pohoto.ToString()).AbsoluteUri));
                reportViewer1.RefreshReport();
            }
            
        }

        private void UcCetakKartu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void UcCetakKartu_VisibleChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
