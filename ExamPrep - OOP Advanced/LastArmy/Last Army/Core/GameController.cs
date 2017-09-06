using System;
using System.Linq;
using System.Text;

public class GameController
{
    private IArmy army;
    private IWareHouse wareHouse;
    private MissionController missionController;
    private MissionFactory missionFactory;
    private SoldierFactory soldierFactory;
    private AmmunitionFactory ammunitionFactory;
    IWriter writer = new ConsoleWriter();
    //IReader reader = new ConsoleReader();

    public GameController()
    {
        this.missionFactory = new MissionFactory();
        this.army = new Army();
        this.soldierFactory = new SoldierFactory();
        this.ammunitionFactory = new AmmunitionFactory();
        this.wareHouse = new WareHouse();
        this.missionController = new MissionController(this.army, this.wareHouse);

    }

    public string RequestResult()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Results:");
        sb.AppendLine($"Successful missions - {this.missionController.SuccessMissionCounter}");
        sb.AppendLine($"Failed missions - {this.missionController.FailedMissionCounter}");
        sb.AppendLine($"Soldiers:");
        foreach (var soldier in this.army.Soldiers.OrderByDescending(x => x.OverallSkill))
        {
            sb.AppendLine($"{soldier.Name} - {soldier.OverallSkill}");
        }
        return sb.ToString().Trim();
    }

    public void InterpretCommands(string input)
    {
        var args = input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

        if (args[0].Equals("Soldier") && args.Length == 6)
        {
            string type = args[1];
            string name = args[2];
            int age = int.Parse(args[3]);
            double experience = double.Parse(args[4]);
            double endurance = double.Parse(args[5]);
            try
            {
                ISoldier currentSoldier = this.soldierFactory.CreateSoldier(type, name, age, experience, endurance);
            //EquipIt    currentSoldier.
                this.army.AddSoldier(currentSoldier);
            }
            catch (Exception e)
            {
                
            }

        }

        else if (args[0].Equals("WareHouse") && args.Length == 3)
        {
            string name = args[1];
            int count = int.Parse(args[2]);
            try
            {
                IAmmunition currentAmunition = this.ammunitionFactory.CreateAmmunition(name);
                this.wareHouse.AddAmmunition(currentAmunition, count);
            }
            catch (Exception e)
            {
              
            }
        }

        else if (args[0].Equals("Mission") && args.Length == 3)
        {
            try
            {
                IMission currentMission = this.missionFactory.CreateMission(args[1], double.Parse(args[2]));
                this.writer.WriteLine(this.missionController.PerformMission(currentMission));
            }
            catch (Exception e)
            {
                
            }
        }

        else if (args[0].Equals("Soldier") && args.Length == 3 && args[1].Equals("Regenerate"))
        {
            this.army.RegenerateTeam(args[2]);
        }
    }
}
