using ClosedXML.Excel;
using Coatza_Reporta.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coatza_Reporta.Forms
{
    public partial class Servidor : Form
    {
        public Servidor()
        {
            InitializeComponent();
        }

        private void Servidor_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            ExcelServicio excel = new ExcelServicio();
            dgvReportes.DataSource = excel.LeerReportes();

            cmbTipo.Items.Clear();
            cmbEstado.Items.Clear();

            DataGridViewComboBoxColumn estado = new DataGridViewComboBoxColumn();
            estado.DataPropertyName = "Estado";
            estado.HeaderText = "Estado";
            estado.Name = "Estado";
            estado.Items.Add("Pendiente");
            estado.Items.Add("En Curso");
            estado.Items.Add("Resuelto");
            int indice = dgvReportes.Columns["Estado"].Index;
            dgvReportes.Columns.Remove("Estado");
            dgvReportes.Columns.Insert(indice, estado);
            dgvReportes.ReadOnly = false;
            dgvReportes.EditMode = DataGridViewEditMode.EditOnEnter;

            foreach (DataGridViewColumn columna in dgvReportes.Columns)
            {
                if (columna.Name != "Estado")
                {
                    columna.ReadOnly = true;
                }
                else
                {
                    columna.ReadOnly = false;
                }
            }

            cmbTipo.Items.Add("Todos");
            cmbTipo.Items.Add("Alumbrado");
            cmbTipo.Items.Add("Bache");
            cmbTipo.Items.Add("Basura");
            cmbTipo.Items.Add("Contaminación");
            cmbTipo.Items.Add("Drenaje");
            cmbTipo.Items.Add("Fuga");
            cmbTipo.Items.Add("Obra Pública");
            cmbTipo.Items.Add("Obstrucción");
            cmbTipo.Items.Add("Ruido");
            cmbTipo.Items.Add("Seguridad");
            cmbTipo.Items.Add("Semáforo");
            cmbTipo.SelectedIndex = 0;

            cmbEstado.Items.Add("Todos");
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("En Curso");
            cmbEstado.Items.Add("Resuelto");
            cmbEstado.SelectedIndex = 0;

            dgvReportes.CurrentCellDirtyStateChanged += dgvReportes_CurrentCellDirtyStateChanged;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dgvReportes.DataSource;
                string tipo = cmbTipo.Text;
                string estado = cmbEstado.Text;
                string fecha = dtpFecha.Value.ToShortDateString();
                string filtro = "";

                filtro = $"Convert(Fecha, 'System.String') LIKE '%{fecha}%'";
                if (tipo != "Todos")
                {
                    filtro += $" AND Tipo = '{tipo}'";
                }

                if (estado != "Todos")
                {
                    filtro += $" AND Estado = '{estado}'";
                }

                dt.DefaultView.RowFilter = filtro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Filtrar los Reportes." + ex.Message);
            }
        }

        private void btnVer_Reporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReportes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un Reporte");
                    return;
                }

                string rutaPDF = dgvReportes.CurrentRow.Cells["ReportesPDF"].Value.ToString();

                if (File.Exists(rutaPDF))
                {
                    Process.Start(new ProcessStartInfo(rutaPDF)
                    {
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("No se Encontró el Archivo PDF");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Abrir el PDF." + ex.Message);
            }
        }

        private void btnVer_Excel_Click(object sender, EventArgs e)
        {
            try
            {
                string carpetaExcel = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CoatzaReporta","Archivos");
                string rutaExcel = Path.Combine(carpetaExcel,"Reportes.xlsx");
                if (!File.Exists(rutaExcel))
                {
                    MessageBox.Show("No se Encontró el Archivo Excel.\n\n" + rutaExcel,"Archivo no Encontrado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                Process.Start(new ProcessStartInfo()
                {
                    FileName = rutaExcel,UseShellExecute = true
                });
                MessageBox.Show("Cierre el archivo Excel para poder continuar.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Abrir el Excel.\n\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error
                );
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string carpetaExcel = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CoatzaReporta","Archivos");
                string ruta = Path.Combine(carpetaExcel,"Reportes.xlsx");
                if (!File.Exists(ruta))
                {
                    MessageBox.Show("No se Encontró el Archivo Excel.\n\n" + ruta,"Archivo no Encontrado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                using (var wb = new XLWorkbook(ruta))
                {
                    var ws = wb.Worksheet(1);
                    for (int i = 0; i < dgvReportes.Rows.Count; i++)
                    {
                        if (dgvReportes.Rows[i].Cells["Estado"].Value != null)
                        {
                            ws.Cell(i + 2, 11).Value = dgvReportes.Rows[i].Cells["Estado"].Value.ToString();
                        }
                    }

                    wb.Save();
                }

                MessageBox.Show("Estados Actualizados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Asegúrese de tener el Excel Cerrado.\n\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgvReportes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvReportes.IsCurrentCellDirty)
            {
                dgvReportes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void Servidor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
