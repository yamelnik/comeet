using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Api.Controllers
{
    public class ProfileController : ApiController
    {
        private IDbHandler DbHandler;

        public ProfileController(IDbHandler dbHandler)
        {
            DbHandler = dbHandler;
        }

        public User Get([FromBody]Guid userId)
        {
            return DbHandler.GetUser(userId);
        }

        public void Post([FromBody] User user)
        {
            DbHandler.AddNewUser(user);
        }

        [HttpPut]
        public void AddTag([FromBody]Guid userGuid, [FromBody]Tag tag)
        {
            DbHandler.AddTagToUser(userGuid, tag);
        }
        
        public void Put([FromBody]Guid userId, [FromBody]User user)
        {
            DbHandler.UpdateUser(userId, user);
        }
    }
}
