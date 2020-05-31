using System.Web.Http;
using EmailManager.Models;

namespace EmailManager.Controllers
{
    public class EmailController : ApiController
    {
        // POST: api/Email
        public bool Post([FromBody]Email data)
        {
            var result = false;
            if (data!= null)
            {
                result = data.Write();
            }

            return result;
        }
    }
}
