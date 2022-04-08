using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Jeremy_Castillo_Ap1_PF.Entidades
{

    public class ExpedientesDetalle
    {
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "El Id debe estar en el rango de {1} y {2}.")]
        public int  Id { get; set; }

        public int  ExpedienteId { get; set; }        
        
        [Required(ErrorMessage ="Es obligatorio introducir la Fecha de entrega")]
        public DateTime Fecha { get; set; }

        public string ? Descripcion { get; set; }

        public int TiposDocumentosId { get; set; }





    }

}