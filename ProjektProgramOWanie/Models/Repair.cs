using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektProgramOWanie.Models
{
    public class Repair
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool isDone { get; set; }
        public int Price { get; set; }

        public Vehicle Vehicle { get; set; }
        public Employee Employee { get; set; }

    }
}
