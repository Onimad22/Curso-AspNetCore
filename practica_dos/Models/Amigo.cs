using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace practica_dos.Models
{
    public class Amigo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio"), MaxLength(100,ErrorMessage ="Maximo de 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name ="Email")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$",ErrorMessage ="Formato incorrecto")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Debe seleccionar una provincia")]
        public Province? Ciudad { get; set; }

        public string rutaFoto { get; set; }
    }
}
