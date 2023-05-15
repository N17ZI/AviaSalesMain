using AviaDB.Models;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaDB
{
    public class VoyageData : IVoyageData
    {
        private readonly ISqlDataAccess _db;

        public VoyageData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<VoyageModel>> GetVoyage()
        {
            string sql = "select * from dbo.voyage";

            return _db.LoadData<VoyageModel, dynamic>(sql, new { });
        }

        public Task InsertVoyage(VoyageModel voyage)
        {
            string sql = @"insert into dbo.voyage (id_voyage, from_place, to_place,seat)
                           values (@id_voyage, @from_place, @to_place,@seat);";

            return _db.SaveData(sql, voyage);
        }
    }
}
