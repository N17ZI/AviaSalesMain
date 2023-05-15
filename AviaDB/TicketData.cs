using AviaDB.Models;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaDB
{
    public class TicketData : ITicketData
    {
        private readonly ISqlDataAccess _db;

        public TicketData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<TicketModel>> GetTicket()
        {
            string sql = "select * from dbo.Ticket";

            return _db.LoadData<TicketModel, dynamic>(sql, new { });
        }

        public Task InsertTicket(TicketModel ticket)
        {
            string sql = @"insert into dbo.Ticket (id_ticket, Date_start,Summ,Seat,id_clients,Date_end,voyage)
                           values (@id_ticket, @Date_start,@Summ,@Seat,@id_clients,@Date_end,@voyage);";

            return _db.SaveData(sql, ticket);
        }
    }
}
