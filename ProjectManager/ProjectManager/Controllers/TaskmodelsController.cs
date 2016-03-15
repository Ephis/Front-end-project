﻿using System;
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
    public class TaskmodelsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Taskmodels
        public IQueryable<Taskmodel> GetTasks()
        {
            return db.Tasks;
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
        public async Task<IHttpActionResult> PutTaskmodel(int id, Taskmodel taskmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != taskmodel.id)
            {
                return BadRequest();
            }

            db.Entry(taskmodel).State = EntityState.Modified;

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
        public async Task<IHttpActionResult> PostTaskmodel(Taskmodel taskmodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tasks.Add(taskmodel);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = taskmodel.id }, taskmodel);
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