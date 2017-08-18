using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BusinessLayer.Extensions
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public static class WasteExtensionMethod
    {
        public static double CalculateWasteTotalVolume(this IWaste waste)
        {
            return waste.Weight * waste.VolumePerKg;
        }
    }
}
