using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math = System.Math;


namespace Monte_Carlo_boi
{
   public struct XYpair

    {
        public double X;
        public double Y;

    }

    class Program
    {
        XYpair coords = new XYpair();
        public double dividoboi;
        Random Rando = new Random();
        public double counter;
        public double arraySize;
        
        static void Main(string[] args)
        {
           // Program DoItNow = new Program();
                Program DoItNow = new Program();
                DoItNow.Run();
            
           }

        public void Run()
        {
            bool running = true;
            while (running)
            {

                ConsoleKeyInfo userinputboi;
                userinputboi = Console.ReadKey(true);


                switch (userinputboi.Key)
                {
                    case ConsoleKey.Escape:
                        {
                            running = false;
                        }
                        break;

                    default:
                        counter = 0;
                        arraySize = 0;
                        Execute();

                        break;





                }
            }
        }

        public void MakePair()
        {
            //XYpair coords = new XYpair();
            coords.X = RandoMaker();
            coords.Y = RandoMaker(); 
            
        }

        public double InputBoi()
        {
            Console.WriteLine("How many times do you wish to execute this?");
            double input = double.Parse(Console.ReadLine());
            
            return input;
        }

        public void Execute()
        {

          
            double[] array = new double[(int)InputBoi()];
            arraySize = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] =  HypotenuseBoi(RandoMaker(), RandoMaker());

            }

            //dividoboi=(  arraySize/counter) ;
            dividoboi = ( counter/arraySize );
            dividoboi *= 4;

            output();
            Console.ReadKey();

        }

        public double HypotenuseBoi(double X, double Y)
        {
                  
            double side1 = (X * X);
            double side2 = (Y * Y);
            double Hypotenuse = Math.Sqrt(side1 + side2 );

            if (Hypotenuse <= 1)
            { counter++; }

            return Hypotenuse;

        }

        public double RandoMaker()
        {
          double value =  Rando.NextDouble();
          return value;



        }

        public void output()
        {
            
            Console.WriteLine($"Total number of hypotenuseseseseses greater than 1: {counter}");

            Console.WriteLine($" Estimation of pi {dividoboi}");
            //Console.WriteLine($" Estimation of pi {dividoboi1}");

            Console.WriteLine($"Math.Pi's value: {System.Math.PI}");
           

            





        }

    }
}
