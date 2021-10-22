using System;

namespace Day4_Assignment
{
    class UC2_dieRolls
    {
        
        //boolean for player 2


        public int dieRoll()
        {

            Random random = new Random();
            int outcome = random.Next(1, 7);
            Console.WriteLine("outcome of die1 is "+outcome);
            return outcome;
        }
    }
}

        
