using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace malefemale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countm=0,countf=0;

            Console.WriteLine("****Welcome to wedding Ceremony*****");
            //char[] gender = { 'M', 'F', 'M', 'F', 'M', 'F', 'M', 'F', 'M', 'F' };
            int n=Convert.ToInt32(Console.ReadLine());

            char[] gender = new char [n];
            for(int iterate=0;iterate<n;iterate++)
            {
                gender[iterate]=Convert.ToChar(Console.ReadLine());   
            }
            Console.WriteLine("The Gender are:");

            for (int pos = 0; pos < gender.Length; pos++) {
                if (gender[pos] == 'M')
                {
                    countm++;        
                }

                else if(gender[pos] == 'F')
                {
                    countf++;
                }

                }
            Console.WriteLine("no. of males:"+countm);
            Console.WriteLine("no. of Females:"+countf);
            Console.ReadLine();
        }
        
        }
    }
