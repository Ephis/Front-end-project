using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectManager.Models;

namespace ProjectManager.Controllers
{
    public class StoriesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Stories
        public IQueryable<Story> GetStories()
        {
            return db.Stories;
        }

        // GET: api/Stories/5
        [ResponseType(typeof(Story))]
        public async Task<IHttpActionResult> GetStory(int id)
        {
            Story story = await db.Stories.FindAsync(id);
            if (story == null)
            {
                return NotFound();
            }

            return Ok(story);
        }

        // PUT: api/Stories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutStory(int id, Story story)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != story.id)
            {
                return BadRequest();
            }

            db.Entry(story).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryExists(id))
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

        // POST: api/Stories
        [ResponseType(typeof(Story))]
        public async Task<IHttpActionResult> PostStory(Story story)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Stories.Add(story);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = story.id }, story);
        }

        // DELETE: api/Stories/5
        [ResponseType(typeof(Story))]
        public async Task<IHttpActionResult> DeleteStory(int id)
        {
            Story story = await db.Stories.FindAsync(id);
            if (story == null)
            {
                return NotFound();
            }

            db.Stories.Remove(story);
            await db.SaveChangesAsync();

            return Ok(story);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StoryExists(int id)
        {
            return db.Stories.Count(e => e.id == id) > 0;
        }
    }
}