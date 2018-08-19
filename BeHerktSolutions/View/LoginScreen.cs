using BeHerktSolutions.Controller;
using BeHerktSolutions.Model;
using BeHerktSolutions.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeHerktSolutions
{
    public partial class loginScreen : Form
    {

        private UsuarioController db = new UsuarioController();
        public loginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            /*
            using (BeHerktEntities entity = new BeHerktEntities())
            {
                Usuario usuario = new Usuario();
                usuario.codusuario = 1;
                usuario.nombre = "Ellet";
                usuario.contraseña = BCrypt.Net.BCrypt.HashPassword("sergitop12");
                usuario.fecharegistro = DateTime.Now;
                usuario.fechamodificacion = DateTime.Now;

                

                try
                {
                    entity.Usuario.Add(usuario);
                    entity.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
            */

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            TxtContraseña.Text = "";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            

                Usuario usuario = db.FindByAlias(TxtUsuario.Text);
              

                //int bit = db.Database.SqlQuery<Int32>(sp, parametros).SingleOrDefault();
                
                bool bit = BCrypt.Net.BCrypt.Verify(TxtContraseña.Text, usuario.Contrasena);
                Console.WriteLine(BCrypt.Net.BCrypt.HashPassword(TxtContraseña.Text));
                if(bit)
                {
                    MessageBox.Show("LOGIN EXITOSO");
                    Principal p = new Principal(usuario);
                    p.Show();

                }
                else
                {
                    MessageBox.Show("LOGIN FALLIDO");
                }
            

            //BCrypt.Net.BCrypt.Verify();
           

        }
    }
}
