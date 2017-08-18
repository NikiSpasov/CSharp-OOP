namespace RecyclingStation.BusinessLayer.Strategies
{
    using RecyclingStation.BusinessLayer.Extensions;
    using RecyclingStation.WasteDisposal.Interfaces;

    public class BurnableGarbageDisposalStrategy : GarbageDisposalStrategy
    {
        protected override double CalculateEnergyBalance(IWaste garbage)
        {
            double totalVolume = garbage.CalculateWasteTotalVolume();

            double energyProduced = totalVolume;
            double energyUsed = totalVolume * 0.2;

            return energyProduced - energyUsed;
        }

        protected override double CalculateCapitalBalance(IWaste garbage)
        {
            return 0;
        }
    }
}
