using System;
using Coatza_Reporta.Utilidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Coatza_Reporta.Forms
{
    public partial class Inicio : Form
    {
        DashboardHelper dashboard = new DashboardHelper();

        public Inicio()
        {
            InitializeComponent();
        }

        private void CargarGrafica()
        {
            try
            {
                DataTable dt = dashboard.ObtenerDatos();
                chartTipos.Series.Clear();
                chartTipos.Legends.Clear();

                Series serie = new Series();
                serie.ChartType = SeriesChartType.Bar;
                serie.IsValueShownAsLabel = true;
                serie["PointWidth"] = "0.4";
                chartTipos.ChartAreas[0].AxisX.Interval = 1;
                var grupos = dt.AsEnumerable().GroupBy(r => r["Tipo"].ToString());

                foreach (var grupo in grupos)
                {
                    serie.Points.AddXY(grupo.Key, grupo.Count());
                }

                chartTipos.Series.Add(serie);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en gráfica:\n" + ex.Message);
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            try
            {
                timerHora.Start();

                lblPendientes.Text = dashboard.ContarPendientes().ToString();
                lblEn_Curso.Text = dashboard.ContarEn_Curso().ToString();
                lblTotal.Text = dashboard.ReportesTotal().ToString();
                lblHoy.Text = dashboard.ReportesHoy().ToString();

                CargarGrafica();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Dashboard:\n" + ex.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
            this.Hide();
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            Servidor servidor = new Servidor();
            servidor.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss \n tt");
        }
    }
}