using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectManager.Models;
using ProjectManager.Models.ViewModels;

namespace ProjectManager.Controllers
{
    public class TaskmodelsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Taskmodels
        public IQueryable<Taskmodel> GetTasks()
        {
            IQueryable<Taskmodel> query = db.Tasks.Include(t => t.story);

            return query; 
        }

        // GET: api/Taskmodels/5
        [ResponseType(typeof(Taskmodel))]
        public async Task<IHttpActionResult> GetTaskmodel(int id)
        {
            Taskmodel taskmodel = await db.Tasks.FindAsync(id);
            if (taskmodel == null)
            {
                return NotFound();
            }

            return Ok(taskmodel);
        }

        // PUT: api/Taskmodels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTaskmodel(int id, TaskViewModel taskmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != taskmodel.id)
            {
                return BadRequest();
            }
            Story story = db.Stories.FirstOrDefault(e => e.id == taskmodel.storyId);
            Taskmodel task = new Taskmodel();
            task.story = story;
            task.name = taskmodel.name;
            task.description = taskmodel.description;
            task.priority = taskmodel.priority;
            task.estimate = taskmodel.estimate;
            task.status = taskmodel.status;
            db.Entry(task).State = EntityState.Modified;
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskmodelExists(id))
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

        // POST: api/Taskmodels
        [ResponseType(typeof(Taskmodel))]
        public async Task<IHttpActionResult> PostTaskmodel(TaskViewModel taskmodel)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            Story story = db.Stories.FirstOrDefault(e => e.id == taskmodel.storyId);
            Taskmodel task = new Taskmodel();
            task.story = story;
            task.name = taskmodel.name;
            task.description = taskmodel.description;
            task.priority = taskmodel.priority;
            task.estimate = taskmodel.estimate;
            task.status = taskmodel.status;
            task.createdAt = DateTime.Now;
            db.Tasks.Add(task);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = task.id }, task);
        }

        // DELETE: api/Taskmodels/5
        [ResponseType(typeof(Taskmodel))]
        public async Task<IHttpActionResult> DeleteTaskmodel(int id)
        {
            Taskmodel taskmodel = await db.Tasks.FindAsync(id);
            if (taskmodel == null)
            {
                return NotFound();
            }

            db.Tasks.Remove(taskmodel);
            await db.SaveChangesAsync();

            return Ok(taskmodel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TaskmodelExists(int id)
        {
            return db.Tasks.Count(e => e.id == id) > 0;
        }
    }
}