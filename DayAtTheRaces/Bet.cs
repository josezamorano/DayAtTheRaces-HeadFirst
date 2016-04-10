using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAtTheRaces
{
    class Bet
    {
        /*****
             * This class holds information about the bet: bettor,
             * dog and amount bet. All is kept in a list 
             * 
             * ***/

        //==We have a List of Bets
        public List<Bet> betsList = new List<Bet>();

       //==We have visibility objects to navigate and peek other classes==
        public Dog dog;
        public Guy bettingPerson;

        //==A Bet HAS
        private int amountBet;
       // private bool betAddedToList;

        //==BEGIN Setters and Getters=========
        //==Only for training purposes. The amount bet could have been written
        //==AmountBet{get; set;}
        public void SetAmountBet(int bet)
        {
            amountBet = bet;
        }
        public int GetAmountBet()
        {
            return amountBet;
        }

        //==END Setters and Getters=========

        /// <summary>
        /// This Method displays the amount currently being bet by 
        /// a given person
        /// </summary>
        /// <param name="presentBet"></param>
        /// <param name="nameGuy"></param>
        /// <returns>Returns the bet placed.</returns>
        public string GetBettingDescription(Bet presentBet,string nameGuy)
        {
            //==Return a string that says who placed the bet, 
            //==how much cash was in the bet and 
            //==which dog he bet on
            string bettingDescription = "";

            var currentBet =presentBet.betsList.Where(c => c.bettingPerson.GetName() == nameGuy).FirstOrDefault();
            //==find the details of the guy who placed the bet
            string currentGuyBettingName = currentBet.bettingPerson.GetName();
            if(currentBet.amountBet >0)          
            {              
                bettingDescription = currentGuyBettingName + " placed a bet of $ " + currentBet.GetAmountBet() + " on " + currentBet.dog.DogName;
            }
            else
            {
                bettingDescription = currentGuyBettingName + " has not placed a bet yet.";
            }     

            return bettingDescription;
        }
            
       
    }
}
