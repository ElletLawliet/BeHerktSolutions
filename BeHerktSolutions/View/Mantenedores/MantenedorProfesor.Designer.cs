namespace BeHerktSolutions.View.Mantenedores
{
    partial class MantenedorProfesor
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
            this.MiNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.MiConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.MiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.MiEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.scPanel = new System.Windows.Forms.SplitContainer();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lstProfesores = new System.Windows.Forms.ListBox();
            this.srcProfesores = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbApellido = new System.Windows.Forms.RadioButton();
            this.RbIdentificacion = new System.Windows.Forms.RadioButton();
            this.swReside = new Bunifu.Framework.UI.BunifuSwitch();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.mnOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPanel)).BeginInit();
            this.scPanel.Panel1.SuspendLayout();
            this.scPanel.Panel2.SuspendLayout();
            this.scPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcProfesores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcTipoId)).BeginInit();
            this.SuspendLayout();
            // 
            // mnOpciones
            // 
            this.mnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.mnOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnOpciones.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiNuevo,
            this.MiConsultar,
            this.MiGuardar,
            this.MiEstado});
            this.mnOpciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnOpciones.Location = new System.Drawing.Point(0, 0);
            this.mnOpciones.Name = "mnOpciones";
            this.mnOpciones.ShowItemToolTips = true;
            this.mnOpciones.Size = new System.Drawing.Size(800, 40);
            this.mnOpciones.TabIndex = 1;
            // 
            // MiNuevo
            // 
            this.MiNuevo.AutoToolTip = true;
            this.MiNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MiNuevo.Image = global::BeHerktSolutions.Properties.Resources._new;
            this.MiNuevo.Name = "MiNuevo";
            this.MiNuevo.Size = new System.Drawing.Size(44, 36);
            this.MiNuevo.Text = "imgNuevo";
            this.MiNuevo.ToolTipText = "Nuevo (F1)";
            this.MiNuevo.Click += new System.EventHandler(this.MiNuevo_Click);
            // 
            // MiConsultar
            // 
            this.MiConsultar.AutoToolTip = true;
            this.MiConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MiConsultar.Image = global::BeHerktSolutions.Properties.Resources.search1;
            this.MiConsultar.Name = "MiConsultar";
            this.MiConsultar.Size = new System.Drawing.Size(44, 36);
            this.MiConsultar.Text = "imgConsultar";
            this.MiConsultar.ToolTipText = "Buscar (F2)";
            this.MiConsultar.Click += new System.EventHandler(this.MiConsultar_Click);
            // 
            // MiGuardar
            // 
            this.MiGuardar.AutoToolTip = true;
            this.MiGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MiGuardar.Image = global::BeHerktSolutions.Properties.Resources.save;
            this.MiGuardar.Name = "MiGuardar";
            this.MiGuardar.Size = new System.Drawing.Size(44, 36);
            this.MiGuardar.Text = "imgGuardar";
            this.MiGuardar.ToolTipText = "Guardar (F3)";
            this.MiGuardar.Click += new System.EventHandler(this.MiGuardar_Click);
            // 
            // MiEstado
            // 
            this.MiEstado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MiEstado.Enabled = false;
            this.MiEstado.Image = global::BeHerktSolutions.Properties.Resources.Cancel;
            this.MiEstado.Name = "MiEstado";
            this.MiEstado.Size = new System.Drawing.Size(44, 36);
            this.MiEstado.Text = "miEstado";
            this.MiEstado.ToolTipText = "Habilitar/Deshabilitar (F4)";
            this.MiEstado.Click += new System.EventHandler(this.MiEstado_Click);
            // 
            // scPanel
            // 
            this.scPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPanel.Location = new System.Drawing.Point(0, 40);
            this.scPanel.Name = "scPanel";
            // 
            // scPanel.Panel1
            // 
            this.scPanel.Panel1.Controls.Add(this.txtBusqueda);
            this.scPanel.Panel1.Controls.Add(this.lstProfesores);
            this.scPanel.Panel1.Controls.Add(this.groupBox1);
            // 
            // scPanel.Panel2
            // 
            this.scPanel.Panel2.Controls.Add(this.swReside);
            this.scPanel.Panel2.Controls.Add(this.label8);
            this.scPanel.Panel2.Controls.Add(this.txtApellido);
            this.scPanel.Panel2.Controls.Add(this.label7);
            this.scPanel.Panel2.Controls.Add(this.cbTipoId);
            this.scPanel.Panel2.Controls.Add(this.label6);
            this.scPanel.Panel2.Controls.Add(this.label2);
            this.scPanel.Panel2.Controls.Add(this.txtNombre);
            this.scPanel.Panel2.Controls.Add(this.txtCedula);
            this.scPanel.Panel2.Controls.Add(this.txtDireccion);
            this.scPanel.Panel2.Controls.Add(this.label1);
            this.scPanel.Panel2.Controls.Add(this.label4);
            this.scPanel.Panel2.Controls.Add(this.label3);
            this.scPanel.Panel2.Controls.Add(this.txtTelefono);
            this.scPanel.Panel2.Controls.Add(this.txtCorreo);
            this.scPanel.Panel2.Controls.Add(this.label5);
            this.scPanel.Panel2.Enabled = false;
            this.scPanel.Size = new System.Drawing.Size(800, 379);
            this.scPanel.SplitterDistance = 266;
            this.scPanel.TabIndex = 2;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(3, 47);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(258, 20);
            this.txtBusqueda.TabIndex = 6;
            // 
            // lstProfesores
            // 
            this.lstProfesores.DataSource = this.srcProfesores;
            this.lstProfesores.FormattingEnabled = true;
            this.lstProfesores.Location = new System.Drawing.Point(3, 71);
            this.lstProfesores.Name = "lstProfesores";
            this.lstProfesores.Size = new System.Drawing.Size(258, 303);
            this.lstProfesores.TabIndex = 5;
            this.lstProfesores.DoubleClick += new System.EventHandler(this.lstProfesores_DoubleClick);
            // 
            // srcProfesores
            // 
            this.srcProfesores.DataSource = typeof(BeHerktSolutions.Model.Profesor);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbApellido);
            this.groupBox1.Controls.Add(this.RbIdentificacion);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 41);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros de Búsqueda";
            // 
            // RbApellido
            // 
            this.RbApellido.AutoSize = true;
            this.RbApellido.Location = new System.Drawing.Point(190, 18);
            this.RbApellido.Name = "RbApellido";
            this.RbApellido.Size = new System.Drawing.Size(62, 17);
            this.RbApellido.TabIndex = 1;
            this.RbApellido.TabStop = true;
            this.RbApellido.Text = "Apellido";
            this.RbApellido.UseVisualStyleBackColor = true;
            // 
            // RbIdentificacion
            // 
            this.RbIdentificacion.AutoSize = true;
            this.RbIdentificacion.Location = new System.Drawing.Point(7, 18);
            this.RbIdentificacion.Name = "RbIdentificacion";
            this.RbIdentificacion.Size = new System.Drawing.Size(88, 17);
            this.RbIdentificacion.TabIndex = 0;
            this.RbIdentificacion.TabStop = true;
            this.RbIdentificacion.Text = "Identificación";
            this.RbIdentificacion.UseVisualStyleBackColor = true;
            // 
            // swReside
            // 
            this.swReside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.swReside.BorderRadius = 0;
            this.swReside.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swReside.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.swReside.Location = new System.Drawing.Point(427, 282);
            this.swReside.Name = "swReside";
            this.swReside.Oncolor = System.Drawing.Color.SeaGreen;
            this.swReside.Onoffcolor = System.Drawing.Color.DarkGray;
            this.swReside.Size = new System.Drawing.Size(51, 19);
            this.swReside.TabIndex = 43;
            this.swReside.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.swReside.Value = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "RESIDENTE";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(355, 142);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 20);
            this.txtApellido.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "APELLIDO";
            // 
            // cbTipoId
            // 
            this.cbTipoId.DataSource = this.srcTipoId;
            this.cbTipoId.DisplayMember = "Descripcion";
            this.cbTipoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTipoId.FormattingEnabled = true;
            this.cbTipoId.Location = new System.Drawing.Point(355, 72);
            this.cbTipoId.Name = "cbTipoId";
            this.cbTipoId.Size = new System.Drawing.Size(160, 21);
            this.cbTipoId.TabIndex = 38;
            this.cbTipoId.TabStop = false;
            // 
            // srcTipoId
            // 
            this.srcTipoId.DataSource = typeof(BeHerktSolutions.Model.TipoId);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "TIPO ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 30;
            this.txtNombre.TabStop = false;
            // 
            // txtCedula
            // 
            this.txtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedula.Location = new System.Drawing.Point(107, 72);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ShortcutsEnabled = false;
            this.txtCedula.Size = new System.Drawing.Size(160, 20);
            this.txtCedula.TabIndex = 28;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(107, 282);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(160, 20);
            this.txtDireccion.TabIndex = 32;
            this.txtDireccion.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "IDENTIFICACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "TELEFONO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "DIRECCION";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(355, 212);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(160, 20);
            this.txtTelefono.TabIndex = 34;
            this.txtTelefono.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(107, 212);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(160, 20);
            this.txtCorreo.TabIndex = 36;
            this.txtCorreo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "CORREO";
            // 
            // MantenedorProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.scPanel);
            this.Controls.Add(this.mnOpciones);
            this.Name = "MantenedorProfesor";
            this.Text = "MantenedorProfesor";
            this.mnOpciones.ResumeLayout(false);
            this.mnOpciones.PerformLayout();
            this.scPanel.Panel1.ResumeLayout(false);
            this.scPanel.Panel1.PerformLayout();
            this.scPanel.Panel2.ResumeLayout(false);
            this.scPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPanel)).EndInit();
            this.scPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.srcProfesores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcTipoId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnOpciones;
        private System.Windows.Forms.ToolStripMenuItem MiNuevo;
        private System.Windows.Forms.ToolStripMenuItem MiConsultar;
        private System.Windows.Forms.ToolStripMenuItem MiGuardar;
        private System.Windows.Forms.ToolStripMenuItem MiEstado;
        private System.Windows.Forms.SplitContainer scPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbApellido;
        private System.Windows.Forms.RadioButton RbIdentificacion;
        private System.Windows.Forms.ListBox lstProfesores;
        private System.Windows.Forms.BindingSource srcProfesores;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuSwitch swReside;
        private System.Windows.Forms.BindingSource srcTipoId;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}