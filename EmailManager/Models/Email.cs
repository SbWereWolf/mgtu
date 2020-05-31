using System;

namespace EmailManager.Models
{
    public class Email
    {
        private readonly long _userId;
        private readonly string _email;

        public Email( long userId, string email)
        {
            _userId = userId;
            _email = email;
        }

        public bool Write()
        {

            bool isSuccess;
            using (var db = new EmailDatabaseEntities())
            {
                try
                {
                    db.Emails?.Add(new Emails()
                    {
                        Email = this._email,
                        UserId = this._userId
                    });
                    db.SaveChanges();

                    isSuccess = true;
                }
                catch (Exception)
                {
                    isSuccess = false;
                }
            }

            return isSuccess;
        }
    }
}