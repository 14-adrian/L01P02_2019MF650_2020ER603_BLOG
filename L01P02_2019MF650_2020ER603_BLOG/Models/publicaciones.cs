using System.ComponentModel.DataAnnotations;
namespace L01P02_2019MF650_2020ER603_BLOG.Models
{
    public class publicaciones
    {
        [Key]
        public int publicacionId { get; set; }
        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public int usuarioId { get; set; }

    }
}
