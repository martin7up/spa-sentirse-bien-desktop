using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_2024_Parte2.Clases
{
    class InformePorFecha
    {
        public string Fecha { get; set; } 
        public int PagosDebito { get; set; }
        public int PagosTransferencia { get; set; }
        public int PagosCredito { get; set; }
        public int PagosEfectivo { get; set; }
    }
}
