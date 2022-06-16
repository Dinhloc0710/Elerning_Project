using LearnSRSApi.Data;
using LearnSRSApi.Models;
using System.Security.Cryptography;

namespace LearnSRSApi.Models
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
            CreatePasswordHash(request.Password,
                     out byte[] passwordHash,
                     out byte[] passwordSalt);
            var user = new User
            {
                Email = request.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                RoleId = request.RoleId,
                VerificationToken = CreateRandomToken()
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }

    public void CreateUser(User user)
    {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

    public void DeleteUser(int id)
    {
            var user = _context.Users.FirstOrDefault(x => x.UserId == id);


            _context.Users.Remove(user);
            _context.SaveChanges();
        }

    public void ForgotPassword(string email)
    {
        throw new NotImplementedException();
    }

 

    public IEnumerable<User> GetAllUser()
    {
            return _context.Users.ToList();
        }

    public void Login(UserLogin request)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user, int id)
    {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
        public User get(int id)
        {
            throw new NotImplementedException();
        }
        public void Verify(string token)
        {
            var user = _context.Users.FirstOrDefault(u => u.VerificationToken == token);
            if (user == null)
            {
                //invalid token
            }

            user.VerifiedAt = DateTime.Now;
            _context.SaveChangesAsync();

        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        private string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac
                    .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        
    } 
        
}
