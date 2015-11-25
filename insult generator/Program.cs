using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insult_generator
{
    class Program
    {
  
        //listen up shit for brains i should be studying right now
        static void Main(string[] args)
        {
            
            bool generated = false;

           

            Console.Write("Hello, welcome to the insult generator.\nPress Enter to generate a phrase:");
            Console.WriteLine();
            Console.ReadLine();
            while (!generated)
            {
                generator();
                Console.ReadLine();
            }
            

            

        }

        static void generator()
        {

            List<string> starts = new List<string>();
            starts.Add("You big");
            starts.Add("You smelly");
            starts.Add("You bloody");
            starts.Add("You fatty");
            starts.Add("You cancer filled");
            starts.Add("You maggot");
            starts.Add("You perverted");
            starts.Add("Ye rude");
            starts.Add("You damn");
            starts.Add("You absolute");

            List<string> middles = new List<string>();
            middles.Add(", crepusculous");
            middles.Add(", arse sniffing");
            middles.Add(", mud engaging");
            middles.Add(", fat dispensing");
            middles.Add(", mother fucking");
            middles.Add(", semen absorbant");
            middles.Add(", badly dressed");
            middles.Add(", elderberry smelling");
            middles.Add(", shit for brains");
            middles.Add(" monstrously challenged");

            List<string> ends = new List<string>();
            ends.Add(" son of a silly person!");
            ends.Add(" fuck fucker!");
            ends.Add(" snot fornicator!");
            ends.Add(" jambagger!");
            ends.Add(" cunt!");
            ends.Add(" sissy!");
            ends.Add(" ungentleman!");
            ends.Add(" stick bundle!");
            ends.Add(" fornicator!");
            ends.Add(" snowflake!");
            ends.Add(" unicorn polisher!");

            Random rdn = new Random();

            int a = rdn.Next(starts.Count);
            int b = rdn.Next(middles.Count);
            int c = rdn.Next(ends.Count);


            string insult = (string)starts[a] + (string)middles[b] + (string)ends[c];

            Console.WriteLine(insult);

        }



    }
}
