using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BusinessLayer.Strategies
{
    using RecyclingStation.BusinessLayer.Extensions;
    using RecyclingStation.WasteDisposal.Interfaces;

    class RecyclableGarbageDisposalStrategy : GarbageDisposalStrategy
    {

        protected override double CalculateCapitalBalance(IWaste garbage)
        {
            double capitalEarned = garbage.Weight * 400;
            return capitalEarned;
        }

        protected override double CalculateEnergyBalance(IWaste garbage)
        {
            double energyProduced = 0;
            double energyUsed = garbage.CalculateWasteTotalVolume() * 0.5;

            return energyProduced - energyUsed;
        }
    }
}
