
using System.Linq.Expressions;

namespace _01.EventImplementation
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs e);

    public class Dispatcher
    {
        private string name;
        private NameChangeEventArgs args;

        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get => this.name;
            set
            {
                this.name = name;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            if (NameChange != null)
            {
                NameChange(this, args);
            }
        }
    }
}
