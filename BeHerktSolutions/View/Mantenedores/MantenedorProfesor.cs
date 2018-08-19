using BeHerktSolutions.Controller;
using BeHerktSolutions.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeHerktSolutions.View.Mantenedores
{

    
    public partial class MantenedorProfesor : Form
    {
        private Profesor profesor;
        private ProfesorController profesorController;
        private TipoIdController tipoIdController;
        public MantenedorProfesor()
        {
            InitializeComponent();
            profesorController = new ProfesorController();
            tipoIdController = new TipoIdController();
            LoadTipoId();
            LoadProfesor();
        }

        private void LoadTipoId()
        {
            srcTipoId.Clear();
            List<TipoId> tipoIds = tipoIdController.FindAll();
            foreach(TipoId tipoId in tipoIds)
            {
                srcTipoId.Add(tipoId);
            }
            cbTipoId.SelectedIndex = -1;
        }

        private void LoadProfesor()
        {
            srcProfesores.Clear();
            List<Profesor> profesors = profesorController.FindAll();
            foreach(Profesor profesor in profesors)
            {
                srcProfesores.Add(profesor);
            }
        }

        private void MiNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void MiGuardar_Click(object sender, EventArgs e)
        {
            SaveOrUpdate();
        }

        private char GetResideText()
        {
            if (swReside.Value)
            {
                return 'S';
            }
            return 'N';
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
            MiEstado.Image = Properties.Resources.Cancel;
            MiEstado.ToolTipText = "Habilitar/Deshabilitar (F4)";
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

            if(profesor == null)
            {
                profesor = new Profesor();
                SetProfesorData();
                profesor.Estado = 'A';
                profesorController.Save(profesor);
                MessageBox.Show("PROFESOR GUARDADO CON EXITO", "RESULTADO DE LA OPERACION",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                SetProfesorData();
                profesorController.Update(profesor);
                MessageBox.Show("PROFESOR MODIFICADO CON EXITO", "RESULTADO DE LA OPERACION",
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
            MessageBox.Show(text, "RESULTADO DE LA OPERACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadProfesor();
            Limpiar();
        }

        private void UpdateImage()
        {
            if (profesor.Estado.Equals('I'))
            {
                MiEstado.Image = Properties.Resources.Ok;
                MiEstado.ToolTipText = "Habilitar (F4)";
            }
            else
            {
                MiEstado.Image = Properties.Resources.Cancel;
                MiEstado.ToolTipText = "Deshabilitar (F4)";
            }
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
                MessageBox.Show(errors, "ERROR CRITICO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return val;
        }

        private void lstProfesores_DoubleClick(object sender, EventArgs e)
        {
            LstProfesoresOnDoubleClick();
        }

        private void LstProfesoresOnDoubleClick()
        {
            profesor = (Profesor) lstProfesores.SelectedItem;

            txtCedula.Text = profesor.Cedula;
            txtNombre.Text = profesor.Nombre;
            txtApellido.Text = profesor.Apellido;
            txtDireccion.Text = profesor.Direccion;
            txtTelefono.Text = profesor.Telefono;
            txtCorreo.Text = profesor.Correo;
            cbTipoId.SelectedItem = profesor.TipoId;
            UpdateImage();
            MiEstado.Enabled = true;
            if (profesor.Reside.Equals('S'))
            {
                swReside.Value = true;
            }
            else
            {
                swReside.Value = false;
            }
            scPanel.Panel2.Enabled = true;
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
                    MessageBox.Show("SELECIONE UN PARAMETRO DE BUSQUEDA", "ERROR CRITICO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            foreach(Profesor profesor in profesors)
            {
                srcProfesores.Add(profesor);
            }

        }

        private void MiConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
