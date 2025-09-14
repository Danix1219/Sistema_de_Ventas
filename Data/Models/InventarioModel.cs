using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Ventas.Data.Models
{
    public class InventarioModel
    {
        public int ID_Articulo { get; set; }
        public string Nombre_Articulo { get; set; }
        public string Codigo_Barras { get; set; }
        public decimal Precio_Unitario { get; set; }
        public int Stock { get; set; }
    }
}
