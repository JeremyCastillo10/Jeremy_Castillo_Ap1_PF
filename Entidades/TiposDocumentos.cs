using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Jeremy_Castillo_Ap1_PF.Entidades
{
    public class TiposDocumentos
    {
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "El TipoDocumentoID debe estar en el rango de {1} y {2}.")]
        public int TipoDocumentoId { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir la Descripcion")]
        [MinLength(2, ErrorMessage = "La Descripcion debe tener al menos {1} caractéres.")]
        public string? Descripcion { get; set; }


        [ForeignKey("TipoDocumentoId")]

        [Required(ErrorMessage ="Es obligatorio introducir la Fecha")]
        public DateTime Fecha { get; set; }


    }
}