namespace RecyclingStation.BusinessLayer.Attributes
{
    using System;
    using RecyclingStation.WasteDisposal.Attributes;

    public class RecycableStrategyAttribute : DisposableAttribute
    {
        public RecycableStrategyAttribute(Type correspondindStrategyType) : base(correspondindStrategyType)
        {
        }
    }
}
