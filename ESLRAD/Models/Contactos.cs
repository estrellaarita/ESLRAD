using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ESLRAD.Models
{
    public class Contactos
    {
        [PrimaryKey , AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string nombres { get; set; }
        [MaxLength(100)]
        public string apellidos { get; set; }
        [MaxLength(5)]
        public int edad { get; set; }
        [MaxLength(100)]
        public string pais { get; set; }
 
        public string nota { get; set; }
    }
}
