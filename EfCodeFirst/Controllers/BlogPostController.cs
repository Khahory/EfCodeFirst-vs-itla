using EfCodeFirst.Models;
using EfCodeFirst.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfCodeFirst.Controllers
{
    public class BlogPostController : Controller
    {

        //https://www.youtube.com/watch?v=IKlmroHxDNc&t=1442s
        private BlogPostRepository _repo;

        //constructor
        public BlogPostController()
        {
            _repo = new BlogPostRepository();
        }

        // GET: BlogPost
        public ActionResult Index()
        {

            var model = _repo.ObtenerTodos();
                                
                                //del primer blogPost que encuentres, traeme el primer comentario
            //aqui mostramos el primer comentario de nuestra publicacion (puedes verlo con el punto rojo de detener)
            var comentario = model[0].Comentarios[0];
            return View(model);
        }

        // GET: BlogPost/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogPost/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPost/Create
        [HttpPost]
        public ActionResult Create(BlogPostModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    //este modelo se enviara a crear, luego se enviara al MODELO de BlogPostModel (y despues de ahi a la DB)
                    _repo.Crear(model);
                    
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                //log ex
            }
            return View(model);
        }

        // GET: BlogPost/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogPost/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogPost/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogPost/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
