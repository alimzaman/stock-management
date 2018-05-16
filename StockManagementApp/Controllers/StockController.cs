using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockManagement.Models.DatabaseContext;
using StockManagement.Models.ViewModels;

namespace StockManagementApp.Controllers
{
    public class StockController : Controller
    {
        StockDBContext db = new StockDBContext();
        
        public ActionResult StockIn()
        {
            var model = new StockInCreateVM();
            model.Categories = db.Categories.ToList();
            ViewBag.ProductDropDown = new SelectListItem[]{new SelectListItem(){Value="",Text = "Select..."}};
            return View(model);
        }

        [HttpPost]
        public ActionResult StockIn(StockInCreateVM model)
        {
            return View();
        }

       
    }
}