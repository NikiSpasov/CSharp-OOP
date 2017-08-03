using System;
using System.Collections;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        var num = int.Parse(Console.ReadLine());
        TrafficLight firstLight = TrafficLight.Red;
        TrafficLight secondLight = TrafficLight.Yellow;
        TrafficLight thirdLight = TrafficLight.Green;

        try
        {
            Enum.TryParse(input[0], false, out firstLight);
            Enum.TryParse(input[1], false, out secondLight);
            Enum.TryParse(input[2], false, out thirdLight);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
       
        for (int i = 0; i < num; i++)
        {

                //TRY WITH STACK !!!

                 Stack myLightStack = new Stack();
                    
       
                int currentLight = (int)firstLight + 1;
                int nextLight = (int) secondLight + 1;
                int thirdLght = (int) thirdLight + 1;

                if (currentLight > 2)
                {
                    currentLight = 0;
                }
                else if (nextLight > 2)
                {
                    nextLight = 0;
                }
                else if (thirdLght > 2)
                {
                    thirdLght = 0;
                }
                TrafficLight currentTraffic = (TrafficLight) Enum.Parse(typeof(TrafficLight), currentLight.ToString());
                TrafficLight nextTraffic = (TrafficLight)Enum.Parse(typeof(TrafficLight), nextLight.ToString());
                TrafficLight lastTraffic = (TrafficLight)Enum.Parse(typeof(TrafficLight), thirdLght.ToString());

                Console.Write (currentTraffic + " " + nextTraffic + " " + lastTraffic);
            
               Console.WriteLine();
            
        }

    }
}

