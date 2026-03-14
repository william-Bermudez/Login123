namespace Login123
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.iniciar_seccion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.regristrate = new System.Windows.Forms.Label();
            this.mostrar_contrasena = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ingrese_contrasena = new Guna.UI2.WinForms.Guna2TextBox();
            this.ingrese_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(62, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(16, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(17, 373);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(302, 1);
            this.guna2Panel1.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(21, 457);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(302, 1);
            this.guna2Panel2.TabIndex = 8;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(168)))));
            this.label3.Location = new System.Drawing.Point(16, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // iniciar_seccion
            // 
            this.iniciar_seccion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.iniciar_seccion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.iniciar_seccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iniciar_seccion.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.iniciar_seccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.iniciar_seccion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.iniciar_seccion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.iniciar_seccion.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar_seccion.ForeColor = System.Drawing.Color.White;
            this.iniciar_seccion.Location = new System.Drawing.Point(77, 502);
            this.iniciar_seccion.Name = "iniciar_seccion";
            this.iniciar_seccion.Size = new System.Drawing.Size(181, 41);
            this.iniciar_seccion.TabIndex = 9;
            this.iniciar_seccion.Text = "Iniciar Sección ";
            this.iniciar_seccion.Click += new System.EventHandler(this.iniciar_seccion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "¿No tienes una cuenta?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // regristrate
            // 
            this.regristrate.AutoSize = true;
            this.regristrate.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regristrate.ForeColor = System.Drawing.Color.Blue;
            this.regristrate.Location = new System.Drawing.Point(209, 571);
            this.regristrate.Name = "regristrate";
            this.regristrate.Size = new System.Drawing.Size(70, 17);
            this.regristrate.TabIndex = 11;
            this.regristrate.Text = "Registrate";
            this.regristrate.Click += new System.EventHandler(this.regristrate_Click);
            // 
            // mostrar_contrasena
            // 
            this.mostrar_contrasena.AutoSize = true;
            this.mostrar_contrasena.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mostrar_contrasena.CheckedState.BorderRadius = 0;
            this.mostrar_contrasena.CheckedState.BorderThickness = 0;
            this.mostrar_contrasena.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mostrar_contrasena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mostrar_contrasena.Location = new System.Drawing.Point(159, 464);
            this.mostrar_contrasena.Name = "mostrar_contrasena";
            this.mostrar_contrasena.Size = new System.Drawing.Size(164, 24);
            this.mostrar_contrasena.TabIndex = 12;
            this.mostrar_contrasena.Text = "Mostar Contraseña";
            this.mostrar_contrasena.UncheckedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.mostrar_contrasena.UncheckedState.BorderRadius = 0;
            this.mostrar_contrasena.UncheckedState.BorderThickness = 0;
            this.mostrar_contrasena.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.mostrar_contrasena.CheckedChanged += new System.EventHandler(this.mostrar_contrasena_CheckedChanged);
            // 
            // ingrese_contrasena
            // 
            this.ingrese_contrasena.BorderThickness = 0;
            this.ingrese_contrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ingrese_contrasena.DefaultText = "";
            this.ingrese_contrasena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ingrese_contrasena.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ingrese_contrasena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ingrese_contrasena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ingrese_contrasena.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.ingrese_contrasena.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.ingrese_contrasena.ForeColor = System.Drawing.Color.Black;
            this.ingrese_contrasena.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.ingrese_contrasena.IconLeft = global::Login123.Properties.Resources.acceso;
            this.ingrese_contrasena.Location = new System.Drawing.Point(17, 412);
            this.ingrese_contrasena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ingrese_contrasena.Name = "ingrese_contrasena";
            this.ingrese_contrasena.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ingrese_contrasena.PlaceholderText = "Ingrese Su Contraseña";
            this.ingrese_contrasena.SelectedText = "";
            this.ingrese_contrasena.Size = new System.Drawing.Size(305, 55);
            this.ingrese_contrasena.TabIndex = 7;
            this.ingrese_contrasena.UseSystemPasswordChar = true;
            this.ingrese_contrasena.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // ingrese_usuario
            // 
            this.ingrese_usuario.BorderThickness = 0;
            this.ingrese_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ingrese_usuario.DefaultText = "";
            this.ingrese_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ingrese_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ingrese_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ingrese_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ingrese_usuario.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.ingrese_usuario.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.ingrese_usuario.ForeColor = System.Drawing.Color.Black;
            this.ingrese_usuario.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.ingrese_usuario.IconLeft = global::Login123.Properties.Resources.cuenta;
            this.ingrese_usuario.Location = new System.Drawing.Point(13, 328);
            this.ingrese_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ingrese_usuario.Name = "ingrese_usuario";
            this.ingrese_usuario.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ingrese_usuario.PlaceholderText = "Ingrese Su Usuario";
            this.ingrese_usuario.SelectedText = "";
            this.ingrese_usuario.Size = new System.Drawing.Size(305, 55);
            this.ingrese_usuario.TabIndex = 4;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::Login123.Properties.Resources.Adobe_Express___file_removebg_preview;
            this.guna2PictureBox2.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(40, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(239, 154);
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 608);
            this.Controls.Add(this.mostrar_contrasena);
            this.Controls.Add(this.regristrate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iniciar_seccion);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.ingrese_contrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ingrese_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox ingrese_usuario;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox ingrese_contrasena;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton iniciar_seccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label regristrate;
        private Guna.UI2.WinForms.Guna2CheckBox mostrar_contrasena;
    }
}

