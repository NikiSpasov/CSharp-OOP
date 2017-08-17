using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WorkForce
{
    class StandartBaseEmploee : BaseEmploee
    {
        public string Name { get; }
        public int WorkHoursPerWeek { get; }

        public StandartBaseEmploee(string name)
        {
            this.WorkHoursPerWeek = 40;
            this.Name = name;
        }
    }
}
