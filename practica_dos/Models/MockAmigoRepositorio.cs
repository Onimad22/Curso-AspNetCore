using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica_dos.Models
{
    public class MockAmigoRepositorio : IAmigoAlmacen 
    {
        private List<Amigo> amigosLista;

        public MockAmigoRepositorio()
        {
            amigosLista = new List<Amigo>();
            amigosLista.Add(new Amigo { Id = 1, Nombre = "Marcos", Ciudad = "Camapana", Email = "algo@mail" });
            amigosLista.Add(new Amigo { Id = 2, Nombre = "Angel", Ciudad = "Zarate", Email = "nuevo@mail" });
            amigosLista.Add(new Amigo { Id = 3, Nombre = "Jose", Ciudad = "Balcon 2", Email = "jose@mail" });

        }



        public Amigo dameDatosAmigo(int Id)
        {
           return amigosLista.FirstOrDefault(e => e.Id==Id);
        }
    }
}
