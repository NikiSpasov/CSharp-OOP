namespace RecyclingStation.WasteDisposal.Attributes
{
    using System;

    /// <summary>
    /// An attribute class, that represents the base of all Disposable Attribute classes.
    /// </summary>
    
    [AttributeUsage(AttributeTargets.Class)]
    public class DisposableAttribute : Attribute
    {
        private Type correspondindStrategyType;

        public DisposableAttribute(Type correspondindStrategyType)
        {
            this.correspondindStrategyType = correspondindStrategyType;
        }

        public Type CorrespondindStrategyType
        {
            get => correspondindStrategyType;
            private set => correspondindStrategyType = value;
        }
    }
}
