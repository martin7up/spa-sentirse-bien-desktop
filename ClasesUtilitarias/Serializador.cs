using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPI_2024_Parte2.ClasesUtilitarias
{
    static internal class Serializador
    {
        public static void serializarColeccion(ICollection coleccion, string ruta)
        {
            var json = JsonSerializer.Serialize(coleccion, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(ruta, json);
        }

        public static ICollection<T> deserializarArchivo<T>(string ruta)
        {
            var json = File.ReadAllText(ruta);
            
            ICollection<T> coleccion = JsonSerializer.Deserialize<List<T>>(json);

            return coleccion;
        }
    }
}
