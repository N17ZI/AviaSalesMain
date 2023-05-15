using AviaDB.Models;

namespace AviaDB
{
    public interface IVoyageData
    {
        Task<List<VoyageModel>> GetVoyage();
        Task InsertVoyage(VoyageModel voyage);
    }
}