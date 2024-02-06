using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Serialized
{
    public class Cereal
    {
        public string Name { get; set; }
        public string Slogan { get; set; }
        public Boolean ClarkeAprroved { get; set; }
        public int Calories{ get; set; }    
        public decimal Price { get; set; }
        public string Picture { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cereal LuckyCharms = new Cereal();
            LuckyCharms.Name = "LuckyCharms";
            LuckyCharms.Slogan = "They are Magically Delicious";
            LuckyCharms.ClarkeAprroved = true;
            LuckyCharms.Calories = 137;
            LuckyCharms.Price = 15.37m;           

            Cereal FrootLoops = new Cereal();
            FrootLoops.Name = "FrootLoops";
            FrootLoops.Slogan = "Whatever Froots Your Loops";
            FrootLoops.ClarkeAprroved = true;
            FrootLoops.Calories = 150;
            FrootLoops.Price = 13.65m;

            Cereal HoneyNutCheerios = new Cereal();
            HoneyNutCheerios.Name = "HoneyNutCheerios";
            HoneyNutCheerios.Slogan = "Its a Honey of an O";
            HoneyNutCheerios.ClarkeAprroved = false;
            HoneyNutCheerios.Calories = 105;
            HoneyNutCheerios.Price = 4.93m;

            string JsonString = JsonSerializer.Serialize(LuckyCharms);
            Console.WriteLine(JsonString);

            Cereal Cheerios = new Cereal();
            Cheerios = JsonSerializer.Deserialize<Cereal>(JsonString);

            Console.ReadKey();
        }
    }
}
