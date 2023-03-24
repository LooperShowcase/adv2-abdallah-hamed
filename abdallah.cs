using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace abdallah_hamed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] lines = { '_', '_', '_', '_' };
            int hearts = 4;
            Console.WriteLine("WELCOME TO ABOOD GAME");
            string tw = getTodayWord();
            printLines(lines);
            while (hearts > 0)
            {
                char ch = askUser();
                int result = checkLetter(tw, ch, lines);
                if (result == -1)
                {
                    hearts--;
                    Console.WriteLine("you have a " + hearts + " hearts");
                }
                else
                {
                    lines[result] = ch;
                }
                printLines(lines);

                if (checkwin(lines))
                {
                    break;
                }
            }

            if (hearts > 0)
            {
                Console.WriteLine("you win");
            }
            else
            {
                Console.WriteLine("you lose");
            }
            
        }
        public static char askUser()
        {
            Console.WriteLine("please enter a char");
            char c = Console.ReadLine()[0];
            return c;
        }
        public static int checkLetter(string todayword, char ch, char[] lines)
        {
            for (int i = 0; i < todayword.Length; i++)
            {
                if (todayword[i] == ch)
                {
                    return i;
                }
                
            }
            return -1;

        }


        public static bool checkwin(char[] lines)
        {
            for(int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == '_')
                {
                    return true;
                }
            }
            return false;
        }
        public static string getTodayWord()
        {
            string[] words = {"mice", "bait", "love", "hate", "care"};
            Random rnd = new Random();

            return words[rnd.Next(words.Length)];

        }


        public static void printLines(char[] lines) {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.Write(lines[i] + " ");
            }
        }
    }
    
    
        


}
