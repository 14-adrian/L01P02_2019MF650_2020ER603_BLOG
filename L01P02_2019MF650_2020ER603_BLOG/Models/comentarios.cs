using System.ComponentModel.DataAnnotations;
namespace L01P02_2019MF650_2020ER603_BLOG.Models
{
    public class comentarios
    {
        [Key]
        public int cometarioId { get; set; }
        public int publicacionId { get; set; }
        public string? comentario { get; set; }
        public int usuarioId { get; set; }

    }
}