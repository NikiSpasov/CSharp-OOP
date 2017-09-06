public abstract class Mission : IMission
{
    private string name;
    private double scoreToComplete;
    private double enduranceRequired;
    private double wearLevelDecrecement;
    private double endruranceLevelDecrease;

    public Mission(string name, double scoreToComplete, double wearLevelDecrecement,
        double enduranceLevelDecrease, double enduranceLevelRequired)
    {
        this.Name = name;
        this.ScoreToComplete = scoreToComplete;
        this.WearLevelDecrecement = wearLevelDecrecement;
        this.EndruranceLevelDecrease = enduranceLevelDecrease;
        this.EnduranceRequired = enduranceLevelRequired;
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public double EnduranceRequired
    {
        get => this.enduranceRequired;
        set => this.enduranceRequired = value;
    }

    public double ScoreToComplete
    {
        get => this.scoreToComplete;
        set => this.scoreToComplete = value;
    }

    public double WearLevelDecrecement
    {
        get => this.wearLevelDecrecement;
        set => this.wearLevelDecrecement = value;
    }
    public double EndruranceLevelDecrease
    {
        get => this.endruranceLevelDecrease;
        set => this.endruranceLevelDecrease = value;
    }
}

