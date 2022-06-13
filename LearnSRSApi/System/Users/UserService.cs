using LearnSRSApi.Data;
using LearnSRSApi.Models;
using System.Security.Cryptography;

namespace LearnSRSApi.System.Users
{

    public class UserService : IUserService

    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }
        public void AddUser(UserRegister request)
        {
           /* CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
            var user = new User
            {
                Email = request.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                RoleId = request.RoleId,
            };
            _context.Users.Add(user);
            _context.SaveChanges();*/
        }

        public void ForgotPassword(string email)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public void Login(UserLogin request)
        {
            throw new NotImplementedException();
        }

        public void Verify(string token)
        {
            throw new NotImplementedException();
        }

        /*private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }*/
    }
}
