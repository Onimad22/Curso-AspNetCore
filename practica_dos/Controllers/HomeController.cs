using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using practica_dos.Models;
using practica_dos.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace practica_dos.Controllers
{
    public class HomeController:Controller
    {
        
        private IAmigoAlmacen amigoAlmacen;

        public HomeController(IAmigoAlmacen AmigoAlmacen )
        {
            amigoAlmacen = AmigoAlmacen;
        }

        public ViewResult Index()
        {
            var modelo = amigoAlmacen.DameTodosAmigos();
            
            return View(modelo);
        }


        public ViewResult Details(int? id)
        {

            //ACA DEFINO UN OBJETO AL QUE LLAMO "modelo" DE TIPO "DetailsView" 
            
            DetailsView modelo = new DetailsView();

            modelo.amigo = amigoAlmacen.dameDatosAmigo(id?? 3);
            modelo.titulo = "Titulo viewModels";
            modelo.subTitulo = "Subtitulo";

            //ACA ESTOY ENVIANDOLE COMO PARAMETRO A LA VISTA "Details" EL OBJETO  "modelo" DE TIPO "Amigo"
            return View(modelo);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateAmigoModel modelo)
        {
            if (ModelState.IsValid)
            {
                string guidImagen = null;
                if (modelo.Foto!=null)
                {
                    string ficherosImagen = Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot\\images\\");
                    guidImagen = Guid.NewGuid().ToString() + modelo.Foto.FileName;
                    string rutaDefinitiva = Path.Combine(ficherosImagen + guidImagen);
                    modelo.Foto.CopyTo(new FileStream(rutaDefinitiva, FileMode.Create));
                }
                Amigo nuevoAmigo = new Amigo();
                nuevoAmigo.Nombre = modelo.Nombre;
                nuevoAmigo.Email = modelo.Email;
                nuevoAmigo.Ciudad = modelo.Ciudad;
                nuevoAmigo.rutaFoto = guidImagen;

                amigoAlmacen.nuevo(nuevoAmigo);
                return RedirectToAction("Details", new { id = nuevoAmigo.Id });
            }

            return View();

        }
    }
}
