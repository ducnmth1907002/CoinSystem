using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using Coin.Models;

namespace Coin.Controllers
{
    public class NewsController : ApiController
    {
        private CoinDbContext db = new CoinDbContext();

        public IQueryable<News> GetListNews()
        {
            var type = new UserController().GetUserInfo().SubscribeType;
            if (type ==SubscribeType.Silver)
            {
                return db.News.Where(g => g.Type == NewsType.Bronze || g.Type == NewsType.Silver);
            }
            else if (type == SubscribeType.Gold)
            {
                return db.News;
            }
            else
            {
                return db.News.Where(g => g.Type == NewsType.Bronze);
            }
        }
        // GET: api/News
        public IQueryable<News> GetNews()
        {
            return db.News;
        }
        // GET: api/News/5
        [ResponseType(typeof(News))]
        public IHttpActionResult GetNews(int id)
        {
            News news = db.News.Find(id);
            if (news==null)
            {
                return NotFound();
            }
            var t = news.Type;
            var u = new UserController().GetUserInfo().SubscribeType;
            if (t==NewsType.Bronze)
            {
                return Ok(news);
            }
            else if(t == NewsType.Silver)
            {
                if (u==SubscribeType.Silver||u==SubscribeType.Gold)
                {
                    return Ok(news);
                }
                return NotFound();
            } else if (t == NewsType.Silver)
            {
                if (u == SubscribeType.Gold)
                {
                    return Ok(news);
                }
                return NotFound();
            }
            return Ok(news);
        }

        // PUT: api/News/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNews(int id, News news)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != news.Id)
            {
                return BadRequest();
            }

            db.Entry(news).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/News
        [ResponseType(typeof(News))]
        public IHttpActionResult PostNews(News news)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.News.Add(news);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = news.Id }, news);
        }

        // DELETE: api/News/5
        [ResponseType(typeof(News))]
        public IHttpActionResult DeleteNews(int id)
        {
            News news = db.News.Find(id);
            if (news == null)
            {
                return NotFound();
            }

            db.News.Remove(news);
            db.SaveChanges();

            return Ok(news);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NewsExists(int id)
        {
            return db.News.Count(e => e.Id == id) > 0;
        }
    }
}