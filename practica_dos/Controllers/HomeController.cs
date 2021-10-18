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

        public string Index()
        {
            return amigoAlmacen.dameDatosAmigo(1).Email;
        }


        public ViewResult Details()
        {

            //ACA DEFINO UN OBJETO AL QUE LLAMO "modelo" DE TIPO "Amigo" QUE CONTIENE EL RETORNO DEL
            //PROCEDIMIENTO "dameDatosAmigo" AL QUE LE PASO LA VARIABLE "Id" EN ESTE CASO EL "Id=1"
            Amigo modelo = amigoAlmacen.dameDatosAmigo(1);

            //ACA DEFINO UN "ViewData" DE NOMBRE "Cabecera"(ES EL IDENTIFICADOR) Y LE ASIGNO UN STRING
            //AL SEGUNDO LE ASIGNO EL NOMBRE DE "Amigo" Y LE ASIGNO EL OBJETO  "modelo" DE TIPO "Amigo"
            ViewData["Cabecera"] = "Lista Amigos ViewData";
            ViewData["Amigo"] = modelo;

            //ACA DEFINO UN "ViewBag" DE NOMBRE "Titulo"(ES EL IDENTIFICADOR) Y LE ASIGNO UN STRING
            //AL SEGUNDO LE ASIGNO EL NOMBRE DE "Amigo" Y LE ASIGNO EL OBJETO "modelo" DE TIPO "Amigo"
            ViewBag.Titulo = "Lista amigos ViewBag";
            ViewBag.Amigo = modelo;

            //ACA ESTOY ENVIANDOLE COMO PARAMETRO A LA VISTA "Details" EL OBJETO  "modelo" DE TIPO "Amigo"
            return View(modelo);
        }



    }
}
