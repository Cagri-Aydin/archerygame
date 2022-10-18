using System;

namespace archerygame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // setting int for player's and bot's coordinates 
            int Ax, Ay, Bx, By, Cx, Cy;

            

            //Gets user's coordinates for starting game 
            Console.WriteLine("Please enter Ax and Ay between (-10,10) to start");
            
            //getting x axis coordinate
            Console.WriteLine("Ax : ");
            Ax = Convert.ToInt16(Console.ReadLine());



            //in case of unvaild locations like (11,9) this code block will ask for new x axis
            //if user type another unvalid location program will shutdown
            if (Ax>10)
            {
                Console.WriteLine(" Enter a valid location! Ax must be between [-10,10] ");
                Console.WriteLine("Ax : ");
                Ax = Convert.ToInt16(Console.ReadLine());
                if (Ax > 10)
                {
                    return;
                }
            }
            //in case of unvaild locations like (-11,9) this code block will ask for new x axis
            //if user type another unvalid location program will shutdown
            if (Ax < -10)
            {
                Console.WriteLine(" Enter a valid location! Ax must be between [-10,10] ");
                Console.WriteLine("Ax : ");
                Ax = Convert.ToInt16(Console.ReadLine());
                if (Ax < -10)
                {
                    return;
                }
            }
            
            //getting y axis coordinate
            Console.WriteLine("Ay : ");
            Ay = Convert.ToInt16(Console.ReadLine());
            
            //in case of unvaild locations like (9,12) this code block will ask for new y axis
            //if user type another unvalid location program will shutdown
            if (Ay > 10)
            {
                Console.WriteLine(" Enter a valid location! Ay must be between [-10,10] ");
                Console.WriteLine("Ay : ");
                Ay = Convert.ToInt16(Console.ReadLine());
                if (Ay > 10)
                {
                    return;
                }
            }
            //in case of unvaild locations like (9,-12) this code block will ask for new y axis
            //if user type another unvalid location program will shutdown
            if (Ay < -10)
            {
                Console.WriteLine(" Enter a valid location! Ay must be between [-10,10] ");
                Console.WriteLine("Ay : ");
                Ay = Convert.ToInt16(Console.ReadLine());
                if (Ay < -10)
                {
                    return;
                }
            }


            //Deciding random locations for both B and C between (11,-11) so they can have locations such as (10,10)
            Random random = new Random();
            Bx = random.Next(-11, 11);
            By = random.Next(-11, 11);
            Cx = random.Next(-11, 11);
            Cy = random.Next(-11, 11);

            //setting players health's
            int hA = 0;
            int hB = 0;
            int hC = 0;
            
            //for giving the random healths we set a new int between (1,8) and for every case we set an if command
            int healthChoose = random.Next(2, 8);

            //every if command is down below
            if (healthChoose == 2 )
            {
                hA = 60;
                hB = 80;
                hC = 100;
            }
            
            if (healthChoose == 3)
            {
                hA = 60;
                hB = 100;
                hC = 80;
            }

            if (healthChoose == 4)
            {
                hA = 80;
                hB = 60;
                hC = 100;
            }

            if (healthChoose == 5)
            {
                hA = 80;
                hB = 100;
                hC = 60;
            }

            if (healthChoose == 6)
            {
                hA = 100;
                hB = 60;
                hC = 80;
            }
            if (healthChoose == 7)
            {
                hA = 100;
                hB = 80;
                hC = 60;
            }
            //and of the health possibility

            int set1 = 0;
            int set2 = 1;
            int set3 = 2;

            int setA = 0;
            int setB = 0;
            int setC = 0;
            
          
            //for giving random sets we set a new int between (1,8) and for every case we set an if command
            int setChoose = random.Next(2, 8);
            //every if command is down below
            if (setChoose==2)
            {
                setA = 0;
                setB = 1;
                setC = 2;
            }
            if (setChoose == 3)
            {
                setA = 0;
                setB = 2;
                setC = 1;
            }
            if (setChoose == 4)
            {
                setA = 1;
                setB = 0;
                setC = 2;
            }
            if (setChoose == 5)
            {
                setA = 1;
                setB = 2;
                setC = 0;
            }
            if (setChoose == 6)
            {
                setA = 2;
                setB = 0;
                setC = 1;
            }
            if (setChoose == 7)
            {
                setA = 2;
                setB = 1;
                setC = 0;
            }

           




            //-----------------------------------
            double disAB, disAC, disBC;

            disAB = Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2));
            disAC = Math.Sqrt(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2));
            disBC = Math.Sqrt(Math.Pow((Bx - Cx), 2) + Math.Pow((By - Cy), 2));



            //we cleared last actions because we didn't wanted a crowded loohing console
            Console.Clear();
            Console.WriteLine("A("+Ax +","+ Ay+") " +" B("+ Bx +","+ By+") " + " C("+Cx +"," + Cy+")");
            Console.WriteLine("   "+hA+"     "+hB +"       "+ hC );
            if (setA==0)
            {
                Console.WriteLine();
            }




        }
    }
}
