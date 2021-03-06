﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StockManagement.BLL;
using StockManagement.BLL.Contracts;
using StockManagement.Models.DatabaseContext;
using StockManagement.Models.EntityModels;
using StockManagement.Repositories;

namespace StockManagementApp.Controllers
{
    public class PartiesController : Controller
    {
        IPartyManager _partyManager;

        public PartiesController(IPartyManager partyManager)
        {
            _partyManager = partyManager;
        }

        // GET: Parties
        public ActionResult Index()
        {
            return View(_partyManager.GetAll());
        }

        // GET: Parties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Party party = _partyManager.GetById((int)id);
            if (party == null)
            {
                return HttpNotFound();
            }
            return View(party);
        }

        // GET: Parties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address,ContactNo,IsDeleted")] Party party)
        {
            if (ModelState.IsValid)
            {
                _partyManager.Add(party);
                return RedirectToAction("Index");
            }

            return View(party);
        }

        // GET: Parties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Party party = _partyManager.GetById((int)id);
            if (party == null)
            {
                return HttpNotFound();
            }
            return View(party);
        }

        // POST: Parties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,ContactNo")] Party party)
        {
            if (ModelState.IsValid)
            {
                _partyManager.Update(party);
                return RedirectToAction("Index");
            }
            return View(party);
        }

        // GET: Parties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Party party = _partyManager.GetById((int) id);
            if (party == null)
            {
                return HttpNotFound();
            }
            return View(party);
        }

        // POST: Parties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Party party = _partyManager.GetById(id);
            _partyManager.Remove(party);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _partyManager.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
