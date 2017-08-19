using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTutorial.Cars
{
    public abstract class Car : ICar
    {
        private string brand;
        private string model;
        private int yearOfProduction;

        protected Car(string brand, string model, int yearOfProduction)
        {
            this.Brand = brand;
            this.Model = model;
            this.YearOfProduction = yearOfProduction;
        }

        public Car()
        {
            
        }

        public string Brand
        {
            get => brand;
            protected set => brand = value;
        }

        public string Model
        {
            get => model;
            protected set => model = value;
        }

        public int YearOfProduction
        {
            get => yearOfProduction;
            protected set => yearOfProduction = value;
        }

        public abstract void BestCarsInfo();

        public abstract void Drive(int num);
        
        public abstract void GiveMeTheYear();
    }
}
