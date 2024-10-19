using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_2024_Parte2.Clases
{
    class Factura
    {
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string FechaTurno { get; set; }
        public string HorarioDelTurno { get; set; }
        public string Precio { get; set; }

        public override string ToString()
        {
            return $"{NombreCliente} {Direccion} {FechaTurno} {HorarioDelTurno} {Precio}";
        }
    }
}
