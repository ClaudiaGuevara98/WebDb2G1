using System.ComponentModel.DataAnnotations;

namespace WebDbG2.Areas.Identity
{
    public class Dpto
    {
        public int Id { get; set; }

        [MaxLength(40)]
           
        public string? Nombre { get; set; }

        public ICollection <Ciudad>? Ciudades { get; set; }
    }
}
