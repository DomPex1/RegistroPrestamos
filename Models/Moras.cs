using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamos.Models
{

    public class Moras
    {

        [Key]
        [Required(ErrorMessage = "El ID no debe estar vacio...")]
        public int MoraId { get; set; }

        [Required(ErrorMessage = "El Total no debe estar vacio...")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "La Fecha no debe estar vacia...")]
        public DateTime Fecha { get; set; }

        [ForeignKey("MoraId")]
        public virtual List<MorasDetalle> MorasDetalle { get; set; }

        public Moras()
        {
            MoraId = 0;
            Fecha = DateTime.Now;
            Total = 0;
            MorasDetalle = new List<MorasDetalle>();
        }

    }


}