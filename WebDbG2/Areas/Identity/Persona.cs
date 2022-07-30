﻿using System.ComponentModel.DataAnnotations;

namespace WebDbG2.Areas.Identity
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(40)]
        public string? Nombre { get; set; }

        [MaxLength(40)]
        [Display(Name ="Direcciòn")]
        public string? Direccion { get; set; }

        public int CiudadId { get; set; }

        [MaxLength(40)]
        [Display(Name = "Telèfono")]
        public string? Telefono { get; set; }

        [MaxLength(40)]
        public string? Email { get; set; }

        [Display(Name = "Fecha nacimiento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime Fechanac { get; set; }

        public Ciudad? Ciudad  { get; set; }
    }
}
