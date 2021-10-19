using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica_dos.Models
{
    public class Amigo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public Province Ciudad { get; set; }
    }
}
