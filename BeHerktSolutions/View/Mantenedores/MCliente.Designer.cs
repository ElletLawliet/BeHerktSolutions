namespace BeHerktSolutions.View.Mantenedores
{
    partial class MCliente
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.cbTipoId = new System.Windows.Forms.ComboBox();
            this.srcTipoId = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBusquea = new System.Windows.Forms.Panel();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.srcClientes = new System.Windows.Forms.BindingSource(this.components);
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbIdentificacion = new System.Windows.Forms.RadioButton();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.miNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.miBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.miGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.miEstado = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcTipoId)).BeginInit();
            this.pnlBusquea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
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
            this.pnlDatos.Location = new System.Drawing.Point(366, 149);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(378, 383);
            this.pnlDatos.TabIndex = 17;
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
            // srcTipoId
            // 
            this.srcTipoId.DataSource = typeof(BeHerktSolutions.Model.TipoId);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "TIPO ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 151);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 21);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.TabStop = false;
            // 
            // txtCedula
            // 
            this.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedula.Location = new System.Drawing.Point(161, 31);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ShortcutsEnabled = false;
            this.txtCedula.Size = new System.Drawing.Size(181, 21);
            this.txtCedula.TabIndex = 16;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(160, 271);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(182, 21);
            this.txtDireccion.TabIndex = 20;
            this.txtDireccion.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "IDENTIFICACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "TELEFONO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "DIRECCION";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(160, 331);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(182, 21);
            this.txtTelefono.TabIndex = 22;
            this.txtTelefono.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(160, 211);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(181, 21);
            this.txtCorreo.TabIndex = 24;
            this.txtCorreo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "CORREO";
            // 
            // pnlBusquea
            // 
            this.pnlBusquea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusquea.Controls.Add(this.lstClientes);
            this.pnlBusquea.Controls.Add(this.txtBusqueda);
            this.pnlBusquea.Controls.Add(this.groupBox1);
            this.pnlBusquea.Location = new System.Drawing.Point(7, 149);
            this.pnlBusquea.Name = "pnlBusquea";
            this.pnlBusquea.Size = new System.Drawing.Size(352, 383);
            this.pnlBusquea.TabIndex = 16;
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
            this.lstClientes.Click += new System.EventHandler(this.lstClientes_Click);
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            this.lstClientes.DoubleClick += new System.EventHandler(this.LstClientes_DoubleClick);
            // 
            // srcClientes
            // 
            this.srcClientes.DataSource = typeof(BeHerktSolutions.Model.Cliente);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(3, 48);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(344, 21);
            this.txtBusqueda.TabIndex = 4;
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
            // rbIdentificacion
            // 
            this.rbIdentificacion.AutoSize = true;
            this.rbIdentificacion.Location = new System.Drawing.Point(7, 18);
            this.rbIdentificacion.Name = "rbIdentificacion";
            this.rbIdentificacion.Size = new System.Drawing.Size(89, 17);
            this.rbIdentificacion.TabIndex = 0;
            this.rbIdentificacion.TabStop = true;
            this.rbIdentificacion.Text = "Identificación";
            this.rbIdentificacion.UseVisualStyleBackColor = true;
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.Image = global::BeHerktSolutions.Properties.Resources.bocustomer_16x162;
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.ItemLinks.Add(this.miNuevo);
            this.mainRibbonPageGroup.ItemLinks.Add(this.miBuscar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.miGuardar);
            this.mainRibbonPageGroup.ItemLinks.Add(this.miEstado);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "ACCIONES";
            // 
            // miNuevo
            // 
            this.miNuevo.Caption = "NUEVO";
            this.miNuevo.Id = 10;
            this.miNuevo.ImageOptions.LargeImage = global::BeHerktSolutions.Properties.Resources.additem_32x321;
            this.miNuevo.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.miNuevo.Name = "miNuevo";
            this.miNuevo.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.miNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miNuevo_ItemClick);
            // 
            // miBuscar
            // 
            this.miBuscar.Caption = "BUSCAR";
            this.miBuscar.Id = 11;
            this.miBuscar.ImageOptions.LargeImage = global::BeHerktSolutions.Properties.Resources.lookup_reference_32x321;
            this.miBuscar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.miBuscar.Name = "miBuscar";
            this.miBuscar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.miBuscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miBuscar_ItemClick);
            // 
            // miGuardar
            // 
            this.miGuardar.Caption = "GUARDAR";
            this.miGuardar.Enabled = false;
            this.miGuardar.Id = 12;
            this.miGuardar.ImageOptions.LargeImage = global::BeHerktSolutions.Properties.Resources.save_32x324;
            this.miGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.miGuardar.Name = "miGuardar";
            this.miGuardar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.miGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miGuardar_ItemClick);
            // 
            // miEstado
            // 
            this.miEstado.Caption = "DESHABILITAR";
            this.miEstado.Enabled = false;
            this.miEstado.Id = 13;
            this.miEstado.ImageOptions.Image = global::BeHerktSolutions.Properties.Resources.apply_16x16;
            this.miEstado.ImageOptions.LargeImage = global::BeHerktSolutions.Properties.Resources.cancel_32x321;
            this.miEstado.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4);
            this.miEstado.Name = "miEstado";
            this.miEstado.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.miEstado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.miEstado_ItemClick);
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.AllowMinimizeRibbon = false;
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.miNuevo,
            this.miBuscar,
            this.miGuardar,
            this.miEstado});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 15;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(750, 146);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // MCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(750, 534);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlBusquea);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "MCliente";
            this.Ribbon = this.mainRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcTipoId)).EndInit();
            this.pnlBusquea.ResumeLayout(false);
            this.pnlBusquea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.ComboBox cbTipoId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlBusquea;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbIdentificacion;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.BarButtonItem miNuevo;
        private DevExpress.XtraBars.BarButtonItem miBuscar;
        private DevExpress.XtraBars.BarButtonItem miGuardar;
        private DevExpress.XtraBars.BarButtonItem miEstado;
        private System.Windows.Forms.BindingSource srcClientes;
        private System.Windows.Forms.BindingSource srcTipoId;
    }
}