using practica_dos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica_dos.ViewModels
{
    public class DetailsView
    {
        public string titulo { get; set; }
        public string subTitulo { get; set; }
        public Amigo amigo { get; set; }
    }
}
