using AviaDB.Models;

namespace DataAccessLibrary
{
    public interface IUserData
    {
        Task<List<UserModel>> GetPeople();
        Task InsertPerson(UserModel user);
    }
}