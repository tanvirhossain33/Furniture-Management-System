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
    public class HomesController : ApiController
    {
        private ApplicationContext db = new ApplicationContext();

        // GET: api/Homes
        public List<Home> Get()
        {
            var homes = db.homes.AsEnumerable();
            List<Home> list = homes.Select(c => new Home() { Id = c.Id, Phone = c.Phone, Address = c.Address }).ToList();
            return list;
        }


        // POST: api/Homes
        public bool Post(Home home)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }

            db.homes.Add(home);
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