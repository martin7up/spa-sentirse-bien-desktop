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
    //AGREGAR ESTE CAMPO EN BASE DE DATOS FIREBASE
    [FirestoreProperty]
    public string? personal_a_cargo { get; set; }
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    [FirestoreProperty]
    public string? id { get; set; }
    
    [FirestoreProperty]
    public string? categoria_servicio_id { get; set; }

    [FirestoreProperty]
    public string? imagen { get; set; }

    public override string ToString()
    {
        return $"Nombre : {nombre}\nDescripcion : {descripcion.Substring(0,25)}...\nId : {id}\nPrecio : {precio}\n";
    }
}
