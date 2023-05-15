using AviaDB.Models;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaDB
{
    public class ClientData : IClientData
    {
        private readonly ISqlDataAccess _db;

        public ClientData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task InsertClient(ClientModel client)
        {
            string sql = @"insert into dbo.Client (id_users, First_name, Last_name,Passport,Email,Phone)
                           values (@id_users, @First_name, @Last_name,@Passport,@Email,@Phone);";

            return _db.SaveData(sql, client);
        }
    }
}
