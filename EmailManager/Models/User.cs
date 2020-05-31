using System.Collections.Generic;
using System.Linq;

namespace EmailManager.Models
{
    public class User
    {
        private readonly long _id;

        public User( long id)
        {
            _id = id;
        }

        public List<string> getEmails()
        {
            var list = new List<string>();

            using (var db = new EmailDatabaseEntities())
            {
                if (db.Emails!= null)
                {
                    list = db.Emails.Where(e => e.UserId == this._id).Select(e => e.Email).ToList();
                }
            }

            return list;
        }
    }
}