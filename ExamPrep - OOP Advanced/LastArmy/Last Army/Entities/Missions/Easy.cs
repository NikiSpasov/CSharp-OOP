public class Easy : Mission
{
    private const string NameOfTheMission = "Suppression of civil rebellion";
    private const double WearLevelDecrease = 30;
    private const double EndurDecrease = 20;
    private const double EndurRequired = 20;

    public Easy(double scoreToComplete) : base(NameOfTheMission, scoreToComplete, WearLevelDecrease,
        EndurDecrease, EndurRequired)
    {
        this.ScoreToComplete = scoreToComplete;
    }
}

