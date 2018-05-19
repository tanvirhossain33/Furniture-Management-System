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
    public class FurnitureTypesController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: api/FurnitureTypes
        public List<FurnitureType> Get()
        {
            var types = db.furnitureTypes.AsEnumerable();
            List<FurnitureType> list = types.Select(c => new FurnitureType() { Id = c.Id, Type = c.Type }).ToList();
            return list;
        }

        // POST: api/FurnitureTypes
        public bool Post(FurnitureType furnitureType)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }

            db.furnitureTypes.Add(furnitureType);
            db.SaveChanges();

            return true;
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