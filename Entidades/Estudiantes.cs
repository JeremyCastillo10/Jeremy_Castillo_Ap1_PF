using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Jeremy_Castillo_Ap1_PF.Entidades
{
    public partial class Estudiantes
    {
        [Key]
        [Range(0, int.MaxValue, ErrorMessage = "El EstudianteID debe estar en el rango de {1} y {2}.")]
        public int EstudianteId { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir el nombre")]
        [MinLength(2, ErrorMessage = "El Nombre debe tener al menos {1} caractéres.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir el apellido")]
        [MinLength(2, ErrorMessage = "El Apellido debe tener al menos {1} caractéres.")]
        public string? Apellidos { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir la fecha de Nacimiento")]

        public DateTime FechaNacimiento { get; set; }= DateTime.Now;
        
        
        [Required(ErrorMessage = "Obligatorio elegir un sexo")]
        public char Sexo { get; set; }


        [Required(ErrorMessage ="Es obligatorio introducir la Direccion")]
        [MinLength(2, ErrorMessage = "Laa direccion debe tener al menos {1} caractéres.")]
        public string? Direccion { get; set; }

        
        [Required(ErrorMessage ="Es obligatorio introducir el Telefono")]     
        [MinLength(10, ErrorMessage = "El telefono debe tener al menos {1} caractéres.")]
        [MaxLength(15, ErrorMessage = "El telefono no debe pasar de {1} caractéres.")]   
        public string? Telefono { get; set; }

        
        [Required(ErrorMessage ="Es obligatorio introducir el Email")]
        [MinLength(2, ErrorMessage = "El Email debe tener al menos {1} caractéres.")]
        public string? Email { get; set; }

        [ForeignKey("EstudianteId")]

        public int Edad { get; set; }
        public int CantidadAsistencias { get; set; }

        public int NacionalidadId { get; set; }


        public virtual List<Nacionalidades> Nacionalidades {get;set;}= new List<Nacionalidades>();


    }
}