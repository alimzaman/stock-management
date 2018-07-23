using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using StockManagement.BLL;
using StockManagement.Models.DatabaseContext;
using StockManagement.Models.EntityModels;
using StockManagement.Models.ViewModels;

namespace StockManagementApp.Controllers
{
    public class StockController : Controller
    {
        StockDBContext db = new StockDBContext();
        PartyManager _partyManager;
        public ActionResult StockIn()
        {
            var model = new StockInCreateVM();
            model.Categories = db.Categories.ToList();
            model.Parties = _partyManager.GetAll().ToList();
            ViewBag.ProductDropDown = new SelectListItem[]{new SelectListItem(){Value="",Text = "Select..."}};
           
            return View(model);
        }

        [HttpPost]
        public ActionResult StockIn(StockInCreateVM model)
        {
            //insert logic against stockcreate

            StockIn stockIn = Mapper.Map<StockIn>(model);

            db.StockIns.Add(stockIn);
            if (db.SaveChanges() > 0)
            {
                ViewBag.Message = "Successful!";
            }


            model.Categories = db.Categories.ToList();
            model.Parties = _partyManager.GetAll().ToList();
            ViewBag.ProductDropDown = new SelectListItem[] { new SelectListItem() { Value = "", Text = "Select..." } };
            return View(model);
        }

       
    }
}