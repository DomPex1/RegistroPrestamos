using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamos.Models
{
    public class Prestamos
    {
        [Key]
        [Required(ErrorMessage = "El ID no debe estar vacio...")]
        public int PrestamosId { get; set; }

        [Required(ErrorMessage = "La Fecha no debe estar vacia...")]
        public DateTime Fecha { get; set; }

        [Range(1, 1000000, ErrorMessage = "Debe elegir una persona...")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "El Concepto no debe estar vacio...")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "El Monto no debe estar vacio...")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "El Balance no debe estar vacio...")]
        public decimal Balance { get; set; }

        public Prestamos()
        {
            PrestamosId = 0;
            Fecha = DateTime.Now;
            PersonaId = 0;
            Concepto = string.Empty;
            Monto = 0;
            Balance = 0;
        }
    }
}