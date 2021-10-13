using System;
using System.Linq;
using WebApplication.Shared.Models;


namespace WebApplication.Shared.Persistence
{
    public class UserPer : IUserPer
    {
        
        public static UserPer Instance() {
            if (_instance == null) {
                lock (typeof(UserPer)) {
                    if (_instance == null) {
                        _instance = new UserPer();
                    }
                }
            }
            return _instance;      
        }
        protected UserPer() {}
        private static volatile UserPer _instance = null;
        
        private FileContext fileContext;

        public UserPer(FileContext fileContext)
        {
            this.fileContext = fileContext;
        }

        public void CreateUser(User user)
        {
            if (user == null)
                throw new ArgumentException("Fill in all the fields");

            try
            {
                User exists = fileContext.Users.FirstOrDefault(u => u.Username.Equals(user.Username));
                if (exists != null) throw new AggregateException("Username already exists");
                fileContext.Users.Add(user);
                fileContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public User ValidateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username)) throw new AggregateException("Invalid username or password");
            if (string.IsNullOrEmpty(password)) throw new AggregateException("Invalid username or password");

            User user = fileContext.Users.FirstOrDefault(u => u.Username.Equals(username));
            if (user == null) throw new ArgumentException("Invalid user");
            if (!user.Password.Equals(password)) throw new AggregateException("Invalid password!");

            return user;
        }
    }
}