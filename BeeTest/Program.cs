using System;
using System.Collections.Generic;
using System.Linq;

namespace BeeTest
{
    class Program
    {
        static void Main()
        {
            Drone d = new Drone();
            Queen q = new Queen();
            Worker w = new Worker();


            List<Bee> droneList = new List<Bee>()
        {
            new Drone(){Id = 1, BeeType = BeeType.Drone},
            new Drone(){Id = 2, BeeType = BeeType.Drone},
            new Drone(){Id = 3, BeeType = BeeType.Drone},
            new Drone(){Id = 4, BeeType = BeeType.Drone},
            new Drone(){Id = 5, BeeType = BeeType.Drone}

        };

            List<Bee> queenList = new List<Bee>()
        {
            new Queen(){Id = 1, BeeType = BeeType.Queen},
            new Queen(){Id = 2, BeeType = BeeType.Queen},
            new Queen(){Id = 3, BeeType = BeeType.Queen},
            new Queen(){Id = 4, BeeType = BeeType.Queen},
            new Queen(){Id = 5, BeeType = BeeType.Queen}

        };

            List<Bee> workerList = new List<Bee>()
        {
            new Worker(){Id = 1, BeeType = BeeType.Worker},
            new Worker(){Id = 2, BeeType = BeeType.Worker},
            new Worker(){Id = 3, BeeType = BeeType.Worker},
            new Worker(){Id = 4, BeeType = BeeType.Worker},
            new Worker(){Id = 5, BeeType = BeeType.Worker}

        };


            Program p = new Program();
            p.ChooseOption(queenList, droneList, workerList);
            Console.ReadLine();
        }

        public void ChooseOption(List<Bee> queenList, List<Bee> droneList, List<Bee> workerList)
        {
            Program p = new Program();
            Console.WriteLine("\n Please enter number between 1 - 3 to see the health. \n 1. Drone \n 2. Queen \n 3. Worker");
            try
            {
                BeeType type = (BeeType)Convert.ToInt32(Console.ReadLine());

                switch (type)
                {
                    case BeeType.Drone:
                        Drone d = new Drone();
                        int did = d.DisplayList(droneList, "Drone");
                        Bee drone = droneList.Where(item => item.Id == did).FirstOrDefault();
                        Console.WriteLine(d.checkHealth(drone, "Drone"));
                        break;

                    case BeeType.Queen:
                        Queen q = new Queen();
                        int qid = q.DisplayList(queenList, "Queen");
                        Bee queen = queenList.Where(item => item.Id == qid).FirstOrDefault();
                        Console.WriteLine(q.checkHealth(queen, "Queen"));
                        break;
                    case BeeType.Worker:
                        Worker wr = new Worker();
                        int wid = wr.DisplayList(workerList, "Worker");
                        Bee worker = workerList.Where(item => item.Id == wid).FirstOrDefault();
                        Console.WriteLine(wr.checkHealth(worker, "Worker"));
                        break;
                    default:
                        break;
                }
                p.ChooseOption(queenList, droneList, workerList);
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);
                Console.WriteLine("\n Press any key to stop.");
                Console.ReadLine();
            }
           

        }
    }
}
