using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamos.Models
{

    public class Personas
    {

        [Key]
        [Required(ErrorMessage = "El ID no debe estar vacio...")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "El Nombre no debe estar vacio...")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Tlefono no debe estar vacio...")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La Cedula no debe estar vacia...")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "La Direccion no debe estar vacia...")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La Fecha no debe estar vacia...")]
        public DateTime Fecha { get; set; }
        public decimal Balance { get; set; }

        public Personas()
        {

            PersonaId = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Fecha = DateTime.Now;
            Balance = 0;

        }

    }

}