using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminitracionDeTorneosP.Model
{
    class Usuarios
    {
		public int id { get; set; }

		public string dpi { get; set; }

		public string nombres { get; set; }

		public string apellidos { get; set; }

		public string usuario { get; set; }

		public string contrasena { get; set; }

		public string telefono { get; set; }

		public string direccion { get; set; }
		
		public string correo { get; set; }

		public string puesto { get; set; }

		public string rol { get; set; }

		public Boolean estado { get; set; }
	}
}
