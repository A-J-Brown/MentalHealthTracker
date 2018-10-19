using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
#pragma warning disable CS0234 // The type or namespace name 'Http' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Http;
#pragma warning restore CS0234 // The type or namespace name 'Http' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)

namespace MentalHealthTracker.Api.Controllers
{
#pragma warning disable CS0246 // The type or namespace name 'ApiController' could not be found (are you missing a using directive or an assembly reference?)
    public class ValuesController : ApiController
#pragma warning restore CS0246 // The type or namespace name 'ApiController' could not be found (are you missing a using directive or an assembly reference?)
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
#pragma warning disable CS0246 // The type or namespace name 'FromBody' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'FromBodyAttribute' could not be found (are you missing a using directive or an assembly reference?)
        public void Post([FromBody]string value)
#pragma warning restore CS0246 // The type or namespace name 'FromBodyAttribute' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'FromBody' could not be found (are you missing a using directive or an assembly reference?)
        {
        }

        // PUT api/values/5
#pragma warning disable CS0246 // The type or namespace name 'FromBodyAttribute' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'FromBody' could not be found (are you missing a using directive or an assembly reference?)
        public void Put(int id, [FromBody]string value)
#pragma warning restore CS0246 // The type or namespace name 'FromBody' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'FromBodyAttribute' could not be found (are you missing a using directive or an assembly reference?)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
