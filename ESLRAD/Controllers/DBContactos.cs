using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ESLRAD.Controllers
{
    public class DBContactos
    {
        
            readonly SQLiteAsyncConnection _conexion;
            // Constructor Vacio
            public DBContactos()
            { }

            // Constructor con parametros
            public DBContactos(String dbpath)
            {
                // Creando una conexion a base de datos sqlite a partir del path de la base de datos
                _conexion = new SQLiteAsyncConnection(dbpath);

                // Crear las tablas correspondientes en la base de datos de sqlite
                _conexion.CreateTableAsync<Models.Contactos>().Wait();
            }

            // CRUD - Aplicaciones 
            // Create

            public Task<int> StoreEmple(Models.Contactos emple)
            {
                if (emple.Id != 0)
                {
                    return _conexion.UpdateAsync(emple);
                }
                else
                {
                    return _conexion.InsertAsync(emple);
                }
            }
            // Read

            public Task<List<Models.Contactos>> listaempleados()
            {
                return _conexion.Table<Models.Contactos>().ToListAsync();
            }

            public Task<Models.Contactos> getempleado(int pid)
            {
                return _conexion.Table<Models.Contactos>()
                    .Where(i => i.Id == pid)
                    .FirstOrDefaultAsync();
            }

            public Task<int> Deleteempleado(Models.Contactos emple)
            {
                return _conexion.DeleteAsync(emple);
        }

        public Task<int> ActualizarContacto(Models.Contactos emple)
        {
            return _conexion.UpdateAsync(emple);
        }

    }
    }

