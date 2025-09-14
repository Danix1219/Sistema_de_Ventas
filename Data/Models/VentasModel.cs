using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Ventas.Data.Models
{
    public class VentasModel
    {
        public int ID_Ventas { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public decimal Total { get; set; }
    }
}
