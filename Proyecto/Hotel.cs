using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Hotel
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string VistaGeneral { get; set; }
        public List<string> Servicios { get; set; }

        public Hotel(string nombre)  
        {
            Nombre = nombre;
            Servicios = new List<string>();
        }
    }
}
