namespace RecyclingStation.BusinessLayer.Attributes
{
    using System;
    using System.Runtime.CompilerServices;
    using RecyclingStation.WasteDisposal.Attributes;

    public class BurnableStrategyAttribute : DisposableAttribute
    {
        public BurnableStrategyAttribute(Type correspondindStrategyType) 
            : base(correspondindStrategyType)
        {

        }
    }
}
