using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WorkForce
{
    class PartTimeBaseEmploee : BaseEmploee
    {
        public string Name { get; }
        public int WorkHoursPerWeek { get; }

        public PartTimeBaseEmploee(string name)
        {
            this.Name = name;
            this.WorkHoursPerWeek = 20;
        }
    }
}
