using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using BeHerktSolutions.Model;
using BeHerktSolutions.Controller;

namespace BeHerktSolutions.View.Mantenedores
{
    public partial class MProfesor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Profesor profesor;
        private ProfesorController profesorController;
        private TipoIdController tipoIdController;
        public MProfesor()
        {
            InitializeComponent();
            profesorController = new ProfesorController();
            tipoIdController = new TipoIdController();
            LoadTipoId();
            LoadProfesor();
            ResetearTexto();
        }

        private void LoadTipoId()
        {
            srcTipoId.Clear();
            List<TipoId> tipoIds = tipoIdController.FindAll();
            foreach (TipoId tipoId in tipoIds)
            {
                srcTipoId.Add(tipoId);
            }
            cbTipoId.SelectedIndex = -1;
        }

        private void LoadProfesor()
        {
            srcProfesores.Clear();
            List<Profesor> profesors = profesorController.FindAll();
            foreach (Profesor profesor in profesors)
            {
                srcProfesores.Add(profesor);
            }
        }

        

        private char GetResideText()
        {
            return swReside.Value ? 'S': 'N';
        }

        private void ResetearTexto()
        {
            profesor = null;
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cbTipoId.SelectedIndex = -1;
            MiEstado.ImageOptions.LargeImage = Properties.Resources.cancel_32x321;
            lstProfesores.SelectedIndex = -1;
        }

        private void Limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            swReside.Value = true;
            cbTipoId.SelectedIndex = -1;
            scPanel.Panel2.Enabled = true;
            MiEstado.ImageOptions.LargeImage =  Properties.Resources.cancel_32x321;
            lstProfesores.SelectedIndex = -1;    
            MiEstado.Enabled = false;
            RbApellido.Checked = false;
            RbIdentificacion.Checked = false;
        }

        private void SaveOrUpdate()
        {
            if (IsDatosErroneos())
            {
                return;
            }

            if (profesor == null)
            {
                profesor = new Profesor();
                SetProfesorData();
                profesor.Estado = 'A';
                profesorController.Save(profesor);
                XtraMessageBox.Show("PROFESOR GUARDADO CON EXITO", "RESULTADO DE LA OPERACION",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                SetProfesorData();
                profesorController.Update(profesor);
                XtraMessageBox.Show("PROFESOR MODIFICADO CON EXITO", "RESULTADO DE LA OPERACION",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Limpiar();
            LoadProfesor();
            scPanel.Panel2.Enabled = false;
        }

        private void SetProfesorData()
        {
            profesor.Cedula = txtCedula.Text;
            profesor.Nombre = txtNombre.Text;
            profesor.Apellido = txtApellido.Text;
            profesor.Direccion = txtDireccion.Text;
            profesor.Telefono = txtTelefono.Text;
            profesor.Correo = txtCorreo.Text;
            profesor.Reside = GetResideText();
            profesor.TipoId = (TipoId)cbTipoId.SelectedItem;
        }

        private void MiEstado_Click(object sender, EventArgs e)
        {
            ActualizarEstado();
        }

        private void ActualizarEstado()
        {
            string text = "";
            if (profesor.Estado.Equals('I'))
            {
                profesor.Estado = 'A';
                text = "ESTADO DEL CLIENTE HABILITADO CORRECTAMENTE";

            }
            else
            {
                profesor.Estado = 'I';
                text = "ESTADO DEL CLIENTE DESHABILITADO CORRECTAMENTE";
            }
            profesorController.Update(profesor);
            XtraMessageBox.Show(text, "RESULTADO DE LA OPERACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProfesor();
            Limpiar();
        }

        private void UpdateImage()
        {
            MiEstado.ImageOptions.LargeImage = profesor.Estado.Equals('I') ? 
                Properties.Resources.apply_32x32 : Properties.Resources.cancel_32x321;
        }

        public bool IsDatosErroneos()
        {
            string errors = "";
            bool val = false;
            if (txtCedula.Text.Length < 10)
            {
                errors += "IDENTIFICACION INCORRECTA DEBE INGRESAR 10 DIGITOS O MAS \n";
                val = true;
            }
            if (txtNombre.Text.Length <= 0)
            {
                errors += "INGRESE NOMBRE \n";
                val = true;
            }
            if (txtApellido.Text.Length <= 0)
            {
                errors += "INGRESE APELLIDO \n";
                val = true;
            }
            if (cbTipoId.SelectedIndex == -1)
            {
                errors += "DEBE SELECCIONAR UN TIPO DE IDENTIFICACION \n";
                val = true;
            }

            if (val)
            {
                XtraMessageBox.Show(errors, "ERROR CRITICO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return val;
        }

       

        private void LstProfesoresOnIndexChanged()
        {
            profesor = (Profesor)lstProfesores.SelectedItem;

            txtCedula.Text = profesor.Cedula;
            txtNombre.Text = profesor.Nombre;
            txtApellido.Text = profesor.Apellido;
            txtDireccion.Text = profesor.Direccion;
            txtTelefono.Text = profesor.Telefono;
            txtCorreo.Text = profesor.Correo;
            cbTipoId.SelectedItem = profesor.TipoId;
            UpdateImage();
            MiEstado.Enabled = false;
            swReside.Value = profesor.Reside.Equals('S');
            scPanel.Panel2.Enabled = false;
            MiGuardar.Enabled = false;
        }

        private void Consultar()
        {
            srcProfesores.Clear();
            List<Profesor> profesors = null;
            if (RbApellido.Checked)
            {
                profesors = profesorController.FindByLastName(txtBusqueda.Text);
            }
            else
            {
                if (RbIdentificacion.Checked)
                {
                    profesors = profesorController.FindById(txtBusqueda.Text);
                }
                else
                {
                    XtraMessageBox.Show("SELECIONE UN PARAMETRO DE BUSQUEDA", "ERROR CRITICO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach (Profesor profesor in profesors)
            {
                srcProfesores.Add(profesor);
            }

        }



        private void MiNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpiar();
            MiGuardar.Enabled = true;
        }


        private void MiBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Consultar();
            MiGuardar.Enabled = false;
        }

        private void MiGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveOrUpdate();
        }

        private void MiEstado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActualizarEstado();
        }

        private void LstProfesores_DoubleClick(object sender, EventArgs e)
        {
            scPanel.Panel2.Enabled = true;
            MiEstado.Enabled = true;
            MiGuardar.Enabled = true;
        }

        private void lstProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstProfesores.SelectedIndex != -1)
            {
                LstProfesoresOnIndexChanged();
            }
        }
    }
}