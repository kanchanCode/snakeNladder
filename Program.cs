using System;

namespace Day4_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;

            //UC1
            Console.WriteLine("Welcome to Snake & Ladder Game");
            Console.WriteLine("Starting position is "+position);

            //UC2_dieRolls obj1 = new UC2_dieRolls();
            //obj1.dieRoll();

            //UC3 obj=new UC3();
            //obj.Die1();
            //obj.Die2();
            //obj.Check();

            // UC4 obj4 = new UC4();
            // obj4.Die1();
            // obj4.Die2();
            // obj4.Check();

            // UC5 obj5 = new UC5();
            // obj5.Die1();
            // obj5.Die2();
            //obj5.Check();

            // UC6 obj6 = new UC6();
            // obj6.Die1();
            // obj6.Die2();
            //obj6.Check();


            UC7 player1 = new UC7();
            UC7 player2 = new UC7();
            player1.Die1();
            player2.Die1();
            player1.Die2();
            player2.Die2();
            player1.Check1();
            Console.WriteLine("^^^^^Player1's total move " + player1.Check1() + " ^^^^^");
            player2.Check2();
            Console.WriteLine("^^^^^Player2's total move " + player2.Check2() + "^^^^^^^");

            if (player1.Check1() > player2.Check2())
            {
                Console.WriteLine("*******Player1 is won by " + (player1.Check1() - player2.Check2()) + " moves********");
            }
            else
            {
                Console.WriteLine("*****Player2 is won by " + (player2.Check2() - player1.Check1()) + " moves********");
            }


            // for different UCs just call the function for that class and rest you can comment 


        }
    }
}
