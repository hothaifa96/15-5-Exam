using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
     class WordGenerator
    {
        private  List<string> words=new List<string>();
        public string Text = ConfigurationManager.AppSettings["text"];

         public WordGenerator( )
        {
            
        }
        public string GiveMeWord()
        {
            int c = 1;
            string word = "";
            for (int i = 1; i < Text.Length; i++)
            {

                if (i == Text.Length)
                {
                    words.Add(word);
                    break;
                }
                word = word + Text[i-1];
                if (char.IsWhiteSpace(Text[i]) == true)
                {
                    if (char.IsWhiteSpace(Text[i+1]) == false)
                    {

                        c++;
                        words.Add(word);
                        word = "";
                    }
                }
            }
            Random r = new Random();
            return words[r.Next(0,c)];
        }

    }
}
