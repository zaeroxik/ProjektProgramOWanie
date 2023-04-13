using ProjektProgramOWanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektProgramOWanie
{
    public class OrderService
    {
        private readonly appDbContext _dbContext;
        public OrderService(appDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool CreateVehicle(Vehicle model)
        {
            var vehicle = _dbContext.Vehicles.FirstOrDefault(x => x.Plate.Equals(model.Id));
            if (vehicle != null) return false;
            else
            {
                _dbContext.Vehicles.Add(model);
                _dbContext.SaveChanges();
                return true;
            }
        }

        public List<Vehicle> GetAll()
        {
            return _dbContext.Vehicles.ToList();
        }
    }
}
