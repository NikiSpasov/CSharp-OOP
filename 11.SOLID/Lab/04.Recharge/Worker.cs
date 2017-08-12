namespace _04.Recharge
{
    public abstract class Worker : IWorker
    {
        private string id;
        protected int workingHours;

        public Worker(string id)
        {
            this.Id = id;
        }

        public void Work(int hours)
        {
            this.workingHours += hours;
        }

        public string Id
        {
            get => this.id;
            private set => this.id = value;
        }

    }
}