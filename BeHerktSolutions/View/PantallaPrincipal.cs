using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using BeHerktSolutions.ReportsViews;
using BeHerktSolutions.View.Mantenedores;

namespace BeHerktSolutions.View
{
    public partial class PantallaPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public PantallaPrincipal()
        {
            InitializeComponent();
           
          
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReportView rp = new ReportView();
            rp.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            MCliente mCliente = new MCliente();
            mCliente.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            MProfesor mProfesor = new MProfesor();
            mProfesor.Show();
        }
    }
}