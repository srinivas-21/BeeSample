using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeTest
{
   public class Worker : Bee
    {

        public Worker()
        {
        }

        public string checkHealth(Bee bee, string beeType)
        {
            string output;

            if (!bee.Dead)
            {
                float health = Damage(getRandomNumber(), bee);

                if (health < 70)
                {
                    bee.Dead = true;
                    output = $"Worker {bee.Id} is dead, health is less than 70%.";
                }
                else
                {
                    output = $"Worker {bee.Id} is alive and remaining health percentage is {health}%.";
                }
            }
            else
            {
                output = $"Worker {bee.Id} is already dead, no further health deduction will happen..";
            }
            return output;

        }
      

    }
}
