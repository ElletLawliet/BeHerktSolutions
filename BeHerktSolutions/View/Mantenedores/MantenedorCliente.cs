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
    public partial class MantenedorCliente : Form
    {
        private Cliente cliente;
        private ClienteController clienteController;
        private TipoIdController tipoIdController;

        public MantenedorCliente()
        {
            InitializeComponent();
            clienteController = new ClienteController();
            tipoIdController = new TipoIdController();
            LoadTipoId();
            LoadCliente();
        }

        private void LstClientes_DoubleClick(object sender, EventArgs e)
        {
            miEstado.Enabled = true;
            pnlDatos.Enabled = true;
        }

        private void LstClientes_Click(object sender, EventArgs e)
        {
            cliente = (Cliente)srcClientes[lstClientes.SelectedIndex];

            txtCedula.Text = cliente.Cedula;
            txtNombre.Text = cliente.Nombre;
            txtDireccion.Text = cliente.Direccion;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            
            cbTipoId.SelectedItem = cliente.TipoId;
            UpdateImage();
           
        }


        private void miNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();            
        }

        private void miConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }


        public void Consultar()
        {
            srcClientes.Clear();
            List<Cliente> clientes = null;
            if (rbIdentificacion.Checked)
            {
                clientes = clienteController.FindById(txtBusqueda.Text);
            }
            else
            {
                if (rbNombre.Checked)
                {
                    clientes = clienteController.FindByName(txtBusqueda.Text);
                }
                else
                {
                    MessageBox.Show("SELECIONE UN PARAMETRO DE BUSQUEDA", "ERROR CRITICO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (Cliente cliente in clientes)
            {
                srcClientes.Add(cliente);
            }
        }

        private void miGuardar_Click(object sender, EventArgs e)
        {
            SaveOrUpdate();
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

        private void LoadCliente()
        {
            srcClientes.Clear();
            List<Cliente> clientes = clienteController.FindAll();
            foreach (Cliente cliente in clientes)
            {
                srcClientes.Add(cliente);
            }
        }


        private void Limpiar()
        {
            cliente = null;
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            pnlDatos.Enabled = true;
            cbTipoId.SelectedIndex = -1;
            miEstado.Image = Properties.Resources.cancel_32x321;
            miEstado.ToolTipText = "Habilitar/Deshabilitar (F4)";
            miEstado.Enabled = false;
        }

        private void SaveOrUpdate()
        {
            if (IsDatosErroneos())
            {
                return;
            }

            if (cliente == null)
            {
                cliente = new Cliente(
                    txtCedula.Text,
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtCorreo.Text,
                    (TipoId)srcTipoId[cbTipoId.SelectedIndex],
                    'A'
                    );

                clienteController.Save(cliente);

                MessageBox.Show("CLIENTE GUARDADO CON EXITO", "RESULTADO DE LA OPERACION",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                cliente.Cedula = txtCedula.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.TipoId = (TipoId)srcTipoId[cbTipoId.SelectedIndex];

                clienteController.Update(cliente);
                MessageBox.Show("CLIENTE MODIFICADO CON EXITO", "RESULTADO DE LA OPERACION", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            Limpiar();
            LoadCliente();
            pnlDatos.Enabled = false;
        }
    public bool IsDatosErroneos()
        {
            string errors = "";
            bool val = false;
            if(txtCedula.Text.Length < 10)
            {
                errors += "IDENTIFICACION INCORRECTA DEBE INGRESAR 10 DIGITOS O MAS \n";
                val = true;
            }
            if(txtNombre.Text.Length <= 0)
            {
                errors += "INGRESE NOMBRE \n";
                val = true;
            }
            if(cbTipoId.SelectedIndex == -1)
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

        private void miEstado_Click(object sender, EventArgs e)
        {
            ActualizarEstado();
        }

        private void ActualizarEstado()
        {
            string text = "";
            if (cliente.Estado.Equals('I'))
            {
                cliente.Estado = 'A';
                text = "ESTADO DEL CLIENTE HABILITADO CORRECTAMENTE";
                
            }
            else
            {
                cliente.Estado = 'I';
                text = "ESTADO DEL CLIENTE DESHABILITADO CORRECTAMENTE";
            }
            clienteController.Update(cliente);
            MessageBox.Show(text, "RESULTADO DE LA OPERACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void UpdateImage()
        {
            if (cliente.Estado.Equals('I'))
            {
                miEstado.Image = Properties.Resources.Ok;
                miEstado.ToolTipText = "Habilitar (F4)";
            }
            else
            {
                miEstado.Image = Properties.Resources.Cancel;
                miEstado.ToolTipText = "Deshabilitar (F4)";
            }
        }


    }
}

