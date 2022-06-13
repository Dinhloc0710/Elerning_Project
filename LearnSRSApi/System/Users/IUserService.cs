using LearnSRSApi.Models;

namespace LearnSRSApi.System.Users
{
    public interface IUserService
    {
        List<User> GetAllUser();
        void AddUser(UserRegister request);
        void Login(UserLogin request);
        void Verify(string token);
        void ForgotPassword(string email);
    }
}
