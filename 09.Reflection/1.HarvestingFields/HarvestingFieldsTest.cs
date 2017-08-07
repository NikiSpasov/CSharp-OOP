using System.Linq;
using System.Reflection;
using System.Text;

namespace _01HarestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            //get all fields:
            var harvestingFieldsType = typeof(HarvestingFields);
            var harvestingFields = harvestingFieldsType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            FieldInfo[] gatheredFields;
            string input;
            while ((input = Console.ReadLine()) != "HARVEST")
            {
                switch (input)
                {
                    case "private":
                        gatheredFields = harvestingFields.Where(f => f.IsPrivate).ToArray();                     
                        break;
                    case "protected":
                        gatheredFields = harvestingFields.Where(f => f.IsFamily).ToArray();
                        break;

                    case "public":
                        gatheredFields = harvestingFields.Where(f => f.IsPublic).ToArray();
                        break;

                    case "all":
                        gatheredFields = harvestingFields;
                        break;
                    default:
                        gatheredFields = null;
                        break;
                }
                string[] result = gatheredFields.Select(f => 
                                  $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
                                 .ToArray();
                Console.WriteLine(String.Join(Environment.NewLine, result).Replace("family", "protected"));
            }
                       
        }
    }
}
