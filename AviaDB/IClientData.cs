using AviaDB.Models;

namespace AviaDB
{
    public interface IClientData
    {
        Task InsertClient(ClientModel client);
    }
}