public class Medium : Mission
{
    private const string NameOfTheMission = "Capturing dangerous criminals";
    private const double WearLevelDecrease = 50;
    private const double EndurDecrease = 50;
    private const double EndurRequired = 50;

    public Medium(double scoreToComplete) : base(NameOfTheMission, scoreToComplete, WearLevelDecrease,
        EndurDecrease, EndurRequired)
    {
        this.ScoreToComplete = scoreToComplete;
    }
}

