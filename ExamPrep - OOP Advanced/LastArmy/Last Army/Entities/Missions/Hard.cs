public class Hard : Mission
{
    private const string NameOfTheMission = "“Disposal of terrorists";
    private const double WearLevelDecrease = 70;
    private const double EndurDecrease = 80;
    private const double EndurRequired = 80;

    public Hard(double scoreToComplete) : base(NameOfTheMission, scoreToComplete, WearLevelDecrease,
        EndurDecrease, EndurRequired)
    {
        this.ScoreToComplete = scoreToComplete;
    }
}

