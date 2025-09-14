using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Ventas.Data.Models
{
    public class DetallesModel
    {
        public int ID_Detalles { get; set; }
        public int ID_Articulo { get; set; }
        public int ID_Ventas { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
