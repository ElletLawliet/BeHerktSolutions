namespace BeHerktSolutions
{
    partial class loginScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtContraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUsuario.HintForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtUsuario.HintText = "INGRESE NOMBRE USUARIO";
            this.TxtUsuario.isPassword = false;
            this.TxtUsuario.LineFocusedColor = System.Drawing.Color.LightSkyBlue;
            this.TxtUsuario.LineIdleColor = System.Drawing.Color.Black;
            this.TxtUsuario.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue;
            this.TxtUsuario.LineThickness = 2;
            this.TxtUsuario.Location = new System.Drawing.Point(67, 144);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(379, 33);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtContraseña.HintForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtContraseña.HintText = "";
            this.TxtContraseña.isPassword = true;
            this.TxtContraseña.LineFocusedColor = System.Drawing.Color.LightSkyBlue;
            this.TxtContraseña.LineIdleColor = System.Drawing.Color.Black;
            this.TxtContraseña.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue;
            this.TxtContraseña.LineThickness = 2;
            this.TxtContraseña.Location = new System.Drawing.Point(67, 185);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(379, 33);
            this.TxtContraseña.TabIndex = 3;
            this.TxtContraseña.Text = "********";
            this.TxtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtContraseña.Enter += new System.EventHandler(this.TxtContraseña_Enter);
            // 
            // BtSalir
            // 
            this.BtSalir.Activecolor = System.Drawing.Color.Firebrick;
            this.BtSalir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtSalir.BorderRadius = 7;
            this.BtSalir.ButtonText = "SALIR";
            this.BtSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSalir.DisabledColor = System.Drawing.Color.Gray;
            this.BtSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.BtSalir.Iconimage = global::BeHerktSolutions.Properties.Resources.exit2;
            this.BtSalir.Iconimage_right = null;
            this.BtSalir.Iconimage_right_Selected = null;
            this.BtSalir.Iconimage_Selected = null;
            this.BtSalir.IconMarginLeft = 0;
            this.BtSalir.IconMarginRight = 0;
            this.BtSalir.IconRightVisible = true;
            this.BtSalir.IconRightZoom = 0D;
            this.BtSalir.IconVisible = true;
            this.BtSalir.IconZoom = 70D;
            this.BtSalir.IsTab = false;
            this.BtSalir.Location = new System.Drawing.Point(279, 243);
            this.BtSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Normalcolor = System.Drawing.Color.LightSkyBlue;
            this.BtSalir.OnHovercolor = System.Drawing.Color.Red;
            this.BtSalir.OnHoverTextColor = System.Drawing.Color.Black;
            this.BtSalir.selected = false;
            this.BtSalir.Size = new System.Drawing.Size(122, 48);
            this.BtSalir.TabIndex = 6;
            this.BtSalir.Text = "SALIR";
            this.BtSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtSalir.Textcolor = System.Drawing.Color.Black;
            this.BtSalir.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSalir.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // BtLogin
            // 
            this.BtLogin.Activecolor = System.Drawing.Color.Firebrick;
            this.BtLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtLogin.BorderRadius = 7;
            this.BtLogin.ButtonText = "LOGIN";
            this.BtLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BtLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtLogin.Iconimage = global::BeHerktSolutions.Properties.Resources.login;
            this.BtLogin.Iconimage_right = null;
            this.BtLogin.Iconimage_right_Selected = null;
            this.BtLogin.Iconimage_Selected = null;
            this.BtLogin.IconMarginLeft = 0;
            this.BtLogin.IconMarginRight = 0;
            this.BtLogin.IconRightVisible = true;
            this.BtLogin.IconRightZoom = 0D;
            this.BtLogin.IconVisible = true;
            this.BtLogin.IconZoom = 70D;
            this.BtLogin.IsTab = false;
            this.BtLogin.Location = new System.Drawing.Point(114, 243);
            this.BtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Normalcolor = System.Drawing.Color.LightSkyBlue;
            this.BtLogin.OnHovercolor = System.Drawing.Color.Chartreuse;
            this.BtLogin.OnHoverTextColor = System.Drawing.Color.Black;
            this.BtLogin.selected = false;
            this.BtLogin.Size = new System.Drawing.Size(122, 48);
            this.BtLogin.TabIndex = 5;
            this.BtLogin.Text = "LOGIN";
            this.BtLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtLogin.Textcolor = System.Drawing.Color.Black;
            this.BtLogin.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // logo
            // 
            this.logo.Image = global::BeHerktSolutions.Properties.Resources.Logo_beherkt;
            this.logo.Location = new System.Drawing.Point(84, 21);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(335, 107);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(502, 324);
            this.ControlBox = false;
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.BtLogin);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN [BEHERKT]";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtContraseña;
        private Bunifu.Framework.UI.BunifuFlatButton BtLogin;
        private Bunifu.Framework.UI.BunifuFlatButton BtSalir;
    }
}

