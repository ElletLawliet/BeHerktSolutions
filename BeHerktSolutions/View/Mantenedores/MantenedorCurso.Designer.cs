namespace BeHerktSolutions.View.Mantenedores
{
    partial class MantenedorCurso
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BbiNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.BbiBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.BbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.BbiEstado = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPageCategory2 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.spcContenido = new System.Windows.Forms.SplitContainer();
            this.LstCursos = new DevExpress.XtraEditors.ListBoxControl();
            this.srcCursos = new System.Windows.Forms.BindingSource(this.components);
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.RbDescripcion = new System.Windows.Forms.RadioButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.TxtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.TxtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.TxtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcContenido)).BeginInit();
            this.spcContenido.Panel1.SuspendLayout();
            this.spcContenido.Panel2.SuspendLayout();
            this.spcContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LstCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BbiNuevo,
            this.BbiBuscar,
            this.BbiGuardar,
            this.BbiEstado,
            this.barButtonGroup1,
            this.barButtonGroup2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 119);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // BbiNuevo
            // 
            this.BbiNuevo.Caption = "NUEVO";
            this.BbiNuevo.Id = 2;
            this.BbiNuevo.ImageOptions.LargeImage = global::BeHerktSolutions.Properties.Resources.additem_32x321;
            this.BbiNuevo.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.BbiNuevo.Name = "BbiNuevo";
            this.BbiNuevo.ShortcutKeyDisplayString = "F1";
            this.BbiNuevo.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // BbiBuscar
            // 
            this.BbiBuscar.Caption = "BUSCAR";
            this.BbiBuscar.Id = 3;
            this.BbiBuscar.ImageOptions.LargeImage = global::BeHerktSolutions.Properties.Resources.lookup_reference_32x321;
            this.BbiBuscar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.BbiBuscar.Name = "BbiBuscar";
            this.BbiBuscar.ShortcutKeyDisplayString = "F2";
            this.BbiBuscar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // BbiGuardar
            // 
            this.BbiGuardar.Caption = "GUARDAR";
            this.BbiGuardar.Id = 4;
            this.BbiGuardar.ImageOptions.LargeImage = global::BeHerktSolutions.Properties.Resources.save_32x324;
            this.BbiGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.BbiGuardar.Name = "BbiGuardar";
            this.BbiGuardar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // BbiEstado
            // 
            this.BbiEstado.Caption = "DESHABILITAR";
            this.BbiEstado.Id = 5;
            this.BbiEstado.ImageOptions.LargeImage = global::BeHerktSolutions.Properties.Resources.cancel_32x321;
            this.BbiEstado.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4);
            this.BbiEstado.Name = "BbiEstado";
            this.BbiEstado.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 6;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Caption = "barButtonGroup2";
            this.barButtonGroup2.Id = 10;
            this.barButtonGroup2.Name = "barButtonGroup2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Image = global::BeHerktSolutions.Properties.Resources.morefunctions_16x16;
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiNuevo);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiBuscar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BbiEstado);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "ACCIONES";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Color = System.Drawing.SystemColors.HighlightText;
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPageCategory2
            // 
            this.ribbonPageCategory2.Name = "ribbonPageCategory2";
            this.ribbonPageCategory2.Text = "ribbonPageCategory2";
            // 
            // spcContenido
            // 
            this.spcContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcContenido.Location = new System.Drawing.Point(0, 120);
            this.spcContenido.Name = "spcContenido";
            // 
            // spcContenido.Panel1
            // 
            this.spcContenido.Panel1.Controls.Add(this.LstCursos);
            this.spcContenido.Panel1.Controls.Add(this.rbCodigo);
            this.spcContenido.Panel1.Controls.Add(this.textEdit1);
            this.spcContenido.Panel1.Controls.Add(this.RbDescripcion);
            this.spcContenido.Panel1.Controls.Add(this.radioGroup1);
            // 
            // spcContenido.Panel2
            // 
            this.spcContenido.Panel2.Controls.Add(this.TxtPrecio);
            this.spcContenido.Panel2.Controls.Add(this.TxtDescripcion);
            this.spcContenido.Panel2.Controls.Add(this.TxtCodigo);
            this.spcContenido.Panel2.Controls.Add(this.labelControl3);
            this.spcContenido.Panel2.Controls.Add(this.labelControl2);
            this.spcContenido.Panel2.Controls.Add(this.labelControl1);
            this.spcContenido.Size = new System.Drawing.Size(800, 330);
            this.spcContenido.SplitterDistance = 252;
            this.spcContenido.TabIndex = 11;
            // 
            // LstCursos
            // 
            this.LstCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstCursos.Cursor = System.Windows.Forms.Cursors.Default;
            this.LstCursos.DataSource = this.srcCursos;
            this.LstCursos.DisplayMember = "Descripcion";
            this.LstCursos.HorizontalScrollbar = true;
            this.LstCursos.Location = new System.Drawing.Point(4, 72);
            this.LstCursos.Name = "LstCursos";
            this.LstCursos.Size = new System.Drawing.Size(245, 253);
            this.LstCursos.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.LstCursos.TabIndex = 4;
            // 
            // srcCursos
            // 
            this.srcCursos.DataSource = typeof(BeHerktSolutions.Model.TipoCurso);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(185, 18);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbCodigo.TabIndex = 3;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(3, 48);
            this.textEdit1.MenuManager = this.ribbonControl1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(246, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // RbDescripcion
            // 
            this.RbDescripcion.AutoSize = true;
            this.RbDescripcion.Location = new System.Drawing.Point(14, 18);
            this.RbDescripcion.Name = "RbDescripcion";
            this.RbDescripcion.Size = new System.Drawing.Size(81, 17);
            this.RbDescripcion.TabIndex = 1;
            this.RbDescripcion.TabStop = true;
            this.RbDescripcion.Text = "Descripcion";
            this.RbDescripcion.UseVisualStyleBackColor = true;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioGroup1.Location = new System.Drawing.Point(3, 7);
            this.radioGroup1.MenuManager = this.ribbonControl1;
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(246, 38);
            this.radioGroup1.TabIndex = 0;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(213, 224);
            this.TxtPrecio.MenuManager = this.ribbonControl1;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(170, 20);
            this.TxtPrecio.TabIndex = 5;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(213, 145);
            this.TxtDescripcion.MenuManager = this.ribbonControl1;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(170, 20);
            this.TxtDescripcion.TabIndex = 4;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(213, 72);
            this.TxtCodigo.MenuManager = this.ribbonControl1;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(170, 20);
            this.TxtCodigo.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.Location = new System.Drawing.Point(48, 227);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "PRECIO";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl2.Location = new System.Drawing.Point(48, 148);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "DESCRIPCION";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Location = new System.Drawing.Point(48, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CODIGO";
            // 
            // MantenedorCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spcContenido);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MantenedorCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenedorCurso";
            this.Load += new System.EventHandler(this.MantenedorCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.spcContenido.Panel1.ResumeLayout(false);
            this.spcContenido.Panel1.PerformLayout();
            this.spcContenido.Panel2.ResumeLayout(false);
            this.spcContenido.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcContenido)).EndInit();
            this.spcContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LstCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BbiNuevo;
        private DevExpress.XtraBars.BarButtonItem BbiBuscar;
        private DevExpress.XtraBars.BarButtonItem BbiGuardar;
        private DevExpress.XtraBars.BarButtonItem BbiEstado;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory2;
        private System.Windows.Forms.SplitContainer spcContenido;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.RadioButton RbDescripcion;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.RadioButton rbCodigo;
        private DevExpress.XtraEditors.ListBoxControl LstCursos;
        private System.Windows.Forms.BindingSource srcCursos;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtPrecio;
        private DevExpress.XtraEditors.TextEdit TxtDescripcion;
        private DevExpress.XtraEditors.TextEdit TxtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}