using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace CS311_Project2_MLC
{
    public partial class Craps : Form
    {
        //Initialize form level variables
        private decimal bankBalance = 100.00m; //Initialize bank balance to $100
        private int point = 0; //Store points after first roll
        private bool isPointSet = false; //To track if the point is set
        private Random rand = new Random(); //Random number generator for rolling the dice
        public Craps()
        {
            InitializeComponent();
            lblBank.Text = $"Bank Balance: ${bankBalance}"; //Display the intial bank balance
        } //end Craps

        private void btnRoll_Click(object sender, EventArgs e)
        {
            decimal betAmount;

            //Validate the bet amount the user enters
            if (!decimal.TryParse(txtBet.Text, out betAmount) || betAmount <= 0)
            {
                MessageBox.Show("The bet entered must be greater than zero. Please enter a valid amount.");
                return;
            }
            //Ensure the bet is less than or equal to the amount the user has in the bank
            if (betAmount > bankBalance)
            {
                MessageBox.Show("You do not have enough money to cover this bet.");
                return;
            }

            //Call calculate_score to perform the dice roll
            calculate_score(betAmount);

        } //end btnRoll_Click

        //Calculate the score of the game
        void calculate_score(decimal betAmount)
        {
            //Roll two dice randomly betweem numbers 1-6
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);
            int sum = die1 + die2;

            //Display dice values
            lblDice1.Text = $"Dice 1: {die1}"; //print out random number while stating which dice was rolled
            lblDice2.Text = $"Dice 2: {die2}"; //print out random number while stating which dice was rolled


            //Show the sum of the dice
            txtDiceSum.Text = $"Your total is: " + sum.ToString(); //Set the sum in the textbox

            if (!isPointSet)
            {
                //First roll logic

                if (sum == 7 || sum == 11)
                {
                    lblOutcome.Text = $"You win!";
                    bankBalance += betAmount;
                }
                else if (sum == 2 || sum == 3 || sum == 12)
                {
                    lblOutcome.Text = $"You lose!";
                    bankBalance -= betAmount;
                }
                else
                {
                    //Set the point if roll was 4, 5, 6, 8, 9, or 10
                    point = sum;
                    isPointSet = true;
                    lblOutcome.Text = $"Point is {point}";
                }
            }
            else
            {
                //Point roll logic
                if (sum == point)
                {
                    lblOutcome.Text = $"You win!";
                    bankBalance += betAmount; //add money bet from winning
                    isPointSet = false; //Reset point after win
                }
                else if (sum == 7) //check to see if 7 is rolled
                {
                    lblOutcome.Text = $"You lose!";
                    bankBalance -= betAmount; //subtract bet money lost from rolling a 7
                    isPointSet = false;  //Reset point after rolling 7
                                         // btnRoll.Enabled = false ; //disable rolling since the user lost 

                }
                else
                {
                    lblOutcome.Text = $"Point is {point}";
                }
            }

            //Update the bank balance display
            lblBank.Text = $"Bank Balance: ${bankBalance:F2}"; //Give balance to 2 decimal places

            //check if the player has run out of money
            if (bankBalance <= 0)
            {
                MessageBox.Show("You ran out of money. Game over!");
                btnRoll.Enabled = false; //Can't roll again since the game ended
            }
        } //end calculateScore

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset game per user request

            //Display warning message to user stating their game is about to be reset
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset the game? All of your earnings will be lost.",
                "Confirm Reset:",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // If the user clicks yes, reset the game
            if (result ==DialogResult.Yes)
            {
                bankBalance = 100.00m; //Reset the bank balance to $100
                point = 0; //reset point
                isPointSet = false; //Reset point set flag
                txtBet.Text = ""; //Clear bet input
                lblBank.Text = $"Bank Balance: ${bankBalance:F2}"; //Reset bank balance display
                lblOutcome.Text = "Outcome: "; //Reset outcome message
                lblDice1.Text = "Dice 1: "; //Reset dice 1 display
                lblDice2.Text = "Dice 2: "; //Reset dice 2 display
                txtDiceSum.Text = ""; //Reset dice sum display
                btnRoll.Enabled = true; //Re-enable the roll button
            }

        } //end btnClear_Click

    } //end partial class Craps
}//end namespace
