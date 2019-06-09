using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EfCodeFirst.Models
{
    public class ComentarioModel
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string Autor { get; set; }

        //esta sera la clave foranea de este modelo
        public int BlogPostId{ get; set; }

        [ForeignKey("BlogPostId")]
        public BlogPostModel BlogPost { get; set; }
    }
}