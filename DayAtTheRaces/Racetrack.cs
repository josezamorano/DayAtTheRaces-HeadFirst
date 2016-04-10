using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAtTheRaces
{
    public class Racetrack
    {
        /****
         * This class holds the method that start the race.
         * We could have place the different distances here
         * but we decided to place them in the dropdown List
         * in the Main Form. 
         * ***/





        /// <summary>
        /// This method starts the race among the preselected dogs. 
        /// 
        /// </summary>
        /// <param name="dog"></param>
        /// <param name="totalDistance"></param>
        /// <returns>return the number of
        /// metres that a dog covered in a given iteration</returns>
        public bool Race (Dog dog ,double totalDistance)
        {
                Random rand = new Random();                  
               
                double speedKmsHr = rand.Next(40, 45);
                double secondsTimeDelay = rand.Next(2, 5);
               //int randomTimeDelay = 0;
                dog.SetMaxSpeedKms(speedKmsHr);
                double initialMetresToRun = dog.GetMaxSpeedMts();

                //==Current Metres per second the dog is currently running
                double currentDistance = dog.run(initialMetresToRun);

                dog.DistanceCoveredByDog += currentDistance;

                int value = rand.Next(1, 5);
                //==Now We set The cases
                switch (value)
                {
                        
                    case (1): //Dog runs at a given speed
                        currentDistance = dog.run(dog.GetMaxSpeedMts());
                        dog.DistanceCoveredByDog += (int)currentDistance;
                        break;


                    case (2): //Dog runs at a maximum speed 
                        currentDistance = dog.runFaster(currentDistance);
                        dog.DistanceCoveredByDog += (int)currentDistance;
                        break;

                    case (3): //Dog runs slower
                        currentDistance = dog.getsTired(secondsTimeDelay, currentDistance);
                        dog.DistanceCoveredByDog += (int)currentDistance;
                        break;

                    case (4): //Dog is delayed and cover 0 distance
                        dog.DistanceCoveredByDog += 0;
                        break;
                    
            }
          
                return true;
        }




    }
}
