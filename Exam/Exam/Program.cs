using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            MyUniqueList<int> my = new MyUniqueList<int>();
            my.Add(186);
            Console.WriteLine(my[0]);
            GuessTheWord();

        }

        private static void GuessTheWord()
        {
            char c;
            WordGenerator generator = new WordGenerator();
            int input;
            int counter = 0;
            Console.WriteLine("                  ****welcome****               ");
            Console.WriteLine("for new game press 1");
            Console.WriteLine("press any key to Exit");
            input = int.Parse(Console.ReadLine());
            while (input == 1) 
            {
                Console.WriteLine("for new game press 1");
                Console.WriteLine("press any key to Exit" );
                input = int.Parse(Console.ReadLine());

                string word = generator.GiveMeWord();
                Console.WriteLine(word.Trim(' '));
                Game g = new Game(word);
                do
                {
                    Console.WriteLine("throw a litter");
                    c = Console.ReadKey().KeyChar;
                    counter++;

                } while (g.Print(c));
                g.GameOver(counter);
            } 

            

            
        }
    }
}
