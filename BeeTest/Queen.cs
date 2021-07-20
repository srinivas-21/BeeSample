using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeTest
{

   public class Queen : Bee
    {

        public Queen()
        {
        }

        public string checkHealth(Bee bee, string beeType)
        {
            string output;

            if (!bee.Dead)
            {
                float health = Damage(getRandomNumber(), bee);

                if (health < 20)
                {
                    bee.Dead = true;
                    output = $"Queen {bee.Id} is dead, health is less than 20%.";
                }
                else
                {
                    output = $"Queen {bee.Id} is alive and remaining health percentage is {health}%.";
                }
            }
            else
            {
                output = $"Queen {bee.Id} is already dead, no further health deduction will happen..";
            }
            return output;

        }

    }
}
