namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string UnitNameSpace = "_03BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            Type typeUnit = Type.GetType(UnitNameSpace + unitType);
            IUnit initInstance = (IUnit)Activator.CreateInstance(typeUnit);
            return initInstance;
        }
    }
}
