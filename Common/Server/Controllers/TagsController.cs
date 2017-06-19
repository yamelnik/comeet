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
    public class TagsController : ApiController
    {
        private IDbHandler DbHandler;
        public TagsController(IDbHandler dbHandler)
        {
            DbHandler = dbHandler;
        }
        
        public IEnumerable<Tag> Get()
        {
            return DbHandler.GetAllTags();
        }
        
        public IEnumerable<Tag> Get(string category)
        {
            return DbHandler.GetAllTagsInCategory(category);
        }
        
    }
}
