using System.ComponentModel.DataAnnotations;
namespace L01P02_2019MF650_2020ER603_BLOG.Models
{
    public class calificaciones
    {
        [Key]
        public int calificacionId { get; set; }
        public int publicacionId { get; set; }
        public int calificacion { get; set; }
        public int usuarioId { get; set; }

    }
}
