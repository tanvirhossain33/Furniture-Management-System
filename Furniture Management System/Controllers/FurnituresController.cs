using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Furniture_Management_System.Context;
using Furniture_Management_System.Models;

namespace Furniture_Management_System.Controllers
{
    public class FurnituresController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: api/Furnitures
        public List<Furniture> Get()
        {
            var furnitures =  db.furnitures.AsEnumerable();
            List<Furniture> list = furnitures.Select(c => new Furniture() { Id = c.Id, Weight = c.Weight, FurnitureTypeId = c.FurnitureTypeId, HomeId = c.HomeId }).ToList();
            return list;
        }

        //// GET: api/Furnitures/5
        //[ResponseType(typeof(Furniture))]
        //public IHttpActionResult GetFurniture(int id)
        //{
        //    Furniture furniture = db.furnitures.Find(id);
        //    if (furniture == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(furniture);
        //}

        //// PUT: api/Furnitures/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutFurniture(int id, Furniture furniture)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != furniture.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(furniture).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!FurnitureExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Furnitures
        //[ResponseType(typeof(Furniture))]
        //public IHttpActionResult PostFurniture(Furniture furniture)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.furnitures.Add(furniture);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = furniture.Id }, furniture);
        //}

        //// DELETE: api/Furnitures/5
        //[ResponseType(typeof(Furniture))]
        //public IHttpActionResult DeleteFurniture(int id)
        //{
        //    Furniture furniture = db.furnitures.Find(id);
        //    if (furniture == null)
        //    {
        //        return NotFound();
        //    }

        //    db.furnitures.Remove(furniture);
        //    db.SaveChanges();

        //    return Ok(furniture);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool FurnitureExists(int id)
        //{
        //    return db.furnitures.Count(e => e.Id == id) > 0;
        //}
    }
}