using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BusinessLayer.Strategies
{
    using RecyclingStation.BusinessLayer.Data;
    using RecyclingStation.WasteDisposal.Interfaces;

    public abstract class GarbageDisposalStrategy :IGarbageDisposalStrategy
    {
        protected abstract double CalculateEnergyBalance(IWaste garbage);

        protected abstract double CalculateCapitalBalance(IWaste garbage);

        public IProcessingData ProcessGarbage(IWaste garbage)
        {
            double energyBalance = this.CalculateEnergyBalance(garbage);
            double capitalBalance = this.CalculateCapitalBalance(garbage);

            return new ProcessingData(energyBalance, capitalBalance);
        }
    }
}
