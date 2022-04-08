using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Jeremy_Castillo_Ap1_PF.Entidades
{
    public class Expedientes
    {
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "El ExpedienteID debe estar en el rango de {1} y {2}.")]
        public int ExpedienteId { get; set; }

        public int EstudianteId { get; set; }
        public string? EstudianteNombre { get; set; }


        public int CantidadDocumentos { get; set; }

        [ForeignKey("ExpedienteId")]

        public  List<ExpedientesDetalle> ExpedienteDetalle {get; set;} = new List<ExpedientesDetalle>();
    }
}