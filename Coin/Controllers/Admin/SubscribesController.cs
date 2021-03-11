using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Coin.Models;
using PagedList;
namespace Coin.Controllers.Admin
{
    public class SubscribesController : Controller
    {
        private CoinDbContext db = new CoinDbContext();

        // GET: Subscribes
        public async Task<ActionResult> Index(string sortOrder, string searchString, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;
            var subs = from s in db.Subscribes select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                subs = subs.Where(s => s.UserId.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    subs = subs.OrderByDescending(s => s.UserId);
                    break;
                case "Date":
                    subs = subs.OrderBy(s => s.Type);
                    break;
                case "date_desc":
                    subs = subs.OrderByDescending(s => s.Type);
                    break;
                default:
                    subs = subs.OrderBy(s => s.Type);
                    break;
            }
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(subs.ToPagedList(pageNumber, pageSize));
        }
        // GET: Subscribes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscribe subscribe = await db.Subscribes.FindAsync(id);
            if (subscribe == null)
            {
                return HttpNotFound();
            }
            return View(subscribe);
        }

        // GET: Subscribes/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email");
            return View();
        }

        // POST: Subscribes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UserId,StartDate,EndDate,Type,CreatedAt,UpdatedAt,Code,Status")] Subscribe subscribe)
        {
            if (ModelState.IsValid)
            {
                db.Subscribes.Add(subscribe);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", subscribe.UserId);
            return View(subscribe);
        }

        // GET: Subscribes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscribe subscribe = await db.Subscribes.FindAsync(id);
            if (subscribe == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", subscribe.UserId);
            return View(subscribe);
        }

        // POST: Subscribes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UserId,StartDate,EndDate,Type,CreatedAt,UpdatedAt,Code,Status")] Subscribe subscribe)
        {
            if (ModelState.IsValid)
            {
                subscribe.UpdatedAt = DateTime.Now;
                db.Entry(subscribe).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", subscribe.UserId);
            return View(subscribe);
        }

        // GET: Subscribes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscribe subscribe = await db.Subscribes.FindAsync(id);
            if (subscribe == null)
            {
                return HttpNotFound();
            }
            return View(subscribe);
        }

        // POST: Subscribes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Subscribe subscribe = await db.Subscribes.FindAsync(id);
            db.Subscribes.Remove(subscribe);
            await db.SaveChangesAsync();
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
