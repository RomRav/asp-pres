using Microsoft.AspNetCore.Mvc;
using monpetittuto.Data;
using monpetittuto.Models;

namespace monpetittuto.Controllers
{
    public class ArticleController : Controller
    {
        private readonly DbConnect _db;

        public ArticleController(DbConnect db)
        {
            _db = db;
        }
        //Affichage de la liste des articels
        public IActionResult Index()
        {
            //Les instructions qui recuperent mes articles que je passerai a ma vue ici
            IEnumerable<Article> articles = _db.Articles.ToList();
            return View(articles);
        }
        //Affichage du formulaire d'ajout d'un nouvelle article
        public IActionResult Add()
        {
            return View();
        }
        //Ajout d'un nouvelle article dans la base de données.
        [HttpPost]
        [ValidateAntiForgeryToken]//attaque de type cross--site
        public IActionResult Add(Article newArticle)
        {
            if(newArticle.Title == newArticle.Content)
            {
                ModelState.AddModelError("double", "Titre et contenu sont identique.");
            }
            ViewBag.content = newArticle.Title + " " + newArticle.Content;
            if (ModelState.IsValid)
            {
                _db.Articles.Add(newArticle);
                _db.SaveChanges();
                TempData["success"] = "L'article a bien été ajouté.";
                return RedirectToAction("Index");
            }
           
            return View();
        }
        //Supprimez un article
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            
            Article articleToDel = new Article { Id = id};
            _db.Articles.Remove(articleToDel);
            _db.SaveChanges();
            TempData["success"] = "L'article a bien été supprimé.";
            return RedirectToAction("Index");
        }
        //Affiche le formulaire de modification d'un article
        public IActionResult Update(int? id)
        {
            var article = _db.Articles.Find(id);
            if (article == null || id == 0)
            {
                return NotFound();
            }
            

            return View(article);
        }
        //Affiche le formulaire de modifier d'un article
        [HttpPost]
        [ValidateAntiForgeryToken]//attaque de type cross--site
        public IActionResult Update(Article updateArticle)
        {
            if (updateArticle.Title == updateArticle.Content)
            {
                ModelState.AddModelError("double", "Titre et contenu sont identique.");
            }
            if (ModelState.IsValid)
            {
                updateArticle.DatelastEdit = DateTime.Now;
                _db.Articles.Update(updateArticle);
                _db.SaveChanges();
                TempData["success"] = "L'article a bien été modifié.";
                return RedirectToAction("Index");
            }
            return View(updateArticle);
        }
    }
}
