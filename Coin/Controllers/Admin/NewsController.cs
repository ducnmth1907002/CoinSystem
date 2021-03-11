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
    public class NewsController : Controller
    {
        private CoinDbContext db = new CoinDbContext();

        // GET: News
        public ViewResult Index(string sortOrder, string searchString, string currentFilter, int? page)
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
            var news = from s in db.News select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                news = news.Where(s => s.Title.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    news = news.OrderByDescending(s => s.Title);
                    break;
                case "Date":
                    news = news.OrderBy(s => s.Title);
                    break;
                case "date_desc":
                    news = news.OrderByDescending(s => s.Title);
                    break;
                default:
                    news = news.OrderBy(s => s.Title);
                    break;
            }
            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(news.ToPagedList(pageNumber, pageSize));
        }

        // GET: News/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = await db.News.FindAsync(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        // GET: News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: News/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,UserId,Title,Description,Content,Thumbnail,Status,Type,CreatedAt,UpdatedAt")] News news)
        {
            if (ModelState.IsValid)
            {
                news.CreatedAt = DateTime.Now;
                news.UpdatedAt = DateTime.Now;
                db.News.Add(news);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(news);
        }

        // GET: News/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = await db.News.FindAsync(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        // POST: News/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,UserId,Title,Description,Content,Thumbnail,Status,Type,CreatedAt,UpdatedAt")] News news)
        {
            if (ModelState.IsValid)
            {
                news.UpdatedAt = DateTime.Now;
                db.Entry(news).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(news);
        }

        // GET: News/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = await db.News.FindAsync(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            News news = await db.News.FindAsync(id);
            db.News.Remove(news);
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
