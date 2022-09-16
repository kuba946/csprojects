using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Missing.Models;

namespace Missing.Controllers
{
    public class UserRolesController : Controller
    {
        private DefaultConnectionEntities db = new DefaultConnectionEntities();

        // GET: UserRoles
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            var aspNetUserRoles = db.AspNetUserRoles.Include(a => a.AspNetRoles).Include(a => a.AspNetUsers);
            return View(aspNetUserRoles.ToList());
        }

        // GET: UserRoles/Details/5
        [Authorize(Roles = "admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetUserRoles aspNetUserRoles = db.AspNetUserRoles.Find(id);
            if (aspNetUserRoles == null)
            {
                return HttpNotFound();
            }
            return View(aspNetUserRoles);
        }

        // GET: UserRoles/Create
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            ViewBag.RoleId = new SelectList(db.AspNetRoles, "Id", "Name");
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email");
            return View(new AspNetUserRoles());
        }

        // POST: UserRoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,RoleId")] AspNetUserRoles aspNetUserRoles)
        {
            if (ModelState.IsValid)
            {
                db.AspNetUserRoles.Add(aspNetUserRoles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RoleId = new SelectList(db.AspNetRoles, "Id", "Name", aspNetUserRoles.RoleId);
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email", aspNetUserRoles.UserId);
            return View(aspNetUserRoles);
        }

        // GET: UserRoles/Edit/5
        [Authorize(Roles = "admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetUserRoles aspNetUserRoles = db.AspNetUserRoles.Find(id);
            if (aspNetUserRoles == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoleId = new SelectList(db.AspNetRoles, "Id", "Name", aspNetUserRoles.RoleId);
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email", aspNetUserRoles.UserId);
            return View(aspNetUserRoles);
        }

        // POST: UserRoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,RoleId")] AspNetUserRoles aspNetUserRoles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aspNetUserRoles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RoleId = new SelectList(db.AspNetRoles, "Id", "Name", aspNetUserRoles.RoleId);
            ViewBag.UserId = new SelectList(db.AspNetUsers, "Id", "Email", aspNetUserRoles.UserId);
            return View(aspNetUserRoles);
        }

        // GET: UserRoles/Delete/5
        [Authorize(Roles = "admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetUserRoles aspNetUserRoles = db.AspNetUserRoles.Find(id);
            if (aspNetUserRoles == null)
            {
                return HttpNotFound();
            }
            return View(aspNetUserRoles);
        }

        // POST: UserRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AspNetUserRoles aspNetUserRoles = db.AspNetUserRoles.Find(id);
            db.AspNetUserRoles.Remove(aspNetUserRoles);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
