using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace EmailManager.Models
{
    public class UserList
    {
        public List<Users> Users { get; private set; }

        public int SelectedId { get; }

        public UserList()
        {
            this.SelectedId = 0;
            Users = new List<Users>();
        }

        public UserList GetAll()
        {
            using (var db = new EmailDatabaseEntities() )
            {
                if (db.Users != null)
                {
                    this.Users = db.Users.ToList();
                }
            }

            return this;
        }
    }

}