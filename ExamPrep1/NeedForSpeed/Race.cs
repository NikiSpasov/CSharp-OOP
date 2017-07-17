
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Race
{

    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;
    public static Dictionary<int, Race> Races;

    public Race(int length, string route, int prizePool, List<Car> participants)
    {
        Length = length;
        Route = route;
        PrizePool = prizePool;
        Participants = participants;
    }

    public string PrintRaceResults(Race race)
    {
        if (race.Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }
        StringBuilder raceResults = new StringBuilder();
        raceResults.AppendLine($"{race.Route} - {race.Length}");
        //foreach (var p in race.Participants.OrderBy(x => x.moneyWon))
        //{
        //    raceResults.AppendLine($"{cnt}. {p.Brand} {p.Model} {p.PerformancePoints}PP - ${moneyWon}");
        //    cnt++;
        //}
        return raceResults.ToString();

    }

    public void RaceCreator(int id, Race race)
    {
        Races.Add(id, race);
    }

    public static Race RaceExtractor(int id)
    {
        return Races[id];
    }

    public int Length
    {
        get { return this.length; }
        set { this.length = value; }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        set { this.prizePool = value; }
    }

    public string Route
    {
        get { return this.route; }
        set { this.route = value; }
    }

    public List<Car> Participants
    {
        get { return this.participants; }
        set { this.participants = value; }
    }
}
