namespace Proyecto
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccampaña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmulti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cplataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccompañia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cimagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCompañia = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rdbFisico = new System.Windows.Forms.RadioButton();
            this.rdbDigital = new System.Windows.Forms.RadioButton();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblComillas = new System.Windows.Forms.Label();
            this.lblRutaImagen = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbCampaña = new System.Windows.Forms.ComboBox();
            this.cmbMulti = new System.Windows.Forms.ComboBox();
            this.cmbEdad = new System.Windows.Forms.ComboBox();
            this.cmbPlataforma = new System.Windows.Forms.ComboBox();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblVideojuegos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cnombre,
            this.Ccampaña,
            this.Cmulti,
            this.Ctipo,
            this.Cplataforma,
            this.Cedad,
            this.Ccompañia,
            this.Cimagen});
            this.dgvJuegos.Location = new System.Drawing.Point(15, 538);
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.ReadOnly = true;
            this.dgvJuegos.Size = new System.Drawing.Size(1389, 191);
            this.dgvJuegos.TabIndex = 0;
            this.dgvJuegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJuegos_CellContentClick);
            // 
            // Cnombre
            // 
            this.Cnombre.HeaderText = "Nombre del juego";
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.ReadOnly = true;
            this.Cnombre.Width = 190;
            // 
            // Ccampaña
            // 
            this.Ccampaña.HeaderText = "Campaña cooperativa";
            this.Ccampaña.Name = "Ccampaña";
            this.Ccampaña.ReadOnly = true;
            this.Ccampaña.Width = 180;
            // 
            // Cmulti
            // 
            this.Cmulti.HeaderText = "Multijugador";
            this.Cmulti.Name = "Cmulti";
            this.Cmulti.ReadOnly = true;
            // 
            // Ctipo
            // 
            this.Ctipo.HeaderText = "Tipo de juego";
            this.Ctipo.Name = "Ctipo";
            this.Ctipo.ReadOnly = true;
            this.Ctipo.Width = 190;
            // 
            // Cplataforma
            // 
            this.Cplataforma.HeaderText = "Plataforma";
            this.Cplataforma.Name = "Cplataforma";
            this.Cplataforma.ReadOnly = true;
            this.Cplataforma.Width = 190;
            // 
            // Cedad
            // 
            this.Cedad.HeaderText = "Restriccion";
            this.Cedad.Name = "Cedad";
            this.Cedad.ReadOnly = true;
            // 
            // Ccompañia
            // 
            this.Ccompañia.HeaderText = "Compañia";
            this.Ccompañia.Name = "Ccompañia";
            this.Ccompañia.ReadOnly = true;
            this.Ccompañia.Width = 190;
            // 
            // Cimagen
            // 
            this.Cimagen.HeaderText = "Imagen";
            this.Cimagen.Name = "Cimagen";
            this.Cimagen.ReadOnly = true;
            this.Cimagen.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(81, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(60, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plataforma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(1118, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de juego";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(798, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "Multijugador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Fuchsia;
            this.label5.Location = new System.Drawing.Point(349, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 43);
            this.label5.TabIndex = 5;
            this.label5.Text = "Campaña cooperativa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Fuchsia;
            this.label6.Location = new System.Drawing.Point(814, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 43);
            this.label6.TabIndex = 6;
            this.label6.Text = "Compañia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Fuchsia;
            this.label7.Location = new System.Drawing.Point(368, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 43);
            this.label7.TabIndex = 7;
            this.label7.Text = "Restriccion de edad";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(68, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 29);
            this.txtNombre.TabIndex = 11;
            // 
            // txtCompañia
            // 
            this.txtCompañia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompañia.Location = new System.Drawing.Point(831, 176);
            this.txtCompañia.Name = "txtCompañia";
            this.txtCompañia.Size = new System.Drawing.Size(130, 29);
            this.txtCompañia.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MistyRose;
            this.btnAgregar.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.Location = new System.Drawing.Point(24, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(232, 79);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.MistyRose;
            this.btnConsultar.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnConsultar.Location = new System.Drawing.Point(303, 15);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(232, 79);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.MistyRose;
            this.btnBorrar.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrar.Location = new System.Drawing.Point(871, 15);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(232, 77);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.Location = new System.Drawing.Point(1146, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(232, 77);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rdbFisico
            // 
            this.rdbFisico.AutoSize = true;
            this.rdbFisico.BackColor = System.Drawing.Color.Transparent;
            this.rdbFisico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdbFisico.BackgroundImage")));
            this.rdbFisico.Checked = true;
            this.rdbFisico.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFisico.ForeColor = System.Drawing.Color.Black;
            this.rdbFisico.Location = new System.Drawing.Point(1143, 66);
            this.rdbFisico.Name = "rdbFisico";
            this.rdbFisico.Size = new System.Drawing.Size(81, 23);
            this.rdbFisico.TabIndex = 26;
            this.rdbFisico.TabStop = true;
            this.rdbFisico.Text = "Fisico";
            this.rdbFisico.UseVisualStyleBackColor = false;
            // 
            // rdbDigital
            // 
            this.rdbDigital.AutoSize = true;
            this.rdbDigital.BackColor = System.Drawing.Color.Transparent;
            this.rdbDigital.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdbDigital.BackgroundImage")));
            this.rdbDigital.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDigital.ForeColor = System.Drawing.Color.Black;
            this.rdbDigital.Location = new System.Drawing.Point(1240, 66);
            this.rdbDigital.Name = "rdbDigital";
            this.rdbDigital.Size = new System.Drawing.Size(90, 23);
            this.rdbDigital.TabIndex = 27;
            this.rdbDigital.Text = "Digital";
            this.rdbDigital.UseVisualStyleBackColor = false;
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.Transparent;
            this.grpDatos.Controls.Add(this.lblComillas);
            this.grpDatos.Controls.Add(this.lblRutaImagen);
            this.grpDatos.Controls.Add(this.btnBuscar);
            this.grpDatos.Controls.Add(this.pictureBox1);
            this.grpDatos.Controls.Add(this.cmbCampaña);
            this.grpDatos.Controls.Add(this.cmbMulti);
            this.grpDatos.Controls.Add(this.cmbEdad);
            this.grpDatos.Controls.Add(this.cmbPlataforma);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.rdbDigital);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.rdbFisico);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtCompañia);
            this.grpDatos.ForeColor = System.Drawing.Color.Violet;
            this.grpDatos.Location = new System.Drawing.Point(15, 93);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(1389, 233);
            this.grpDatos.TabIndex = 28;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            this.grpDatos.Enter += new System.EventHandler(this.grpDatos_Enter);
            // 
            // lblComillas
            // 
            this.lblComillas.AutoSize = true;
            this.lblComillas.Location = new System.Drawing.Point(1317, 151);
            this.lblComillas.Name = "lblComillas";
            this.lblComillas.Size = new System.Drawing.Size(12, 13);
            this.lblComillas.TabIndex = 32;
            this.lblComillas.Text = "\"";
            // 
            // lblRutaImagen
            // 
            this.lblRutaImagen.AutoSize = true;
            this.lblRutaImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaImagen.Location = new System.Drawing.Point(1328, 156);
            this.lblRutaImagen.Name = "lblRutaImagen";
            this.lblRutaImagen.Size = new System.Drawing.Size(37, 7);
            this.lblRutaImagen.TabIndex = 31;
            this.lblRutaImagen.Text = "Ubicacion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1327, 111);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 22);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "...";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1075, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 116);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // cmbCampaña
            // 
            this.cmbCampaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCampaña.FormattingEnabled = true;
            this.cmbCampaña.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbCampaña.Location = new System.Drawing.Point(423, 70);
            this.cmbCampaña.Name = "cmbCampaña";
            this.cmbCampaña.Size = new System.Drawing.Size(157, 32);
            this.cmbCampaña.TabIndex = 30;
            // 
            // cmbMulti
            // 
            this.cmbMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMulti.FormattingEnabled = true;
            this.cmbMulti.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbMulti.Location = new System.Drawing.Point(831, 70);
            this.cmbMulti.Name = "cmbMulti";
            this.cmbMulti.Size = new System.Drawing.Size(130, 32);
            this.cmbMulti.TabIndex = 29;
            // 
            // cmbEdad
            // 
            this.cmbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdad.FormattingEnabled = true;
            this.cmbEdad.Items.AddRange(new object[] {
            "+3",
            "+7",
            "+12",
            "+16",
            "+18"});
            this.cmbEdad.Location = new System.Drawing.Point(423, 176);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(157, 32);
            this.cmbEdad.TabIndex = 28;
            // 
            // cmbPlataforma
            // 
            this.cmbPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlataforma.FormattingEnabled = true;
            this.cmbPlataforma.Items.AddRange(new object[] {
            "Pc",
            "Xbox One",
            "Xbox 360",
            "Play Station 4",
            "Play Station 3",
            "Nintendo Switch",
            "Wii U"});
            this.cmbPlataforma.Location = new System.Drawing.Point(75, 176);
            this.cmbPlataforma.Name = "cmbPlataforma";
            this.cmbPlataforma.Size = new System.Drawing.Size(141, 32);
            this.cmbPlataforma.TabIndex = 26;
            // 
            // grpBotones
            // 
            this.grpBotones.BackColor = System.Drawing.Color.Transparent;
            this.grpBotones.Controls.Add(this.btnActualizar);
            this.grpBotones.Controls.Add(this.btnAgregar);
            this.grpBotones.Controls.Add(this.btnConsultar);
            this.grpBotones.Controls.Add(this.btnSalir);
            this.grpBotones.Controls.Add(this.btnBorrar);
            this.grpBotones.ForeColor = System.Drawing.Color.Violet;
            this.grpBotones.Location = new System.Drawing.Point(12, 346);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Size = new System.Drawing.Size(1390, 116);
            this.grpBotones.TabIndex = 28;
            this.grpBotones.TabStop = false;
            this.grpBotones.Text = "Opciones";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MistyRose;
            this.btnActualizar.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnActualizar.Location = new System.Drawing.Point(583, 15);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(232, 77);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar Juego";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblVideojuegos
            // 
            this.lblVideojuegos.AutoSize = true;
            this.lblVideojuegos.BackColor = System.Drawing.Color.Transparent;
            this.lblVideojuegos.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideojuegos.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblVideojuegos.Location = new System.Drawing.Point(458, 26);
            this.lblVideojuegos.Name = "lblVideojuegos";
            this.lblVideojuegos.Size = new System.Drawing.Size(553, 42);
            this.lblVideojuegos.TabIndex = 27;
            this.lblVideojuegos.Text = "BIBLIOTECA DE VIDEOJUEGOS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(29, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 40);
            this.label8.TabIndex = 29;
            this.label8.Text = "Juegos registrados:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Proyecto.Properties.Resources.pandasecurity_MC_female_gamers;
            this.ClientSize = new System.Drawing.Size(1424, 741);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblVideojuegos);
            this.Controls.Add(this.grpBotones);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.dgvJuegos);
            this.Name = "Form3";
            this.Text = "Videojuegos";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJuegos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCompañia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rdbFisico;
        private System.Windows.Forms.RadioButton rdbDigital;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.ComboBox cmbEdad;
        private System.Windows.Forms.ComboBox cmbPlataforma;
        private System.Windows.Forms.ComboBox cmbCampaña;
        private System.Windows.Forms.ComboBox cmbMulti;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblRutaImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccampaña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmulti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cplataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccompañia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cimagen;
        private System.Windows.Forms.Label lblComillas;
        private System.Windows.Forms.Label lblVideojuegos;
        private System.Windows.Forms.Label label8;
    }
}