using BeHerktSolutions.Model;
using System.Windows.Forms;

namespace BeHerktSolutions.View.Mantenedores
{
    partial class MantenedorCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnOpciones = new System.Windows.Forms.MenuStrip();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.miNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.miConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.miGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.miEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.srcClientes = new System.Windows.Forms.BindingSource(this.components);
            this.srcTipoId = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIdentificacion = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.pnlBusquea = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoId = new System.Windows.Forms.ComboBox();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.mnOpciones.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcTipoId)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlBusquea.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnOpciones
            // 
            this.mnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.mnOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnOpciones.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNuevo,
            this.miConsultar,
            this.miGuardar,
            this.miEstado});
            this.mnOpciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnOpciones.Location = new System.Drawing.Point(0, 0);
            this.mnOpciones.Name = "mnOpciones";
            this.mnOpciones.ShowItemToolTips = true;
            this.mnOpciones.Size = new System.Drawing.Size(736, 40);
            this.mnOpciones.TabIndex = 0;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 38);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(800, 15);
            this.bunifuSeparator1.TabIndex = 11;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusqueda.Controls.Add(this.pnlDatos);
            this.pnlBusqueda.Controls.Add(this.pnlBusquea);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 40);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(736, 390);
            this.pnlBusqueda.TabIndex = 12;
            // 
            // miNuevo
            // 
            this.miNuevo.AutoToolTip = true;
            this.miNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.miNuevo.Image = global::BeHerktSolutions.Properties.Resources._new;
            this.miNuevo.Name = "miNuevo";
            this.miNuevo.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miNuevo.Size = new System.Drawing.Size(44, 36);
            this.miNuevo.Text = "imgNuevo";
            this.miNuevo.ToolTipText = "Nuevo (F1)";
            this.miNuevo.Click += new System.EventHandler(this.miNuevo_Click);
            // 
            // miConsultar
            // 
            this.miConsultar.AutoToolTip = true;
            this.miConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.miConsultar.Image = global::BeHerktSolutions.Properties.Resources.search1;
            this.miConsultar.Name = "miConsultar";
            this.miConsultar.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.miConsultar.Size = new System.Drawing.Size(44, 36);
            this.miConsultar.Text = "imgConsultar";
            this.miConsultar.ToolTipText = "Buscar (F2)";
            this.miConsultar.Click += new System.EventHandler(this.miConsultar_Click);
            // 
            // miGuardar
            // 
            this.miGuardar.AutoToolTip = true;
            this.miGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.miGuardar.Image = global::BeHerktSolutions.Properties.Resources.save;
            this.miGuardar.Name = "miGuardar";
            this.miGuardar.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.miGuardar.Size = new System.Drawing.Size(44, 36);
            this.miGuardar.Text = "imgGuardar";
            this.miGuardar.ToolTipText = "Guardar (F3)";
            this.miGuardar.Click += new System.EventHandler(this.miGuardar_Click);
            // 
            // miEstado
            // 
            this.miEstado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.miEstado.Enabled = false;
            this.miEstado.Image = global::BeHerktSolutions.Properties.Resources.Cancel;
            this.miEstado.Name = "miEstado";
            this.miEstado.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.miEstado.Size = new System.Drawing.Size(44, 36);
            this.miEstado.Text = "miEstado";
            this.miEstado.ToolTipText = "Habilitar/Deshabilitar (F4)";
            this.miEstado.Click += new System.EventHandler(this.miEstado_Click);
            // 
            // srcClientes
            // 
            this.srcClientes.DataSource = typeof(BeHerktSolutions.Model.Cliente);
            // 
            // srcTipoId
            // 
            this.srcTipoId.DataSource = typeof(BeHerktSolutions.Model.TipoId);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbIdentificacion);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 41);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros de Búsqueda";
            // 
            // rbIdentificacion
            // 
            this.rbIdentificacion.AutoSize = true;
            this.rbIdentificacion.Location = new System.Drawing.Point(7, 18);
            this.rbIdentificacion.Name = "rbIdentificacion";
            this.rbIdentificacion.Size = new System.Drawing.Size(88, 17);
            this.rbIdentificacion.TabIndex = 0;
            this.rbIdentificacion.TabStop = true;
            this.rbIdentificacion.Text = "Identificación";
            this.rbIdentificacion.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(281, 18);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(62, 17);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(3, 48);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(344, 20);
            this.txtBusqueda.TabIndex = 4;
            // 
            // lstClientes
            // 
            this.lstClientes.DataSource = this.srcClientes;
            this.lstClientes.DisplayMember = "Nombre";
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(3, 75);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(344, 303);
            this.lstClientes.TabIndex = 5;
            this.lstClientes.DoubleClick += new System.EventHandler(this.LstClientes_DoubleClick);
            // 
            // pnlBusquea
            // 
            this.pnlBusquea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusquea.Controls.Add(this.lstClientes);
            this.pnlBusquea.Controls.Add(this.txtBusqueda);
            this.pnlBusquea.Controls.Add(this.groupBox1);
            this.pnlBusquea.Location = new System.Drawing.Point(3, 2);
            this.pnlBusquea.Name = "pnlBusquea";
            this.pnlBusquea.Size = new System.Drawing.Size(352, 383);
            this.pnlBusquea.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "CORREO";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(160, 211);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(181, 20);
            this.txtCorreo.TabIndex = 24;
            this.txtCorreo.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(160, 331);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(182, 20);
            this.txtTelefono.TabIndex = 22;
            this.txtTelefono.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "DIRECCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "TELEFONO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "IDENTIFICACION";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(160, 271);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(182, 20);
            this.txtDireccion.TabIndex = 20;
            this.txtDireccion.TabStop = false;
            // 
            // txtCedula
            // 
            this.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedula.Location = new System.Drawing.Point(161, 31);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ShortcutsEnabled = false;
            this.txtCedula.Size = new System.Drawing.Size(181, 20);
            this.txtCedula.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 151);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "TIPO ID";
            // 
            // cbTipoId
            // 
            this.cbTipoId.DataSource = this.srcTipoId;
            this.cbTipoId.DisplayMember = "Descripcion";
            this.cbTipoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTipoId.FormattingEnabled = true;
            this.cbTipoId.Location = new System.Drawing.Point(161, 91);
            this.cbTipoId.Name = "cbTipoId";
            this.cbTipoId.Size = new System.Drawing.Size(180, 21);
            this.cbTipoId.TabIndex = 26;
            this.cbTipoId.TabStop = false;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.cbTipoId);
            this.pnlDatos.Controls.Add(this.label6);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.txtCedula);
            this.pnlDatos.Controls.Add(this.txtDireccion);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.txtTelefono);
            this.pnlDatos.Controls.Add(this.txtCorreo);
            this.pnlDatos.Controls.Add(this.label5);
            this.pnlDatos.Enabled = false;
            this.pnlDatos.Location = new System.Drawing.Point(357, 2);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(378, 383);
            this.pnlDatos.TabIndex = 15;
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(736, 430);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.mnOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnOpciones;
            this.Name = "MantenedorCliente";
            this.Text = "MantenedorCliente";
            this.mnOpciones.ResumeLayout(false);
            this.mnOpciones.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.srcClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcTipoId)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlBusquea.ResumeLayout(false);
            this.pnlBusquea.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void setC()
        {
            Cliente c = new Cliente();
            c.Cedula = "0952162782";
            c.Nombre = "SERGIO GABRIEL BRIONES HERKT";
            c.Direccion = "ROSALES 1 MZ 5 VILLA 6";
            c.Telefono = "0991052456";
            c.Correo = "sergio.brionesh82@gmail.com";

            srcClientes.Add(c);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnOpciones;
        private System.Windows.Forms.ToolStripMenuItem miNuevo;
        private System.Windows.Forms.ToolStripMenuItem miConsultar;
        private System.Windows.Forms.ToolStripMenuItem miGuardar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Panel pnlBusqueda;
        private BindingSource srcClientes;
        private BindingSource srcTipoId;
        private ToolStripMenuItem miEstado;
        private Panel pnlDatos;
        private ComboBox cbTipoId;
        private Label label6;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtDireccion;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Label label5;
        private Panel pnlBusquea;
        private ListBox lstClientes;
        private TextBox txtBusqueda;
        private GroupBox groupBox1;
        private RadioButton rbNombre;
        private RadioButton rbIdentificacion;
    }
}