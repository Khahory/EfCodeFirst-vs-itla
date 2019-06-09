using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfCodeFirst.Models
{
    public class BlogPostModel
    {
        //para que entity framwork se de cuenta que esto es un id para identificar cada BlogPost
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        [Required]
        public string Contenido { get; set; }

        [StringLength(100)]
        public string Autor { get; set; }

        public DateTime Publicacion { get; set; }

        public List<ComentarioModel> Comentarios { get; set; }
    }
}