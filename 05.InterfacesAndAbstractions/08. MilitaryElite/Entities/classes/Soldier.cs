using System.Text;

public abstract class Soldier : ISoldier
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Id { get; }

        protected Soldier(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {FirstName} {LastName} Id: {Id}");
            return sb.ToString().Trim();
        }
    }

