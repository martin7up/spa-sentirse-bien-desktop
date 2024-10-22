using Google.Api;
using Google.Cloud.Firestore;
using Google.Type;
using iTextSharp.text.pdf.codec.wmf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TPI_2024_Parte2.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TPI_2024_Parte2.ClasesUtilitarias
{
    public class BaseDeDatos //Se deberia ver por un patron singleton
    {
        
        
        //Variable de clase-------------------------------------------------------------------------------------------------------------------------------------
        private FirestoreDb db; 
        


        //Constructor-------------------------------------------------------------------------------------------------------------------------------------------
        public BaseDeDatos()
        {
            string ruta = @"C:\Users\114R7IN\Desktop\Cred\spasentirsebien-b3d7f-firebase-adminsdk-2fs8q-aaa5a28725.json";

            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", ruta);

            db = FirestoreDb.Create("spasentirsebien-b3d7f");
            
        }
        
        

        //Metodos para obtener colecciones completas------------------------------------------------------------------------------------------------------------
        public async Task obtenerUsuariosYSerializar()
        {
            //Lista contenedora
            List<Usuario>? listaUsuarios = new();

            //Recuperacion desde BD
            Query qref = db.Collection("usuarios");
            QuerySnapshot qsnap = await qref.GetSnapshotAsync();

            string ID;

            foreach (DocumentSnapshot docsnap in qsnap)
            {
                ID = docsnap.Id;
                Usuario usuario = docsnap.ConvertTo<Usuario>();

                if (docsnap.Exists)
                {
                    usuario.id = ID;//Sobreescritura de id, en caso de que no sea campo del documento
                    listaUsuarios.Add(usuario);//Agregado a lista
                }
            }

            //Serializado de la lista a archivos .json
            var json = JsonSerializer.Serialize(listaUsuarios, new JsonSerializerOptions
            {
                WriteIndented = true // For better readability of the JSON file
            });

            File.WriteAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Usuarios.json", json);

            listaUsuarios = null;
        }
        public async Task obtenerTurnosYSerializar()
        {
            //Lista contenedora
            List<Turno>? listaTurnos = new();

            //Recuperacion desde BD
            Query qref = db.Collection("turnos");
            QuerySnapshot qsnap = await qref.GetSnapshotAsync();

            string ID;

            foreach (DocumentSnapshot docsnap in qsnap)
            {
                ID = docsnap.Id;
                Turno turno = docsnap.ConvertTo<Turno>();

                if (docsnap.Exists)
                {
                    turno.id = ID;//Sobreescritura de id, en caso de que no sea campo del documento
                    listaTurnos.Add(turno);//Agregado a lista
                }
            }

            //Serializado de la lista a archivos .json
            var json = JsonSerializer.Serialize(listaTurnos, new JsonSerializerOptions
            {
                WriteIndented = true // For better readability of the JSON file
            });
            File.WriteAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Turnos.json", json);

            listaTurnos = null;
        }
        public async Task obtenerServiciosYSerializar()
        {
            //Lista contenedora
            List<Servicio>? listaServicios = new();

            //Recuperacion desde BD
            Query qref = db.Collection("servicios");
            QuerySnapshot qsnap = await qref.GetSnapshotAsync();

            string ID;

            foreach (DocumentSnapshot docsnap in qsnap)
            {
                ID = docsnap.Id;
                Servicio servicio = docsnap.ConvertTo<Servicio>();

                if (docsnap.Exists)
                {
                    servicio.id = ID;//Sobreescritura de id, en caso de que no sea campo del documento
                    listaServicios.Add(servicio);//Agregado a lista
                }
            }

            //Serializado de la lista a archivos .json
            var json = JsonSerializer.Serialize(listaServicios, new JsonSerializerOptions
            {
                WriteIndented = true // For better readability of the JSON file
            });
            File.WriteAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Servicios.json", json);

            listaServicios = null;
        
        }
        public async Task obtenerCategoriaServiciosYSerializar()
        {
            //Lista contenedora
            List<CategoriaServicio>? listaCategorias = new();

            //Recuperacion desde BD
            Query qref = db.Collection("categoria_servicio");
            QuerySnapshot qsnap = await qref.GetSnapshotAsync();

            string ID;

            foreach (DocumentSnapshot docsnap in qsnap)
            {
                ID = docsnap.Id;
                CategoriaServicio categoria = docsnap.ConvertTo<CategoriaServicio>();

                if (docsnap.Exists)
                {
                    categoria.id = ID;//Sobreescritura de id, en caso de que no sea campo del documento
                    listaCategorias.Add(categoria);//Agregado a lista
                }
            }

            //Serializado de la lista a archivos .json
            var json = JsonSerializer.Serialize(listaCategorias, new JsonSerializerOptions
            {
                WriteIndented = true // For better readability of the JSON file
            });
            File.WriteAllText(@"C:\Users\114R7IN\Desktop\Cred\Jasones\Categorias.json", json);

            listaCategorias = null;

        }
             
        //Metodos para Turno------------------------------------------------------------------------------------------------------------------------------------
        public async Task habilitarODeshabilitarUnTurno(string idDoc, bool estado)
        {
            DocumentReference docref = db.Collection("turnos").Document(idDoc);
            
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"is_cancelado", estado}
            };

            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
        }//Aplicarlo tambien al cancelar varios turno que no se hayan pagado antes de las 48hs
        public async Task crearUnNuevoTurno(string usuarioId, string servicioId, System.DateTime fechaHs)//Agrega un turno no pagado y no cancelado
        {
            //fechaHs = DateTime.Now;
            long segundosDesde1971 = (long)(fechaHs - new System.DateTime(1971, 1, 1)).TotalSeconds-86400;//Truncar decimales
            
            CollectionReference coll = db.Collection("turnos");//noticias

            Dictionary<string, object> fecha = new Dictionary<string, object>()
            {
                { "nanoseconds", 0},
                { "seconds", segundosDesde1971}
            };

            Dictionary<string, object> data = new Dictionary<string, object>
            {
                { "fecha", fecha },
                { "is_cancelado", false },
                { "is_pagado", false },
                { "metodo_de_pago", "" },
                { "servicio_id", servicioId },
                { "usuario_id", usuarioId }
            };

            await coll.AddAsync(data);
        }
        public async Task pagarUnTurno(string idDoc, string metodoDePago)
        {
            DocumentReference docref = db.Collection("turnos").Document(idDoc);
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "is_pagado", true},
                { "metodo_de_pago", metodoDePago}
            };

            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
        }//Se puede aplicar para modificar un documento
        public async Task cancelarPagoTurno(string idDoc)
        {
            DocumentReference docref = db.Collection("turnos").Document(idDoc);
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "is_pagado", false},
                { "metodo_de_pago", ""}
            };

            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
        }

        //Metodos para Servicio---------------------------------------------------------------------------------------------------------------------------------
        public async Task crearUnNuevoServicio(string nombre, string descripcion, string imagen, int precio, string personalACargo, string categoria)
        {
            CollectionReference coll = db.Collection("servicios");

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "nombre", nombre},
                { "precio", precio},
                { "imagen",imagen},
                { "personal_a_cargo", personalACargo},
                { "categoria_servicio_id", categoria},
                { "descripcion", descripcion}
            };

            await coll.AddAsync(data);
        }
        public async Task modificarUnServicio(Servicio servicio)
        {
            DocumentReference docref = db.Collection("servicios").Document(servicio.id);

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "nombre", servicio.nombre},
                { "precio", servicio.precio},
                { "imagen", servicio.imagen},
                { "personal_a_cargo", servicio.personal_a_cargo},
                { "categoria_servicio_id", servicio.categoria_servicio_id},
                { "descripcion", servicio.descripcion}
            };

            DocumentSnapshot snap = await docref.GetSnapshotAsync();//Esta parte intenta verificar si existe el doc en la BD
            
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
        }

        //Metodos para Categoria--------------------------------------------------------------------------------------------------------------------------------
        public async Task modificarUnaCategoria(string idCategoria, string nombre)
        {
            DocumentReference docref = db.Collection("categoria_servicio").Document(idCategoria);

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "nombre", nombre}
            };

            DocumentSnapshot snap = await docref.GetSnapshotAsync();//Esta parte intenta verificar si existe el doc en la BD

            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
        }
        public async Task crearUnCategoria(string nombre)
        {         
            CollectionReference coll = db.Collection("categoria_servicio");

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "nombre", nombre}
            };

            await coll.AddAsync(data);
        }

        //Metodos para Usuario----------------------------------------------------------------------------------------------------------------------------------
        public async Task crearUnNuevoUusario(string username, string ciudad, string direccion, string password, string linkAvatar, string rol)
        {
            CollectionReference coll = db.Collection("usuarios");

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "username", username},
                { "ciudad", ciudad},
                { "direccion",direccion},
                { "password", password},
                { "avatar", linkAvatar},
                { "rol", rol}
            };

            await coll.AddAsync(data);
        }
        public async Task modificarUsario(Usuario usuario)
        {
            DocumentReference docref = db.Collection("usuarios").Document(usuario.id);

            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "username", usuario.username},
                { "ciudad", usuario.ciudad},
                { "direccion",usuario.direccion},
                { "password", usuario.password},
                { "avatar", usuario.avatar},
                { "rol", usuario.rol}
            };

            DocumentSnapshot snap = await docref.GetSnapshotAsync();//Esta parte intenta verificar si existe el doc en la BD

            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
        }

    }
}