using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BusinessLayer.Attributes
{
    using RecyclingStation.WasteDisposal.Attributes;

    public class StorableStrategyAttribute : DisposableAttribute
    {
        public StorableStrategyAttribute(Type correspondindStrategyType) 
            : base(correspondindStrategyType)
        {
        }
    }
}
