using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace EmailManager.Models
{
    public class UserList
    {
        private readonly string _connection;
        public List<User> Users { get; private set; }

        public int SelectedId { get; }

        public UserList()
        {
            this._connection = ConfigurationManager.ConnectionStrings?["DefaultConnection"]?.ConnectionString;

            this.SelectedId = 0;
        }

        public UserList GetAll()
        {
            var list = new List<User>();

            if (!string.IsNullOrWhiteSpace(this._connection))
            {
                using (var dbConnection = new SqlConnection(this._connection))
                {
                    var getDataCommand = dbConnection.CreateCommand();
                    getDataCommand.CommandText = "select Id,Name from Users";
                    dbConnection.Open();

                    var result = getDataCommand.ExecuteReader();
                    while (result.Read())
                    {
                        var id = result.GetInt64(0);
                        var name = result.GetString(1);
                        var user = new User(id, name);
                        list.Add(user);
                    }

                    dbConnection.Close();
                }
            }

            Users = list;

            return this;
        }
    }

}