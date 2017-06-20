using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SearchController : ApiController
    {
        private IDbHandler DbHandler;

        public SearchController(IDbHandler dbHandler)
        {
            DbHandler = dbHandler;
        }

        public IEnumerable<User> Post([FromBody]Tag[] tags)
        {
            return DbHandler.GetUsersByTags(tags.AsEnumerable()); 
        }
        
        public IEnumerable<User> Post([FromBody]string value)
        {
            return DbHandler.GetUsersByString(value);
        }
    }
}
