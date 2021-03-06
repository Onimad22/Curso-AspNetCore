using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica_dos.Models
{
   public interface IAmigoAlmacen
    {
        Amigo dameDatosAmigo(int Id);

        List<Amigo> DameTodosAmigos();

        Amigo nuevo(Amigo amigo);

        Amigo modificar(Amigo modifAmigo);

        Amigo borrar(int id); 
    }
}
