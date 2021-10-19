using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica_dos.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Amigo> Amigos { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amigo>().HasData(new Amigo
            {
                Id = 1,
                Nombre = "Primero",
                Ciudad = Province.Corrientes,
                Email = "primero@mail.com"
            },
            new Amigo
            {
                Id = 2,
                Nombre = "Segundo",
                Ciudad = Province.BuenosAires,
                Email = "segundo@mail.com"
            },
            new Amigo
            {
                Id = 3,
                Nombre = "Tercero",
                Ciudad = Province.Jujuy,
                Email = "Tercero@mail.com"
            });
        }

    }
    

}
