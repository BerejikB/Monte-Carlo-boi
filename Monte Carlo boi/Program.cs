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
       
        Random Rando = new Random();
        public int counter;
        public int arraySize;
        
        static void Main(string[] args)
        {
           // Program DoItNow = new Program();
            bool running = true;
            while (running)
            {

                Program DoItNow = new Program();
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
                    DoItNow.Execute();
                    
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
            arraySize = (int)input;
            return input;
        }

        public void Execute()
        {

            InputBoi();
            double[] array = new double[arraySize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] =  HypotenuseBoi(RandoMaker(), RandoMaker());

           
            }
            double dividoboi =    arraySize /=   counter;
            //double dividoboi1 =   counter /= arraySize;
            dividoboi *= 4;


            Console.WriteLine($"Total number of hypotenuseseseseses greater than 1: {counter}");
                     
            Console.WriteLine($" Estimation of pi {dividoboi}");
            //Console.WriteLine($" Estimation of pi {dividoboi1}");

            Console.WriteLine($"Math.Pi's value: {System.Math.PI}");
            
            Console.ReadKey();
           


        }

        public double HypotenuseBoi(double X, double Y)
        {
                      
            double side1 = (X * X);
            double side2 = (Y * Y);
            double Hypotenuse = Math.Sqrt(side1 + side2 );

            if (Hypotenuse > 1)
            { counter++; }

            return Hypotenuse;

        }

        public double RandoMaker()
        {
          double value =  Rando.NextDouble();
          return value;



        }

       

    }
}
