using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeTest
{
    
   public class Drone : Bee
    {

        public Drone()
        {
        }


        public string checkHealth(Bee bee, string beeType)
        {
            string output;

            if (!bee.Dead)
            {
                float health = Damage(getRandomNumber(), bee);

                if (health < 50)
                {
                    bee.Dead = true;
                    output = $"Drone {bee.Id} is dead, health is less than 50%.";
                }
                else
                {
                    output = $"Drone {bee.Id} is alive and remaining health percentage is {health}%.";
                }
            }
            else
            {
                output = $"Drone {bee.Id} is already dead, no further health deduction will happen..";
            }
            return output;

        }

       
    }
}
