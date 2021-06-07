using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.View
{
    public partial class ViewReporteIngresoCancha : Form
    {
        private string connectionString = "Server=DESKTOP-U4PFR0A;Database=PROYECTO_TORNEOS;User Id=Rogelio;Password=12345;";

        public ViewReporteIngresoCancha()
        {
            InitializeComponent();
        }

        private void loadData(string query)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter sqll = new SqlDataAdapter(query, connection);
                    DataTable data = new DataTable();

                    sqll.Fill(data);

                    listIngresosCancha.DataSource = data;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al obtener los registros");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fechaInicio = $"{Convert.ToDateTime(txtFechaInicio.Text).Year}/{Convert.ToDateTime(txtFechaInicio.Text).Month}/{Convert.ToDateTime(txtFechaInicio.Text).Day}";
            string fechaFinal = $"{Convert.ToDateTime(txtFechaFinal.Text).Year}/{Convert.ToDateTime(txtFechaFinal.Text).Month}/{Convert.ToDateTime(txtFechaFinal.Text).Day}";

            string query = $"EXEC SP_REPORTE_INGRESO_CANCHA '{fechaInicio}', '{fechaFinal}'";
            loadData(query);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void listIngresosCancha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
