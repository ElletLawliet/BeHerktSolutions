using BeHerktSolutions.Model;
using BeHerktSolutions.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BeHerktSolutions.View
{
    public partial class Principal : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Usuario usuario)
        {
            InitializeComponent();
            lbNombre.Text = usuario.Nombre.ToUpper();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            LbFecha.Text = Utilities.GetDayInSpanish() + " " +  DateTime.Today.Day + " "
                + " DE " + Utilities.GetMonthInSpanish() + " DEL " + DateTime.Today.Year ; 
            LbTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            timer.Elapsed += LbTime_Update;
            timer.Start();
            
        }

        private void LbTime_Update(object sender, ElapsedEventArgs e)
        {
            
            LbTime.Invoke((MethodInvoker)delegate ()
            {
                LbTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            
            });
        }

        
        private void acreditaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CotizacionPlaneacionEstrategica PlanEstrategico = new CotizacionPlaneacionEstrategica();
            PlanEstrategico.Show();
        }

        private void cotizaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CotizacionDireccionProyectos DirProy = new CotizacionDireccionProyectos();
            DirProy.Show();
        }
    }
}
