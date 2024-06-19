using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.controllers
{
    public class CatagoryController : ApiController
    {
        // GET: api/Catagory
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Catagory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Catagory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Catagory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Catagory/5
        public void Delete(int id)
        {
        }
    }
}
