using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_2024_Parte2.Clases
{
    [FirestoreData]
    internal class Turno
    {
        [FirestoreProperty]
        public string? servicio_id { get; set; }

        [FirestoreProperty]
        public string? usuario_id { get; set; }

        [FirestoreProperty]
        public Dictionary<string, long> fecha { get; set; }

        //Propiedades extras-------------------------------------------------------------------------------------------------------
        public string? id { get; set; }

        //Metodos sobreescritos----------------------------------------------------------------------------------------------------
        public override string ToString()
        {
            return $"Id del servicio solicitado : {servicio_id}\nId del cliente que solicito : {usuario_id}\nFecha : {fechaTurno().ToString("g")}";
        }

        //Metodos de clase---------------------------------------------------------------------------------------------------------
        public DateTime fechaTurno()
        {
            return DateTimeOffset.FromUnixTimeSeconds(fecha["seconds"]).UtcDateTime;
        }
    }
}
