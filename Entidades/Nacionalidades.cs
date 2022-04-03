using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace Jeremy_Castillo_Ap1_PF.Entidades
{
    public class Nacionalidades
    {
        [Key]
        public int NacionalidadId { get; set; }

        public string? Descripcion { get; set; }


    }
}