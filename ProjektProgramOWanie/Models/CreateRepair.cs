using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektProgramOWanie.Models
{
    public class CreateRepair
    {
        public int Id { get; set; }
        public string Plate { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public string EmployeeName { get; set; }

    }
}
