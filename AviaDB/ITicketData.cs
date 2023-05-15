using AviaDB.Models;

namespace AviaDB
{
    public interface ITicketData
    {
        Task<List<TicketModel>> GetTicket();
        Task InsertTicket(TicketModel ticket);
    }
}