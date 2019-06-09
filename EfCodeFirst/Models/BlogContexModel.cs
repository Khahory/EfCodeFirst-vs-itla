using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EfCodeFirst.Models
{
    //Clase en la cual indicamos cuales son los modelos que queremos
    //que Entity Framework tome en cuenta para crear nuestra DB

    public class BlogContexModel : DbContext
    {
        //esto es pasarle que DBContext queremos utilizar (podemos usar varios)
        public BlogContexModel()
            :base("DefaultConnection")
        {

        }


        //el blogPostModel se le puso porque ahi le indicamos a quien queremos hacerle los query (insert, delete, ect)
        //para guardar la DB
        //lo que recibe es lo que se enviara a la DB
        public DbSet<BlogPostModel> BlogPost { get; set; }
        public DbSet<ComentarioModel> comentarios { get; set; }
    }
}