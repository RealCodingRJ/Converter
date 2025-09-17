using MongoDB.Bson;
using MongoDB.Driver;
using System.Drawing;

namespace Converter
{

    
    class App
    {

        private static void Main(string[] args)
        {
            if(args.Length == 0)
            {                

          
                Console.WriteLine("Enter Hex: ");
                int colorR = Convert.ToInt16(Console.ReadLine());

                string colorCode = CreateConvert(colorR);

                Console.Write(colorCode);
                Console.Write(colorCode);
                Console.Write(colorCode);

                string ColorList = $"# {colorCode}, {colorCode}, {colorCode}";

                Doc(ColorList);

            }

            Console.ReadKey();
        }

        private static string CreateConvert(int a)
        {
            return Convert.ToString(a, 16);
        }


        private async static void Doc(string doc)
        {
            const string URL = "";
            var client = new MongoClient(URL);
            var db = client.GetDatabase("Color");
            var coll = db.GetCollection<BsonDocument>("color");
            await coll.InsertOneAsync(new BsonDocument("color", doc));
        }
    }
    
}