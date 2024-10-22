using Google.Cloud.Firestore;
using System;

[FirestoreData]
public class CategoriaServicio
{
    [FirestoreProperty]
    public string? nombre { get; set; }

    //Propiedad extra-------------------------------------------------------------------------------------------------------------------
    public string id { get; set; }
    public override string ToString()
    {
        return nombre;
    }

}
