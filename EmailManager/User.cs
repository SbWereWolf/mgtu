using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailManager
{
    public class User
    {
        public long Id { get; }
        public string Name { get; }

        public User(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}