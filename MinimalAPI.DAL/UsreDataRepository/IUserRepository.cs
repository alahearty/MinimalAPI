using MinimalAPI.DAL.Models;

namespace MinimalAPI.DAL.UsreDataRepository;

public interface IUserRepository
{
    Task DeleteUser(int id);
    Task<UserModel?> GetUser(int id);
    Task<IEnumerable<UserModel>> GetUsers();
    Task InsertUser(UserModel user);
    Task UpdateUser(UserModel user);
}