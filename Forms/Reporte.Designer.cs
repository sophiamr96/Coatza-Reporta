namespace Coatza_Reporta.Forms
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnUbicar = new System.Windows.Forms.Button();
            this.btnCrear_Reporte = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtReferencias = new System.Windows.Forms.TextBox();
            this.txtExterior = new System.Windows.Forms.TextBox();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnBase = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.groupBoxCelular = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSubir_Captura = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbColonia = new System.Windows.Forms.ComboBox();
            this.cmbCalle = new System.Windows.Forms.ComboBox();
            this.cmbCalle_Esq = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.groupBoxCelular.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.Color.White;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(192, 88);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(640, 624);
            this.webView21.TabIndex = 0;
            this.webView21.Visible = false;
            this.webView21.ZoomFactor = 1D;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(416, 651);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(207, 24);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnUbicar
            // 
            this.btnUbicar.BackColor = System.Drawing.Color.Transparent;
            this.btnUbicar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUbicar.FlatAppearance.BorderSize = 0;
            this.btnUbicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnUbicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnUbicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicar.Location = new System.Drawing.Point(928, 579);
            this.btnUbicar.Name = "btnUbicar";
            this.btnUbicar.Size = new System.Drawing.Size(207, 24);
            this.btnUbicar.TabIndex = 4;
            this.btnUbicar.UseVisualStyleBackColor = false;
            this.btnUbicar.Click += new System.EventHandler(this.btnUbicar_Click);
            // 
            // btnCrear_Reporte
            // 
            this.btnCrear_Reporte.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrear_Reporte.FlatAppearance.BorderSize = 0;
            this.btnCrear_Reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnCrear_Reporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnCrear_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear_Reporte.Location = new System.Drawing.Point(928, 651);
            this.btnCrear_Reporte.Name = "btnCrear_Reporte";
            this.btnCrear_Reporte.Size = new System.Drawing.Size(207, 24);
            this.btnCrear_Reporte.TabIndex = 5;
            this.btnCrear_Reporte.UseVisualStyleBackColor = false;
            this.btnCrear_Reporte.Click += new System.EventHandler(this.btnCrear_Reporte_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.txtNombre.Location = new System.Drawing.Point(209, 579);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.White;
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.txtCelular.Location = new System.Drawing.Point(527, 579);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(282, 22);
            this.txtCelular.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.txtDescripcion.Location = new System.Drawing.Point(527, 275);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(282, 93);
            this.txtDescripcion.TabIndex = 11;
            // 
            // txtReferencias
            // 
            this.txtReferencias.BackColor = System.Drawing.Color.White;
            this.txtReferencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReferencias.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.txtReferencias.Location = new System.Drawing.Point(527, 417);
            this.txtReferencias.Multiline = true;
            this.txtReferencias.Name = "txtReferencias";
            this.txtReferencias.Size = new System.Drawing.Size(282, 93);
            this.txtReferencias.TabIndex = 12;
            // 
            // txtExterior
            // 
            this.txtExterior.BackColor = System.Drawing.Color.White;
            this.txtExterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExterior.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.txtExterior.Location = new System.Drawing.Point(208, 488);
            this.txtExterior.Name = "txtExterior";
            this.txtExterior.Size = new System.Drawing.Size(130, 22);
            this.txtExterior.TabIndex = 13;
            // 
            // txtPostal
            // 
            this.txtPostal.BackColor = System.Drawing.Color.White;
            this.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPostal.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.txtPostal.Location = new System.Drawing.Point(361, 488);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(130, 22);
            this.txtPostal.TabIndex = 14;
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.White;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(398, 177);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(224, 31);
            this.cmbTipo.TabIndex = 17;
            // 
            // btnBase
            // 
            this.btnBase.BackColor = System.Drawing.Color.Transparent;
            this.btnBase.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBase.FlatAppearance.BorderSize = 0;
            this.btnBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBase.Location = new System.Drawing.Point(37, 305);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(98, 85);
            this.btnBase.TabIndex = 20;
            this.btnBase.UseVisualStyleBackColor = false;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Location = new System.Drawing.Point(37, 187);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(98, 85);
            this.btnCrear.TabIndex = 21;
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Location = new System.Drawing.Point(37, 67);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(98, 85);
            this.btnInicio.TabIndex = 22;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(48, 656);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 82);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.pictureBoxImagen.Location = new System.Drawing.Point(56, 48);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(144, 176);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 24;
            this.pictureBoxImagen.TabStop = false;
            // 
            // groupBoxCelular
            // 
            this.groupBoxCelular.BackColor = System.Drawing.Color.White;
            this.groupBoxCelular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxCelular.BackgroundImage")));
            this.groupBoxCelular.Controls.Add(this.btnRegresar);
            this.groupBoxCelular.Controls.Add(this.btnSubir_Captura);
            this.groupBoxCelular.Controls.Add(this.txtImagen);
            this.groupBoxCelular.Controls.Add(this.pictureBoxImagen);
            this.groupBoxCelular.Location = new System.Drawing.Point(904, 216);
            this.groupBoxCelular.Name = "groupBoxCelular";
            this.groupBoxCelular.Size = new System.Drawing.Size(256, 336);
            this.groupBoxCelular.TabIndex = 25;
            this.groupBoxCelular.TabStop = false;
            this.groupBoxCelular.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(32, 32);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSubir_Captura
            // 
            this.btnSubir_Captura.BackColor = System.Drawing.Color.Transparent;
            this.btnSubir_Captura.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubir_Captura.FlatAppearance.BorderSize = 0;
            this.btnSubir_Captura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnSubir_Captura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(128)))), ((int)(((byte)(35)))));
            this.btnSubir_Captura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir_Captura.Location = new System.Drawing.Point(36, 288);
            this.btnSubir_Captura.Name = "btnSubir_Captura";
            this.btnSubir_Captura.Size = new System.Drawing.Size(184, 25);
            this.btnSubir_Captura.TabIndex = 26;
            this.btnSubir_Captura.UseVisualStyleBackColor = false;
            this.btnSubir_Captura.Click += new System.EventHandler(this.btnSubir_Captura_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.BackColor = System.Drawing.Color.White;
            this.txtImagen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImagen.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.txtImagen.Location = new System.Drawing.Point(32, 238);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(192, 22);
            this.txtImagen.TabIndex = 25;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbColonia
            // 
            this.cmbColonia.BackColor = System.Drawing.Color.White;
            this.cmbColonia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColonia.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.cmbColonia.FormattingEnabled = true;
            this.cmbColonia.Location = new System.Drawing.Point(207, 273);
            this.cmbColonia.Name = "cmbColonia";
            this.cmbColonia.Size = new System.Drawing.Size(283, 26);
            this.cmbColonia.TabIndex = 26;
            this.cmbColonia.SelectedIndexChanged += new System.EventHandler(this.cmbColonia_SelectedIndexChanged);
            // 
            // cmbCalle
            // 
            this.cmbCalle.BackColor = System.Drawing.Color.White;
            this.cmbCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalle.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.cmbCalle.FormattingEnabled = true;
            this.cmbCalle.Location = new System.Drawing.Point(207, 344);
            this.cmbCalle.Name = "cmbCalle";
            this.cmbCalle.Size = new System.Drawing.Size(283, 26);
            this.cmbCalle.TabIndex = 27;
            // 
            // cmbCalle_Esq
            // 
            this.cmbCalle_Esq.BackColor = System.Drawing.Color.White;
            this.cmbCalle_Esq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalle_Esq.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCalle_Esq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.cmbCalle_Esq.FormattingEnabled = true;
            this.cmbCalle_Esq.Location = new System.Drawing.Point(207, 415);
            this.cmbCalle_Esq.Name = "cmbCalle_Esq";
            this.cmbCalle_Esq.Size = new System.Drawing.Size(283, 26);
            this.cmbCalle_Esq.TabIndex = 28;
            this.cmbCalle_Esq.SelectedIndexChanged += new System.EventHandler(this.cmbCalle_Esq_SelectedIndexChanged);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 811);
            this.Controls.Add(this.groupBoxCelular);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.txtExterior);
            this.Controls.Add(this.txtReferencias);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCrear_Reporte);
            this.Controls.Add(this.btnUbicar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbColonia);
            this.Controls.Add(this.cmbCalle);
            this.Controls.Add(this.cmbCalle_Esq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Reporte";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COATZA REPORTA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reporte_FormClosing);
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.groupBoxCelular.ResumeLayout(false);
            this.groupBoxCelular.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnUbicar;
        private System.Windows.Forms.Button btnCrear_Reporte;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtReferencias;
        private System.Windows.Forms.TextBox txtExterior;
        private System.Windows.Forms.TextBox txtPostal;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.GroupBox groupBoxCelular;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSubir_Captura;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbColonia;
        private System.Windows.Forms.ComboBox cmbCalle;
        private System.Windows.Forms.ComboBox cmbCalle_Esq;
    }
}