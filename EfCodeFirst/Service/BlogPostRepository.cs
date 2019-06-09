using EfCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EfCodeFirst.Service
{
    //clase que se comunicara con el DBContext para realizar las operaciones de DB que tengan que ver con el blogPost
    public class BlogPostRepository
    {
        

        public List<BlogPostModel> ObtenerTodos()
        {
            using (var db = new BlogContexModel())
            {
                //retorna la tista que creamos en BlogContexModel
                //debemos incluir en este query que queremos obtenerer los comentarios tambien
                return db.BlogPost.Include(x => x.Comentarios).ToList();
            }
        }

        internal void Crear(BlogPostModel model)
        {
            using (var db = new BlogContexModel())
            {
                //anadimos el modelo a nuestra lista de blogPost
                db.BlogPost.Add(model);
                //guardar cambios en la db
                db.SaveChanges();
            }
        }
    }
}