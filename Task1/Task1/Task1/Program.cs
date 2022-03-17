using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(max(10,50,5,34));
        }
        static int max(params int[]array)
        {
            int max = array[0];
            foreach(int number in array)
            {
                if(number>max)
                {
                    max = number;
                }
            }
            return max;
        }
        
            
        }
    }

                   


