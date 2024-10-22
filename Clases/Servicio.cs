using Google.Cloud.Firestore;
using System;
[FirestoreData]
public class Servicio
{
    [FirestoreProperty]
    public string? nombre { get; set; }

    [FirestoreProperty]
    public string? descripcion { get; set; }
    
    [FirestoreProperty]
    public int precio { get; set; }
    
    [FirestoreProperty]
    public string? personal_a_cargo { get; set; }
    
    [FirestoreProperty]
    public string? id { get; set; }
    
    [FirestoreProperty]
    public string? categoria_servicio_id { get; set; }

    [FirestoreProperty]
    public string? imagen { get; set; }

    public override string ToString()
    {
        return $"Nombre : {nombre}; Precio : {precio} $";
    }

    public string descripcionLarga()
    {
        return $"Nombre : {nombre}\nDescripcion : {descripcion.Substring(0, 25)}...\nPrecio : {precio}\n";
    }

    public string descripcionCompleta()
    {
        return $"Nombre : {nombre}\nDescripcion : {descripcion}\nPrecio : {precio}\n";
    }
}
