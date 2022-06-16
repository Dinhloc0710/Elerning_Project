using LearnSRSApi.Models;

namespace LearnSRSApi.Models
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUser();
        User get(int id);
        public void AddUser(UserRegister request);
        public void CreateUser(User user);
        public void UpdateUser(User user, int id);
        public void DeleteUser(int id);

        public void Login(UserLogin request);
        public void Verify(string token); 
        public void ForgotPassword(string email);
    }
}
