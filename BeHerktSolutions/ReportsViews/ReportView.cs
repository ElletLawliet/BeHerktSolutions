using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeHerktSolutions.ReportsViews
{
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();

            this.Text = "LISTADO DE CLIENTES";

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:\\Users\\serbr\\source\\repos\\BeHerktSolutions\\BeHerktSolutions\\ReportsViews\\RListadoClientes.rpt");
            cryRpt.DataDefinition.FormulaFields["Titulo"].Text = "'BE HERKT SOLUTIONS AND PLANNING STRATEGY'";
            cryRpt.DataDefinition.FormulaFields["Subtitulo"].Text = "'LISTADO DE CLIENTES'";
            cryRpt.SetDatabaseLogon("sa", "sergitop12");
            CrReportViewer.ReportSource = cryRpt;
            CrReportViewer.Refresh();
        }
    }
}
