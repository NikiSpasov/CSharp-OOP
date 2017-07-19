using System.Text;

public class Tesla : Car, IElectricCar
{
    private int battery;

    public int Battery
    {
        get { return this.battery; }
        private set { this.battery = value; }
    }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Color} {nameof(Tesla)} {base.Model} with {this.Battery} Batteries");
            sb.AppendLine(base.ToString());
            return sb.ToString().Trim();
        }

        public Tesla(string model, string color, int battery) : base(model, color)
        {
            Battery = battery;
        }

    }

