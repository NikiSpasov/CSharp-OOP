namespace RecyclingStation.WasteDisposal.Models
{
    using RecyclingStation.WasteDisposal.Interfaces;

    public abstract class Garbage : IWaste
    {
        private string name;
        private double volumePerKg;
        private double weight;

        public Garbage(string name, double weight, double volumePerKg)
        {
            this.Name = name;
            this.VolumePerKg = volumePerKg;
            this.Weight = weight;
        }

        public IGarbageDisposalStrategy DisposalStrategy { get; protected set; }

        public string Name { get => this.name; set => this.name = value; }

        public double VolumePerKg { get => this.volumePerKg; set => this.volumePerKg = value; }

        public double Weight { get => weight; set => weight = value; }
    }
}
