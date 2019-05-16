using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Game
    {
        char[] wordarr;
        public string Word { get; set; }

        public Game(string word)
        {
            this.Word = word.Trim(' ');
             wordarr = new char[Word.Length];
        }
        public bool Print(char c)
        {
            Console.WriteLine();
            if(Word.Contains(c))
            {
                
                for (int i = 0; i < Word.Length; i++)
                {
                    if (Word[i] == c)
                        wordarr[i] = c;
                }
            }
            string check ="";
            for (int i = 0; i < Word.Length; i++)
            {
               
            
                if (wordarr[i] == Word[i])
                {
                    Console.Write(wordarr[i]);
                    check+= wordarr[i];
                }
                else
                    Console.Write("_");
                
                
                   
            }
            if(Word==check)
                return false;
            return true;
        
        }

        public void GameOver(int tries)
        {
            Console.WriteLine("Finally        tries {0}",tries);
        }
    }
}
