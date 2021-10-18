using Microsoft.AspNetCore.Mvc;
using practica_dos.Models;
using practica_dos.ViewModels;
using System;
using System.Collections.Generic;
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


        public ViewResult Details()
        {

            //ACA DEFINO UN OBJETO AL QUE LLAMO "modelo" DE TIPO "DetailsView" 
            
            DetailsView modelo = new DetailsView();

            modelo.amigo = amigoAlmacen.dameDatosAmigo(1);
            modelo.titulo = "Titulo viewModels";
            modelo.subTitulo = "Subtitulo";

            //ACA ESTOY ENVIANDOLE COMO PARAMETRO A LA VISTA "Details" EL OBJETO  "modelo" DE TIPO "Amigo"
            return View(modelo);
        }



    }
}
