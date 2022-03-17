using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Binary(5));
        }
        static int Binary(int n)
        {
            int rem = 0;
            int rev = 0;
            int count = 0;
            for (int i = 0; n>0; i++)
            {
                rem = n % 2;
                n = n / 2;
                rev = rev * 10 + rem;
                if(rem==1)
                {
                    count++;
                }
            }
            return count;
        }
      
        }
    }


