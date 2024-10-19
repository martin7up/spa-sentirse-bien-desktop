using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_2024_Parte2.Clases
{
    [FirestoreData]
    public class Turno
    {
        [FirestoreProperty]
        public string? servicio_id { get; set; }

        [FirestoreProperty]
        public string? usuario_id { get; set; }

        [FirestoreProperty]
        public Dictionary<string, long>? fecha { get; set; }
        //AGREGAR ESTOS CAMPOS EN BASE DE DATOS FIREBASE
        [FirestoreProperty]
        public bool? is_pagado { get; set; }

        [FirestoreProperty]
        public bool? is_cancelado { get; set; }

        [FirestoreProperty]
        public string? metodo_de_pago { get; set; } //debito, efectivo, transferencia, credito >>> Un metodo de pago figura si o si pero no significa que se haya abonado el servicio
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //Propiedades extras-------------------------------------------------------------------------------------------------------
        public string? id { get; set; } //Aparece en BD pero como identificador y no como campo propio del documento

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

        public DateTime fechaSolo()
        {
            return DateTimeOffset.FromUnixTimeSeconds(fecha["seconds"]).UtcDateTime.Date;
        }
    }
}
