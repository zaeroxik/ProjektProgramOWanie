using Microsoft.EntityFrameworkCore;
using ProjektProgramOWanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjektProgramOWanie
{
    public class AccountService
    {
        private readonly appDbContext _dbContext;

        public AccountService(appDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Checking the existence of the user and the correctness of the password using BCrypt - string to hash converter.
        /// </summary>
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
        /// <summary>
        /// Creating new employee and saving to database
        /// </summary>
        public List<Employee> GetEmployees()
        {
            return _dbContext.Employees.ToList();
        }
        /// <summary>
        /// Creating new employee and saving to database
        /// </summary>
        public bool CreateEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return true;
        }

        /// <summary>
        /// Deleting current object from database and saving
        /// </summary>
        public void DeleteEmployee(string id)
        {
            var rep = _dbContext.Employees.FirstOrDefault(x => x.Id.Equals(Int32.Parse(id)));
            if (rep != null)
            {
                _dbContext.Employees.Remove(rep);
                _dbContext.SaveChanges();
            }
        }
    }
}
