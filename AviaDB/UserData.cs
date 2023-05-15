using AviaDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<UserModel>> GetPeople()
        {
            string sql = "select * from dbo.Users";

            return _db.LoadData<UserModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(UserModel user)
        {
            string sql = @"insert into dbo.Users (Login, Password, Role)
                           values (@Login, @Password, @Role);";

            return _db.SaveData(sql, user);
        }
    }
}
