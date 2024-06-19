using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopWebApi.controllers
{
    public class CatagoryController : ApiController
    {
        // GET: api/Category
        public List<Catagory> Get()
        {
            return Catagory.GetAll();
        }

        // GET: api/Category/5
        public Catagory Get(int id)
        {
            return Catagory.GetByiD(id);
        }

        // POST: api/Category
        public void Post([FromBody]Catagory value)
        {
            value.Cid = -1;
            value.Save();
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]Catagory value)
        {
            value.Cid = id;
            value.Save();
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
            Catagory.DeleteByiD(id);    
        }
    }
}
