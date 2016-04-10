using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    class Guy
    {
        /***
         * 
         * Represents Each person that places a bet in the dog Race 
         * The class contains information about the cash that the
         * person placed in the bet, balance and Name. Also visibility
         * to the Bet class.
         * 
         * ***/
       
        //==Extension
        //==We have a list of guys with their details. The list could
        //==Have been placed in the Main form, but was added here.
        public List<Guy> guysAtTheRaceList = new List<Guy>();

        //==Original
        //==We have Visibility objects to peek content of other classes
        public Bet myBet;

        //Extension
        //A guy HAS
        private string name;        
        private int depositAmount;       
        private int balance;

        //==Original 
        //The last two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton;
        public Label MyLabel;


        //==Setters and Getters (created this way for practice purposes)
        public string SetName(string nameGuy)
        {
            this.name = nameGuy;
            return name;
        }
        public string GetName()
        {            
            return name;
        }
     
        public int SetDeposit(int depositMoney)
        {
            this.depositAmount= depositMoney;
            return depositAmount;
        }

        public int GetBalance()
        {
            return balance;
        }

        public List<Guy> GetGuysAtTheRaceList()
        {
            return guysAtTheRaceList;
        }

        //A GUY DOES
        public void DepositIntoAccount(Guy guybeingUpdated)
        {
            //==When a person is only depositing we increase the balance
            if (depositAmount != 0)
            {
                balance += depositAmount;

            }

        }

        public void WithdrawFromAccount(int amountBet)
        {           
            //==When a person is only placing a bet we decrease the balance
                balance -= amountBet;
        }
               
        
        /// <summary>
        /// This method adds a person to the list of persons 
        /// at the races.
        /// </summary>
       
        public void AddToGuysList()
        {
            //Here we create a new guy object
            Guy guyAtTheRaces = new Guy();
     
            //==We add the information to that 
            //==new guy object.
            guyAtTheRaces.name = name;
           // guyAtTheRaces.cashBet = cashBet;
            guyAtTheRaces.balance = balance;

            //We verify that the guy is not on the list.
            int counter = 0;
            foreach (var person in guysAtTheRaceList)
            {
                //We count the persons in the list.

                if (person.name != guyAtTheRaces.name)
                {
                    counter++;
                }
            }
            // only after confirming that the person is not on the full list
            // we add him to the list.
            if (counter == guysAtTheRaceList.Count())
            {
                guysAtTheRaceList.Add(guyAtTheRaces);
            }

        }

        /// <summary>
        /// This method updates the information displayed, related to a given person 
        /// in the list of people at the races.
        /// </summary>
        /// <param name="guyBeingUpdated"></param>
        public void UpdateLabel(Guy guyBeingUpdated)
        {
            //==We create a new label object that will be used to update the person's 
            //==information that will be displayed
            MyLabel = new Label();
         
            //==From the list of persons (we could have used linq to find the person,
            //==For me to practice loops is that I use it.)          
            foreach(var person in guyBeingUpdated.guysAtTheRaceList)
            {               
               // we find the person on the list
                if (person.name == name)
                {             
                   //Set my label's to my bet's description, and the label on
                   //my radio button to show my cash ("Joe has 43 Bucks")
                   MyLabel.Text =person.name + " has $" +person.balance + " Bucks.";
                }
            }
        }
            
      
        /// <summary>
        /// This method adds a bet to the list of bets held in the Bet class.
        /// As the process is executed in the Form, and by the book's design
        /// the functionality "Place bet" is held in the Guy class, the 
        /// following parameters have to be transported for the recording process
        /// to happen.
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="DogGate"></param>
        /// <param name="dogInRaceSelected"></param>
        /// <param name="betObject"></param>
        /// <returns>Returns True if the bet is placed, False if not.</returns>
        public bool PlaceBet(int amount, int DogGate, Dog dogInRaceSelected, Bet betObject)
        {
            //Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
            int minBet = 5;
            int maxBet = 15;
            if (amount >= minBet && amount <= maxBet)
            {         
                   //We create a new bet object
                    myBet = new Bet();
                  
                    var dogSelected = dogInRaceSelected.DogsInRaceList.Where(c => c.DogGatePosition == DogGate).FirstOrDefault();
                   
                    //==We add the bet to the betting List
                    myBet.dog = dogSelected;
                   // myBet.SetBetAddedToListToTrue();                
                    myBet.SetAmountBet(amount);

                    //==We add the current bet to the list of Bet object created in the main Form
                    betObject.betsList.Add(myBet);
                    return true;
            }
            else
            {
                return false;
            }
          
        }


        /// <summary>
        /// This method clears the bet, but it can be executed directly in the form since the list
        /// has been placed in that namespace and the Clear() method can be called directly.
        /// </summary>
        /// <param name="currentBetsList"></param>
        public void ClearBets(List<Bet> currentBetsList)
        {
            //Reset all bets to zero after the guys are settled
            currentBetsList.Clear();          
        }

        /// <summary>
        /// This method pays the bet placed in a given race to the person who won.
        /// As the system has been designed to hold multiple bets for the same or 
        /// different dogs, the method selects the persons who won and proceed to 
        /// double the amount bet and add it to the person's balance. 
        /// </summary>
        /// <param name="guyInTheList"></param>
        /// <param name="currentWinningBetsList"></param>
        
        public void CollectBet(Guy guyInTheList,List<Bet> currentWinningBetsList)
        {
            //We check if there are winners in the current bet's list
            if(guyInTheList !=null)
            {
                foreach(var person in currentWinningBetsList)
                {

                    //Proceed to collect the bet
                    string PersonNameInList = guyInTheList.name;
                    if(person.bettingPerson.name == PersonNameInList)
                    {
                        //We increase the balance of the winner
                        //double up winnings 
                        //guyInTheList.balance += person.amountBet * 2;
                        guyInTheList.balance += person.GetAmountBet() * 2;
                    }                  

                }
            }

           
        }
    }
}
