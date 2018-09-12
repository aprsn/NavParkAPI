using System.Threading.Tasks;
using NavPark_API.Models;

namespace NavPark_API.data
{
    public interface IAuthRepository
    {
         Task<Users> Register(Users users, string password);
         Task<Users> Login(string username, string password);
         Task<bool> UserExists(string username); 
    }
}