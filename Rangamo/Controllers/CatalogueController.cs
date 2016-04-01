using Rangamo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rangamo.Controllers
{
    public class CatalogueController : Controller
    {
        private IRangamoRepository _RangamoRepository;
        public CatalogueController()
        {
            this._RangamoRepository = new RangamoRepository(new RangamoContext());
        }
        // GET: Catalogue
        public ActionResult Index()
        {
            ViewBag.ListProducts = _RangamoRepository.GetProducts();
            return View();
        }
    }
}