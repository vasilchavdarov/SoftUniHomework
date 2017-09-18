namespace _01HarestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            var classType = typeof(HarvestingFields);
            var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            FieldInfo[] geterFields = null;

            
            var input = Console.ReadLine();

            while (input != "HARVEST")
            {
                switch (input)
                {
                    case "private":
                        geterFields = fields.Where(f => f.IsPrivate).ToArray();
                        break;
                    case "protected":
                        geterFields = fields.Where(f => f.IsFamily).ToArray();
                        break;
                    case "public":
                        geterFields = fields.Where(f => f.IsPublic).ToArray();
                        break;
                    case "all":
                        geterFields = fields;
                        break;
                    default:
                        geterFields = null;
                        break;
                }

                var result = geterFields.Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}").ToArray();
                Console.WriteLine(string.Join(Environment.NewLine, result).Replace("family", "protected"));

                input = Console.ReadLine();
            }
        }
        

    }
}
