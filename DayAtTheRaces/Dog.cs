using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Dog
    {
        //We could have created this list in the Main Form
        //But we decided to create it here so when a new 
        //dog is added its immediately added to the list
        //and the list of dogs is readily available.

        public List<Dog> DogsInRaceList = new List<Dog>();


        //An Object HAS SOMETHING
      
        private double _maxSpeedKms;
        private bool   _winnerDog;      

        public PictureBox MyPictureBox = null;           

        //==Getters and Setters BEGIN======
        public void SetMaxSpeedKms(double speed)
        {
           this._maxSpeedKms = speed; 
        }

        public double GetMaxSpeedMts()
        {
            double maxSpeedMts = this._maxSpeedKms * 10 / (36);
            return maxSpeedMts;
        }


        public String DogName { get; set; }
        public double DistanceCoveredByDog { get; set; }
        public double CurrentSpeedMts{ get; set; }
        public int DogGatePosition { get; set; }
        public int DogIteration { get; set; }
        public bool WinnerDog { get{ return _winnerDog ;} set { this._winnerDog = false; } }
        //==Getters and Setters END======



        //An Object DOES SOMETHING 


       

        /// <summary>
        /// This method sets the dog running
        /// </summary>
        /// <param name="distanceMts"></param>
        /// <returns>The number of Metres the dog will cover in 1 second calculated based
        //on the Max Speed in Metres less an initial random reduction in Max Speed</returns>
        public double run( double distanceMts)
        {
            Random rand = new Random();
            int mtsSlower = rand.Next(1,5);
            double metresCoveredPerSecond = 0;           
            metresCoveredPerSecond = (distanceMts-mtsSlower);
            return metresCoveredPerSecond;

        }


        /// <summary>
        /// This method makes the dog cover more distance
        /// </summary>
        /// <param name="distanceMts"></param>
        /// <returns> A larger distance covered by the dog.</returns>
        public double runFaster(double distanceMts)
        {
            Random rand = new Random();
            int mtsFaster = rand.Next(3, 30);
            double metresCoveredPerSecond = 0;
            metresCoveredPerSecond = (distanceMts + mtsFaster);
            double maxSpeedMts = GetMaxSpeedMts();
            if(metresCoveredPerSecond<=maxSpeedMts)
            {
                return metresCoveredPerSecond;
            }
            else
            {
                return maxSpeedMts;
            }           
        }



        /// <summary>
        /// This method makes the dog to cover less distance
        /// </summary>
        /// <param name="seconds"></param>
        /// <param name="distanceMts"></param>
        /// <returns>Returns the distance covered by the
        /// dog when is tired</returns>
        public double getsTired(double seconds, double distanceMts)
        {
            Random rand = new Random();
            double secondsSlower = rand.Next(2,5);
            double metresCovered = 0;
            if (seconds != 0 || seconds != null)
            {
                metresCovered = (distanceMts / (seconds+secondsSlower/10));

            }
            return metresCovered;
        }


        /// <summary>
        /// This method Add the dog to a list of dogs that 
        /// will participate in the race. Once added the list 
        /// is static and dogs cannot be removed from the list.
        /// </summary>
        public void AddDogToRacingList()
        {
            List<string> dogNameList = new List<string> { "Abu", "Bumba", "Captain", "Timbale", "Treasure" };
            List<int> dogGateNumberList = new List<int> { 1, 2, 3, 4, 5 };

            //We create a new dog
            Dog dog = new Dog();
            dog.MyPictureBox  = new PictureBox();
            dog.DogName = dogNameList[0 + DogsInRaceList.Count];
            dog.DogGatePosition = dogGateNumberList[0 + DogsInRaceList.Count];
            dog.DistanceCoveredByDog = 0;

            //We add the dog to the list of dogs in the race
            DogsInRaceList.Add(dog);
        }

    }
}
