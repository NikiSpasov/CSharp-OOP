using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BusinessLayer.Contracts.Core
{
    public interface IRecyclingStation
    {
        string ProcessGarbage(string name, double weight, double volumePerKg, string type);

        string Status();
    }
}
