using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjektProgramOWanie
{
    public class LoginService
    {
        private readonly appDbContext _dbContext;

        public LoginService(appDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Authenticate(string username, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Username.Equals(username));
            if (user != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                { return true; }
                else
                { return false; }
            }
            else { return false; }

        }
    }
}
