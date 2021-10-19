using System.Collections.Generic;
using System.Linq;

namespace practica_dos.Models
{
    public class MockAmigoRepositorio : IAmigoAlmacen
    {
        private List<Amigo> amigosLista;

        public MockAmigoRepositorio()
        {
            amigosLista = new List<Amigo>();
            amigosLista.Add(new Amigo { Id = 1, Nombre = "Marcos", Ciudad = Province.BuenosAires, Email = "algo@mail" });
            amigosLista.Add(new Amigo { Id = 2, Nombre = "Angel", Ciudad = Province.Catamarca, Email = "nuevo@mail" });
            amigosLista.Add(new Amigo { Id = 3, Nombre = "Jose", Ciudad = Province.Jujuy, Email = "jose@mail" });

        }



        public Amigo dameDatosAmigo(int Id)
        {
            return amigosLista.FirstOrDefault(e => e.Id == Id);
        }

        public List<Amigo> DameTodosAmigos()
        {
            return amigosLista;
        }


        public Amigo nuevo(Amigo amigo)
        {
            amigo.Id = amigosLista.Max(a => a.Id) + 1;
            amigosLista.Add(amigo);
            return amigo;
        }


    }
}
