using System.Collections.Generic;
using System.Web.Http;
using EmailManager.Models;

namespace EmailManager.Controllers
{
    public class UserController : ApiController
    {

        // GET: api/User/5
        public List<string> Get(long id)
        {
            var emails = (new User(id)).getEmails();

            return emails;
        }
    }
}
