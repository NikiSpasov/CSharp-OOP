using System.Runtime.InteropServices;

public interface ICar
{
    string Make { get; }
    string Model { get; }
    string Driver { get; }

    string UseBreaks();

    string PushGasPedal();
}

