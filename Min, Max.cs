using System;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = System.IO.File.ReadAllText(@"C:\Users\Толкын\Text\набор_чисел.txt");
            string [] sa;
            sa = text.Split(' ');
            
            int [] MS = Array.ConvertAll(sa,int.Parse);
            int max = MS[0];
            int min = MS[0];

            for ( int i=0; i<MS.Length; i++)
                
            {
                
                if (MS[i]> max)
                {
                    max = MS[i];

                    
                }
                if (MS[i] < min)
                {
                    min = MS[i];
                }

               
            }

            Console.WriteLine(max);
            Console.WriteLine(min);


            Console.ReadKey(); 


        }
    }
}
