using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminitracionDeTorneosP.Database;


namespace AdminitracionDeTorneosP.View
{
    public partial class Reporte_Jugadores : Form
    {
        public Reporte_Jugadores_BD JugadoressContext = new Reporte_Jugadores_BD();
        public Reporte_Jugadores()
        {
            InitializeComponent();
            MostrarJugadores();
        }
        public void MostrarJugadores()
        {
            Listado_Jugadores.DataSource = JugadoressContext.Mostrar_Jugadores();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Reporte_Jugadores_Load(object sender, EventArgs e)
        {

        }
    }
}
