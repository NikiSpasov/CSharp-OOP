using System.Collections.Generic;

namespace Demo
{
    public class StartUp
    {
       public static void Main()
        {
            var data = new MyCustomData<int>();

            data.Add(1);
            data.Add(2);
            data.Add(15);

            var result = data[0];

            var textData = new MyCustomData<string>();

            textData.Add("Pesho");

            var cats = new MyCustomData<Cat>();


        }
    }
}
