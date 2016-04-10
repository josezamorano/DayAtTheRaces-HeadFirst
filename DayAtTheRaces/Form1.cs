using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {

     
        //We Create the objects in the main form
        Dog dogInRace = new Dog();
        Guy guy = new Guy();
        Bet bet = new Bet();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }




        /// <summary>
        /// This Event adds a dog to a list of dogs ready for the race
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewDog_Click(object sender, EventArgs e)
        {
            //==If the dog list is up to 3 dogs, add one more. 
           if(dogInRace.DogsInRaceList.Count<=3)
           {
               //We add the dog to the racing list
               dogInRace.AddDogToRacingList();

               Dog dogAddedToRaceName = dogInRace.DogsInRaceList.LastOrDefault();

               labelWarning.Text = "the dog "+dogAddedToRaceName.DogName + " has been added to the race.";
               labelWarning.ForeColor = Color.Blue;

               //We find the dogs added to the list and we display them in the Race Track
               foreach(var dog in dogInRace.DogsInRaceList)
               {
                   if(dog !=null)
                   {
                       if (dog.DogGatePosition == 1) { label1DogName.Text = dog.DogName;}// "Abu"; }
                       if (dog.DogGatePosition == 2) { label2DogName.Text = dog.DogName;}//"Bumba"; }
                       if (dog.DogGatePosition == 3) { label3DogName.Text = dog.DogName;}//"Captain"; }
                       if (dog.DogGatePosition == 4) { label4DogName.Text = dog.DogName;}//"Timbale"; }
                   }
               }
           }
           else
           {
               labelWarning.Text = "You can add up to 4 dogs only!";
               labelWarning.ForeColor = Color.Red; 
           }

           //We display the dogs' names in the betting section in the drop down list.
           BindingSource bs = new BindingSource();
           bs.DataSource = dogInRace.DogsInRaceList;
           comboBoxNumericDogPosition.DataSource = bs;
           comboBoxNumericDogPosition.DisplayMember = "DogName";
           comboBoxNumericDogPosition.ValueMember = "DogGatePosition";

        }

      

        /// <summary>
        /// This event register the guy Joe for the races and he can deposit 
        /// and place bets on his favourite dog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonJoe_CheckedChanged(object sender, EventArgs e)
        {          
            //This option creates the guy Joe and add him to the guys list
            bool joeCheckedTrue = radioButtonJoe.Checked;
            if (joeCheckedTrue)
            {              
                labelGuyPlacingBet.Text = radioButtonJoe.Text;

                string guyName = labelGuyPlacingBet.Text;               
                guy.SetName(guyName);
                //We add the guy to the list
                guy.AddToGuysList();
              
            }

           //we update the list
            guy.UpdateLabel(guy);
            guy.GetGuysAtTheRaceList();
          
            //We update the labels
            labelJoeSituation.Text = guy.MyLabel.Text;
            labelGuyPlacingBet.Text = radioButtonJoe.Text;
        }


        /// <summary>
        /// This event register the guy Bob for the races and he can deposit 
        /// and place bets on his favourite dog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonBob_CheckedChanged(object sender, EventArgs e)
        {
            bool bobCheckedTrue = radioButtonBob.Checked;
            if (bobCheckedTrue)
            {

                labelGuyPlacingBet.Text = radioButtonBob.Text;

                string guyName = labelGuyPlacingBet.Text;

                guy.SetName(guyName);
                guy.AddToGuysList();

            }

            guy.UpdateLabel(guy);
         
          
            labelBobSituation.Text = guy.MyLabel.Text;
            labelGuyPlacingBet.Text = radioButtonBob.Text;
        }

        /// <summary>
        /// This event register the guy Al for the races and he can deposit 
        /// and place bets on his favourite dog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonAl_CheckedChanged(object sender, EventArgs e)
        {
              bool alCheckedTrue = radioButtonAl.Checked;
              if (alCheckedTrue)
              {
                  labelGuyPlacingBet.Text = radioButtonAl.Text;
                  string guyName = labelGuyPlacingBet.Text;
                  guy.SetName(guyName);
                  guy.AddToGuysList();
              }

              guy.UpdateLabel(guy);
                   
              labelAlSituation.Text = guy.MyLabel.Text;
              labelGuyPlacingBet.Text = radioButtonAl.Text;
        }


        /// <summary>
        /// This event captures the deposit made by each of the guys that participate
        /// in the dog races.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeposit_Click(object sender, EventArgs e)
        {
           //==We place the information in a list
            List<RadioButton> guysRadioButtonList =new List<RadioButton>();
            RadioButton alCheckedRadioButton = radioButtonAl;
            RadioButton bobCheckedRadioButton = radioButtonBob;
            RadioButton joeCheckedRadioButton = radioButtonJoe;
          
            guysRadioButtonList.Add(alCheckedRadioButton);
            guysRadioButtonList.Add(bobCheckedRadioButton);
            guysRadioButtonList.Add(joeCheckedRadioButton);
         
            int counter = 0;
            foreach(var radioButton in guysRadioButtonList)
            {
                if(radioButton.Checked)
                {
                    //==We update the guys list
                
                        var guyDeposit = guy.guysAtTheRaceList.Where(c=>c.GetName()==radioButton.Text).FirstOrDefault();
                       
                    if(guyDeposit !=null)
                    { 
                        //==We set the deposit for the amount deposited
                        guyDeposit.SetDeposit((int)numericUpDownDeposit.Value);
                                               
                        //==We update the balance by adding the deposit to the current balance
                        guyDeposit.DepositIntoAccount(guy);

                        //We clear any warning
                        labelGuySituation.Text = "";                          
                      
                        //We set the amount deposited back to zero to clear the variable
                        guyDeposit.SetDeposit(0);
                        //==we update the guy's situation
                       
                        guyDeposit.UpdateLabel(guy);                    
                        
                        if (radioButton.Text.Equals("Al")) { labelAlSituation.Text = guyDeposit.MyLabel.Text; }
                        if (radioButton.Text.Equals("Bob")) { labelBobSituation.Text = guyDeposit.MyLabel.Text; }
                        if (radioButton.Text.Equals("Joe")) { labelJoeSituation.Text = guyDeposit.MyLabel.Text; }
                    }                     
                }
                else
                {
                    counter++;
                }             

            }
           if(counter == guysRadioButtonList.Count())
           {
               labelGuySituation.Text = "You need to select a guy to make a deposit.";
           }

        }

        /// <summary>
        /// This method records each bet placed by a guy. Any guy can place 
        /// multiple bets on any dog even repeatedly on the same dog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlaceBet_Click(object sender, EventArgs e)
        {
            //Whe the guy places a bet we reset all the dogs and 
            //==hide the images and set the distance covered by each 
            //==dog to 0.
            foreach (var d in dogInRace.DogsInRaceList)
            {
                d.MyPictureBox.Visible = false;
                d.DistanceCoveredByDog = 0;
            }

            int currentBettingAmount = (int)numericBet.Value;
            int currentDogSelected = 0;

            //We check that a dog has been selected 
            if (comboBoxNumericDogPosition.SelectedValue != null)
            {
                currentDogSelected = (int)comboBoxNumericDogPosition.SelectedValue;
            }

            string currentBettingGuyName = labelGuyPlacingBet.Text;
            string guyBettingNowName = "";

            //We check that there are enough dogs in the race for 
            //the person to place a bet
            if (dogInRace.DogsInRaceList.Count() > 1)
            {
                //We check that there is an actual guy placing a bet
                if (currentBettingGuyName != "")
                {
                    //Get the guys who is placing the bet
                    Guy guyBettingNow = guy.guysAtTheRaceList.Where(c => c.GetName() == currentBettingGuyName).FirstOrDefault();

                    int currentInitBalance = guyBettingNow.GetBalance();

                    if (currentBettingAmount <= currentInitBalance && currentDogSelected != 0)
                    {
                        //==We place the bet using the method stored in the guy class. We send the parameters
                        //== Betting amount, the position of the dog selected and the Dog object to that method.

                        bool betPlaced = guyBettingNow.PlaceBet(currentBettingAmount, currentDogSelected, dogInRace, bet);

                        if (betPlaced)
                        {
                            //We populate the guy object in the bet list since it was not transported as a parameter
                            //(The value could have been sent, however we keep it here to call the method JUST for practice). 
                            var currentBet = bet.betsList.Where(
                                c => c.dog.DogGatePosition == currentDogSelected
                                  && c.GetAmountBet() == currentBettingAmount
                                  && c.bettingPerson == null
                                   ).FirstOrDefault();

                            //==We update the balance of the guy placing the bet                            
                            currentBet.bettingPerson = guyBettingNow;

                            //==We take the money from the guy's account
                            guyBettingNow.WithdrawFromAccount(currentBettingAmount);

                            //We verify that the current balance is correct
                            int currentEndBalance = guyBettingNow.GetBalance();
                            guyBettingNowName = guyBettingNow.GetName();
                            labelGuySituation.Text = bet.GetBettingDescription(bet, guyBettingNowName);

                            //==Print the list of bets
                            DisplayBetsPlaced();

                            //==Update of balance labels
                            UpdateLabels();

                            //==After placing the bets we make the dogs visible again.
                            foreach (var d in dogInRace.DogsInRaceList)
                            {
                                d.MyPictureBox.Visible = true;
                            }

                            //We define the starting position of the dogs
                            SetDogsStartingPosition();
                        }
                        else
                        {
                            labelGuySituation.Text = guyBettingNowName + "Has not placed a bet.";
                            labelGuySituation.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        //we identify what is the problem
                        string name = guyBettingNow.GetName();
                        if (currentBettingAmount > currentInitBalance) { labelGuySituation.Text = name + " has not enough money to place a bet."; }
                        if (currentDogSelected == 0) { labelGuySituation.Text = name + " Has not selected a dog to place a bet."; }
                    }
                }
                else
                {
                    labelGuySituation.Text = "You must select a guy to place a bet. ";
                    labelGuySituation.ForeColor = Color.Red;
                    labelWarning.Text = "";
                }
            }
            else
            {
                labelWarning.Text = "you must add at least 2 dogs to the race";
                labelWarning.ForeColor = Color.Red;
            }
     }





        /// <summary>
        /// This method starts the race and set the dogs in motion.
        /// At the end, it finds which dog won, pays the bet to the
        /// guy who bet on the dog and update balances and labels.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

     private void buttonStartRace_Click(object sender, EventArgs e)
     {
            //==We Clear all the labels first BEGIN=========
            labelTimeDesc.Text = "";
            labelDistanceDescription.Text = "";
            labelWinnerDogNameDesc.Text = "";
            labelWarning.Text = "";
            labelComboBox.Text = "";
            //==We Clear all the labels first END=========       


            int raceTrackNo = comboBox1.SelectedIndex;

            //==We check if the race track distance has been set
            if (raceTrackNo != 0)
            {
                //We check if at least two dogs have been created for the race
                if (dogInRace.DogsInRaceList != null && dogInRace.DogsInRaceList.Count >= 2)
                {

                    //we check if there is at least one bet placed for the dogs to run
                    if (bet.betsList.Count != 0)
                    {
                        //==We Set the distance covered by the dog to zero
                        //==So previous races do not get stored in the distance

                        Racetrack race = new Racetrack();

                        Stopwatch timer = Stopwatch.StartNew();
                        Random rand = new Random();

                        // int distanceCoveredByDog = 0;
                        // double distance = 0;
                        int totalDistance = Convert.ToInt32(comboBox1.SelectedItem);

                        // bool weHaveAWinner = false;
                        bool keepRacing = true;


                        #region START RACING !!==
                        //==StartRacing BEGIN=======
                        int iteration = 1;
                       
                        int distanceCoveredByDog  = 0;
                       
                        Dog winDog = new Dog();

                        //All the dogs will keep racing while there is no winner
                        while (keepRacing)
                        {
                            foreach (var dog in dogInRace.DogsInRaceList)
                            {
                                keepRacing = race.Race(dog, totalDistance);
                                //==Moving the picture BEGIN==========================================
                                /**/
                                Point p = dog.MyPictureBox.Location;
                                distanceCoveredByDog = Convert.ToInt32(dog.DistanceCoveredByDog);

                                //This section make the dogs cover actual smaller screen distance
                                if (totalDistance >= 200) { p.X += distanceCoveredByDog / 15; }
                                else { p.X += distanceCoveredByDog; }

                                //We check if the dogs already advanced to the end of the racetrack
                                //if they are in a distance less than the total length of the race,
                                //they keep moving forward, otherwise they stop.
                                if (p.X < 920) { dog.MyPictureBox.Location = p; }
                                else
                                {
                                    p.X = 920;
                                    dog.MyPictureBox.Location = p;
                                }
                               
                                dog.DogIteration = iteration;    
                                /**/
                                //======Moving the picture END=====================================
                               
                            }

                            //We set a counter
                            int counter = 0;
                            //And we count the times the iteration has been passed to the dogs in the list
                            foreach(var dog in dogInRace.DogsInRaceList)
                            {
                                //For each coincidence with increase the counter
                                if(dog.DogIteration== iteration)
                                {
                                    counter++;
                                }
                            }
                            //Therefore if the counter increases up to the total of the number 
                            //of dogs in races, then we check with dog has covered the longest distance
                            if(counter== dogInRace.DogsInRaceList.Count)
                            {
                                /**/
                                
                                // ****Same distances setup for testing purposes*********
                                //dogInRace.DogsInRaceList[0].DistanceCoveredByDog = 50;
                                //dogInRace.DogsInRaceList[1].DistanceCoveredByDog = 50;
                                // ******************************************************
                        

                                //We order the distances from the highest to the lowest.
                              double  winDogDistance = dogInRace.DogsInRaceList.OrderByDescending(c => c.DistanceCoveredByDog).FirstOrDefault().DistanceCoveredByDog;
                                //And check if only one of more than one dog has covered the same distance
                                //In case more than one dog has covered the same distance, we add randomly 1 metre to any dog.
                                List<Dog> dogsTopDistanceList = dogInRace.DogsInRaceList.Where(a => a.DistanceCoveredByDog == winDogDistance).ToList();
                 
                                if(dogsTopDistanceList.Count>1)
                                {
                                    Random rnd = new Random();
                                    int maxVal = dogsTopDistanceList.Count+1;
                                    int value = rnd.Next(1,maxVal);

                                    dogsTopDistanceList[value-1].DistanceCoveredByDog += 1;


                                    Point p = dogsTopDistanceList[value - 1].MyPictureBox.Location;
                                    
                                    int distance = Convert.ToInt32(dogsTopDistanceList[value - 1].DistanceCoveredByDog);
                                    p.X = p.X + 1;
                                    dogsTopDistanceList[value - 1].MyPictureBox.Location = p;

                                }
                               /**/
                                //Now when we are sure there is only one dog which is covering the longest distance, we select it from the list of dogs racing
                                winDog = dogInRace.DogsInRaceList.OrderByDescending(c => c.DistanceCoveredByDog).FirstOrDefault();

                                //if the dog covered the total distance already, we break the loop
                                if (totalDistance <= winDog.DistanceCoveredByDog)
                                {
                                    dogInRace.WinnerDog = true;
                                    break;
                                }
                            }                                                     

                            iteration++;                          

                        }

                        timer.Stop();
                        
                        labelDistanceDescription.Text = (Convert.ToInt32(winDog.DistanceCoveredByDog)).ToString();
                        labelWinnerDogNameDesc.Text = winDog.DogName;
                        TimeSpan timespan = timer.Elapsed;
                        labelTimeDesc.Text = String.Format("{0:00}:{1:00}:{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10);

                        //==Find the guy who won

                        int gatePositionWinnerDog = winDog.DogGatePosition;

                        var winningBetsList = bet.betsList.Where(c => c.dog.DogGatePosition == gatePositionWinnerDog).ToList();


                       
                            foreach (var guyInTheList in guy.guysAtTheRaceList)
                            {
                                guyInTheList.CollectBet(guyInTheList, winningBetsList);
                            }

                        //We update the Balance labels
                        UpdateLabels();

                        //==We print a list of winners===============
                        if (winningBetsList != null)
                        {
                            
                            List<string> winnersList = new List<string>();
                            string winnerDescription = "";
                            foreach (var winner in winningBetsList)
                            {                               
                                winnerDescription = winner.bettingPerson.GetName() + " placed a bet of $ " + winner.GetAmountBet() + " on " + winner.dog.DogName;
                                winnersList.Add(winnerDescription);
                            }
                            listBoxBetsPlaced.DataSource = winnersList;                          

                        }

                        //==We clear the bets list after the race has finished.
                        bet.betsList.Clear();
                        #endregion

                    }
                    else
                    {
                        labelWarning.Text = "Any guy must at least place One bet for the dogs to Race.";
                        labelWarning.ForeColor = System.Drawing.Color.Red;
                    }

                }
                else
                {
                    labelWarning.Text = "You must add at least 2 dogs to start a race.";
                    labelWarning.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                labelComboBox.Text = "you must set the racetrack distance";
                labelComboBox.ForeColor = System.Drawing.Color.Red;
            }

        }

        

        /// <summary>
        /// This method prints the list of bets placed each round or races.
        /// here we identify the guy, the amount bet and the dog.
        /// </summary>

     public void DisplayBetsPlaced()
     {

         //==Print the list of bets
         List<string> betsDescriptionList = new List<string>();
         string betDescription = "";
         foreach (var betInList in bet.betsList)
         {
             string personName = betInList.bettingPerson.GetName();
             // string amountBet = betInList.amountBet.ToString();
             string amountBet = betInList.GetAmountBet().ToString();

             string dogName = betInList.dog.DogName;
             //currentGuyBettingName + " placed a bet of $ " + currentBet.bettingPerson.GetCashBet() + " on " + currentBet.dog.DogName;
             betDescription = personName + " placed a bet of $ " + amountBet + " on " + dogName;

             betsDescriptionList.Add(betDescription);
         }
         listBoxBetsPlaced.DataSource = betsDescriptionList;

     }


        /// <summary>
        /// This method updates the labels that show the balances for each guy
        /// in the betting parlor.
        /// </summary>
     public void UpdateLabels()
     {
         foreach (var guyInTheList in guy.guysAtTheRaceList)
         {
             // guyInTheList.CollectBet(guyInTheList, winningBetsList);


             //We Update the Information for each guy in the betting parlor
             string nameGuyInList = guyInTheList.GetName();
             if (nameGuyInList == "Bob")
             {
                 //==We get the list of guys with the updated balance to display in the screen
                 labelBobSituation.Text = nameGuyInList + " has $ " + guyInTheList.GetBalance() + " bucks";
             }
             if (nameGuyInList == "Al")
             {
                 //==We get the list of guys with the updated balance to display in the screen
                 labelAlSituation.Text = nameGuyInList + " has $ " + guyInTheList.GetBalance() + " bucks";
             }
             if (nameGuyInList == "Joe")
             {
                 //==We get the list of guys with the updated balance to display in the screen
                 labelJoeSituation.Text = nameGuyInList + " has $ " + guyInTheList.GetBalance() + " bucks";
             }
         }

     }


        /// <summary>
        /// This method sets the starting position of all the 
        /// compiting dogs. 
        /// </summary>
     public void SetDogsStartingPosition()
     {
         //We define the starting position of the dogs
         int startingPosition = 20;
         foreach (var dog in dogInRace.DogsInRaceList)
         {
             Point p = new Point();
             dog.DistanceCoveredByDog = 0;
             //=======================================

             int dogGatePosition = dog.DogGatePosition;
             if (dogGatePosition == 1)
             {
                 dog.MyPictureBox = pictureBoxDog1;
                 p.X = Convert.ToInt32(startingPosition);
                 p.Y = 21;
                 pictureBoxDog1.Location = p;
             }
             if (dogGatePosition == 2)
             {
                 dog.MyPictureBox = pictureBoxDog2;
                 p.X = Convert.ToInt32(startingPosition);
                 p.Y = 70;
                 pictureBoxDog2.Location = p;
             }
             if (dogGatePosition == 3)
             {
                 dog.MyPictureBox = pictureBoxDog3;
                 p.X = Convert.ToInt32(startingPosition);
                 p.Y = 129;
                 pictureBoxDog3.Location = p;
             }
             if (dogGatePosition == 4)
             {
                 dog.MyPictureBox = pictureBoxDog4;
                 p.X = Convert.ToInt32(startingPosition);
                 p.Y = 188;
                 pictureBoxDog4.Location = p;
             }

             //=======================================

         }
     }

   
    }
}
