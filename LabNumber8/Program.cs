using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8
{
    class Program
    {

        public static double validate()         //method to validate number before adding it to an array
        {
            double num = 0;

            num = double.Parse(Console.ReadLine());

            while (num != 0 && num != 1 && num != 2 && num != 3 && num != 4)
            {
                Console.WriteLine("Enter in the right number..");
                num = double.Parse(Console.ReadLine());
            }
           
            return num;
        }
        

        public static void addToArray( double[] entries)            //add to array 
        {
            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine("0=out, 1=single, 2=double, 3=triple, 4=homerun");
                entries[i] = validate();
               
            }
        }

        static void Main(string[] args)
        {
            bool cont = true;
            double nonZero = 0;
            double sum = 0;
            int atBat = 0;
            double checkNumber = 0;
            double[] entries;
            Console.WriteLine("Welcome to Batting Average calculator");
            Console.WriteLine("Enter number of times at bat");
            atBat = int.Parse(Console.ReadLine());

            entries = new double[atBat];

          //  checkNumber =  validate();
            addToArray( entries);
            
            for (int i = 0; i < entries.Length; i++)        //Sum array and display slugging percentage
            {
                sum += entries[i];
            }

            Console.WriteLine("The slugging percentage is:" + " " + (sum / atBat));

            for (int i = 0; i < entries.Length; i++)        //Sum array and display batting avg
            {
                if (entries[i] == 0)
                {
                    continue;
                }
                else if (entries[i] > 0)
                {
                    nonZero++;
                }
            }

            Console.WriteLine("The batting average is:" + " " + (nonZero / atBat));
            
        }
    }
    }

