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
    public partial class MCliente : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private Cliente cliente;
        private ClienteController clienteController;
        private TipoIdController tipoIdController;
        public MCliente()
        {
            InitializeComponent();
            clienteController = new ClienteController();
            tipoIdController = new TipoIdController();
            LoadTipoId();
            LoadCliente();
            ResetearTexto();
            
        }


        private void LstClientes_DoubleClick(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            miEstado.Enabled = true;
            miGuardar.Enabled = true;
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
                    XtraMessageBox.Show("SELECIONE UN PARAMETRO DE BUSQUEDA", "ERROR CRITICO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (Cliente cliente in clientes)
            {
                srcClientes.Add(cliente);
            }
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
            miEstado.ImageOptions.LargeImage = Properties.Resources.cancel_32x321;
            miEstado.Enabled = false;
            miGuardar.Enabled = false;
            lstClientes.SelectedIndex = -1;
        }

        private void ResetearTexto()
        {
            cliente = null;
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cbTipoId.SelectedIndex = -1;
            miEstado.ImageOptions.LargeImage = Properties.Resources.cancel_32x321;
            lstClientes.SelectedIndex = -1;
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

                XtraMessageBox.Show("CLIENTE GUARDADO CON EXITO", "RESULTADO DE LA OPERACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cliente.Cedula = txtCedula.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.TipoId = (TipoId)srcTipoId[cbTipoId.SelectedIndex];

                clienteController.Update(cliente);
                XtraMessageBox.Show("CLIENTE MODIFICADO CON EXITO", "RESULTADO DE LA OPERACION",
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
            XtraMessageBox.Show(text, "RESULTADO DE LA OPERACION",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void UpdateImage()
        {
            if (cliente.Estado.Equals('I'))
            {
                miEstado.ImageOptions.LargeImage = Properties.Resources.apply_32x32;
                miEstado.Caption = "HABILITAR";
            }
            else
            {
                miEstado.ImageOptions.LargeImage = Properties.Resources.cancel_32x321;
                miEstado.Caption = "DESHABILITAR";
            }
        }

        private void miNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpiar();
            miGuardar.Enabled = true;
        }

        private void miBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Consultar();
            miGuardar.Enabled = false;
        }

        private void miGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveOrUpdate();
        }

        private void miEstado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ActualizarEstado();
        }

        private void lstClientes_Click(object sender, EventArgs e)
        {
            
            
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstClientes.SelectedIndex != -1)
            {
                pnlDatos.Enabled = false;
                miEstado.Enabled = false;
                miGuardar.Enabled = false;
                cliente = (Cliente)srcClientes[lstClientes.SelectedIndex];
                txtCedula.Text = cliente.Cedula;
                txtNombre.Text = cliente.Nombre;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono;
                txtCorreo.Text = cliente.Correo;
                cbTipoId.SelectedItem = cliente.TipoId;
                UpdateImage();
            }
            
        }
    }
}
