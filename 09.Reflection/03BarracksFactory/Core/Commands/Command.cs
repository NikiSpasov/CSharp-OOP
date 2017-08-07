using _03BarracksFactory.Contracts;
using _03BarracksFactory.Core.Factories;

namespace _03BarracksFactory.Core.Commands
{
    public abstract class Command : IExecutable

    {
    private string[] data;  

    protected Command(string[] data)
    {
        this.Data = data;
     
    }

    protected string[] Data
    {
        get => this.data;
        set => this.data = value;
    }
        public abstract string Execute();
    }
}
