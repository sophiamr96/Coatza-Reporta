namespace Coatza_Reporta.Forms
{
    partial class Inicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnBase = new System.Windows.Forms.Button();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.chartTipos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblEn_Curso = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblHoy = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(784, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 19;
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
            this.btnSalir.TabIndex = 27;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnInicio.TabIndex = 26;
            this.btnInicio.UseVisualStyleBackColor = false;
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
            this.btnCrear.TabIndex = 25;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
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
            this.btnBase.TabIndex = 24;
            this.btnBase.UseVisualStyleBackColor = false;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // chartTipos
            // 
            this.chartTipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea1.Name = "ChartArea1";
            this.chartTipos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTipos.Legends.Add(legend1);
            this.chartTipos.Location = new System.Drawing.Point(214, 424);
            this.chartTipos.Name = "chartTipos";
            this.chartTipos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartTipos.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTipos.Series.Add(series1);
            this.chartTipos.Size = new System.Drawing.Size(280, 252);
            this.chartTipos.TabIndex = 32;
            this.chartTipos.Text = "chart1";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.BackColor = System.Drawing.Color.Transparent;
            this.lblPendientes.Font = new System.Drawing.Font("Berlin Sans FB", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.lblPendientes.Location = new System.Drawing.Point(405, 235);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(112, 73);
            this.lblPendientes.TabIndex = 38;
            this.lblPendientes.Text = "00";
            this.lblPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEn_Curso
            // 
            this.lblEn_Curso.AutoSize = true;
            this.lblEn_Curso.BackColor = System.Drawing.Color.Transparent;
            this.lblEn_Curso.Font = new System.Drawing.Font("Berlin Sans FB", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEn_Curso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.lblEn_Curso.Location = new System.Drawing.Point(1010, 235);
            this.lblEn_Curso.Name = "lblEn_Curso";
            this.lblEn_Curso.Size = new System.Drawing.Size(112, 73);
            this.lblEn_Curso.TabIndex = 39;
            this.lblEn_Curso.Text = "00";
            this.lblEn_Curso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Berlin Sans FB", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.lblTotal.Location = new System.Drawing.Point(704, 400);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 73);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoy
            // 
            this.lblHoy.AutoSize = true;
            this.lblHoy.BackColor = System.Drawing.Color.Transparent;
            this.lblHoy.Font = new System.Drawing.Font("Berlin Sans FB", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.lblHoy.Location = new System.Drawing.Point(704, 567);
            this.lblHoy.Name = "lblHoy";
            this.lblHoy.Size = new System.Drawing.Size(112, 73);
            this.lblHoy.TabIndex = 41;
            this.lblHoy.Text = "00";
            this.lblHoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Berlin Sans FB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.lblHora.Location = new System.Drawing.Point(890, 456);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(239, 116);
            this.lblHora.TabIndex = 42;
            this.lblHora.Text = "00:00:00\r\ntt";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 811);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblHoy);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEn_Curso);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.chartTipos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COATZA REPORTA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTipos;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblEn_Curso;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblHoy;
        private System.Windows.Forms.Label lblHora;
    }
}