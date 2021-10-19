using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica_dos.Models
{
    public class SqlAmigoRepositorio : IAmigoAlmacen
    {
        private readonly AppDbContext _contexto;
        private List<Amigo> amigosLista;

        public SqlAmigoRepositorio(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public Amigo borrar(int id)
        {
            Amigo amigo = _contexto.Amigos.Find(id);
            if (amigo!=null)
            {
                _contexto.Amigos.Remove(amigo);
                _contexto.SaveChanges();
            }
            return amigo;
        }

        public Amigo dameDatosAmigo(int Id)
        {
           return _contexto.Amigos.Find(Id);
        }

        public List<Amigo> DameTodosAmigos()
        {
            amigosLista = _contexto.Amigos.ToList<Amigo>();
            return amigosLista;
        }

        public Amigo modificar(Amigo modifAmigo)
        {
            var employee = _contexto.Amigos.Attach(modifAmigo);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _contexto.SaveChanges();
            return modifAmigo;
        }

        public Amigo nuevo(Amigo amigo)
        {
            _contexto.Amigos.Add(amigo);
            _contexto.SaveChanges();
            return amigo;
        }
    }
}
