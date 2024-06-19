using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopWebApi.controllers
{
    public class ClientController : ApiController
    {
        // GET: api/Client
        public List<Client> Get()
        {
            return Client.GetAll();
        }

        // GET: api/Client/5
        public Client Get(int id)
        {
            return Client.GetByiD(id);
        }

        // POST: api/Client
        public void Post([FromBody]Client value)
        {
            value.ClientId = -1;
            value.Save();
        }

        // PUT: api/Client/5
        public void Put(int id, [FromBody]Client value)
        {
            value.ClientId = id; 
            value.Save();
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
            Client.DeleteByiD(id);
        }
    }
}
