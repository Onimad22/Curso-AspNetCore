using System.Collections.Generic;
using System.Linq;

namespace practica_dos.Models
{
    public class MockAmigoRepositorio : IAmigoAlmacen
    {
        private readonly List<Amigo> amigosLista;

        public MockAmigoRepositorio()
        {
            amigosLista = new List<Amigo>();
            amigosLista.Add(new Amigo { Id = 1, Nombre = "Marcos", Ciudad = Province.BuenosAires, Email = "algo@mail" });
            amigosLista.Add(new Amigo { Id = 2, Nombre = "Angel", Ciudad = Province.Catamarca, Email = "nuevo@mail" });
            amigosLista.Add(new Amigo { Id = 3, Nombre = "Jose", Ciudad = Province.Jujuy, Email = "jose@mail" });

        }

        public Amigo borrar(int id)
        {
            Amigo amigo = amigosLista.FirstOrDefault(e => e.Id == id);
            if (amigo!=null)
            {
                amigosLista.Remove(amigo);
            }
            return amigo;
        }

        public Amigo dameDatosAmigo(int Id)
        {
            return amigosLista.FirstOrDefault(e => e.Id == Id);
        }

        public List<Amigo> DameTodosAmigos()
        {
            return amigosLista;
        }

        public Amigo modificar(Amigo modifAmigo)
        {
            Amigo amigo = amigosLista.FirstOrDefault(e => e.Id == modifAmigo.Id);
            if (amigo != null)
            {
                amigo.Nombre = modifAmigo.Nombre;
                amigo.Email = modifAmigo.Email;
                amigo.Ciudad = modifAmigo.Ciudad;
            }
            return amigo;
        }

        public Amigo nuevo(Amigo amigo)
        {
            amigo.Id = amigosLista.Max(a => a.Id) + 1;
            amigosLista.Add(amigo);
            return amigo;
        }


    }
}
