using Microsoft.EntityFrameworkCore;
using ProjektProgramOWanie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

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
        public List<Repair> GetCurrentRepairs(string plate)
        {
            var repairs = _dbContext.Repairs.Include(x=>x.Employee).Where(x => x.Vehicle.Plate.Equals(plate)).Where(x=>x.isDone == false).ToList();
            return repairs;
        }
        public List<Repair> GetDoneRepairs(string plate)
        {
            var repairs = _dbContext.Repairs.Include(x => x.Employee).Where(x => x.Vehicle.Plate.Equals(plate)).Where(x => x.isDone == true).ToList();
            return repairs;
        }
        public bool CreateRepair(CreateRepair model)
        {
            var vehicle = _dbContext.Vehicles.FirstOrDefault(x => x.Plate.Equals(model.Plate));
            if (vehicle is null) return false;
            else
            {
                var employee = _dbContext.Employees.FirstOrDefault(x => x.FullName.Equals(model.EmployeeName));
                if (employee is null) return false;
                else
                {
                    var r = new Repair()
                    {
                        Description = model.Description,
                        Price = model.Price,
                        isDone = false,
                        Employee = employee,
                        Vehicle = vehicle
                    };
                    _dbContext.Repairs.Add(r);
                    _dbContext.SaveChanges();
                    return true;
                }
            }
        }

        public void FinishRepair(string id)
        {
           var repair =  _dbContext.Repairs.FirstOrDefault(x=>x.Id.Equals(Int32.Parse(id)));
           if(repair is null) return;
            else
            {
                repair.isDone = true;
                _dbContext.SaveChanges();
            }
        }
        public void DeleteOrder(string plate)
        {
            var veh = _dbContext.Vehicles.FirstOrDefault(x => x.Plate.Equals(plate));
            if (veh != null)
            {
                _dbContext.Vehicles.Remove(veh);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteRepair(string id)
        {
            var rep = _dbContext.Repairs.FirstOrDefault(x => x.Id.Equals(Int32.Parse(id)  ));
            if (rep != null)
            {
                _dbContext.Repairs.Remove(rep);
                _dbContext.SaveChanges();
            }
        }
    }
}
