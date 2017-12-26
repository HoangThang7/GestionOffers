using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using GestionOffer.ClientApp.app.Repository;
using GestionOffers.Models;
using log4net;
using log4net.Repository.Hierarchy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Reflection;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GestionOffer.ClientApp.app
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private static UserRepository userRepository = new UserRepository();
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // GET: api/<controller>
        [HttpGet("{id}")]
        public User GetCurrentUser(string id)
        {
            try {
                var res = userRepository.Search(a => a.mail.Equals(id));
                return res;
            } 
            catch (Exception e)
            {
                Log.Error("user Get : " + e.Message + "||" + e.StackTrace);
                throw;
            }

        }
   

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
