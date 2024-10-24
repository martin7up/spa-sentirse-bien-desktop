﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_2024_Parte2.Clases
{
    [FirestoreData]
    public class Usuario
    {
        [FirestoreProperty]
        public string? id { get; set; }

        [FirestoreProperty]
        public string? username { get; set; }

        [FirestoreProperty]
        public string? password { get; set; }

        [FirestoreProperty]
        public string? rol { get; set; }

        [FirestoreProperty]
        public string? ciudad { get; set; }

        [FirestoreProperty]
        public string? direccion { get; set; }

        [FirestoreProperty]
        public string? avatar { get; set; }

        public override string ToString()
        {
            switch(rol)
            {
                case "personal" : return $"Dr/a {username}";
                case "usuario" : return $"{username}; direccion : {direccion}";
            }
            return $"Usuario : {username}; Rol : {rol}";
        }
    }
}
