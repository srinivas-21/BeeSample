using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeTest
{
    public class Bee
    {
        public int Id { get; set; }
        public bool Dead { get; set; }
       
        protected float Health = 100;
        public BeeType BeeType;

        public int DisplayList(List<Bee> queen, string beeType)
        {
            foreach (var q in queen)
            {
                Console.WriteLine($"{beeType} {q.Id} Health is: {q.Health}");
            }

            Console.WriteLine($"\n Enter {beeType} Id to get the health %");
            return Convert.ToInt32(Console.ReadLine());
        }

        public float Damage(int reducePercentage, Bee bee) {
            bee.Health -= reducePercentage;
            if (bee.Health < 0)
            {
                bee.Health = 0;
            }
            return bee.Health;
        }

        public int getRandomNumber()
        {
            Random r = new Random();
            return r.Next(0, 80);
        }

    }
}
