using System.Diagnostics.Metrics;

namespace ReviewForMidterm
{
    public class Program
    {
        public static void Main()
        {
            //store the word that we want to check to see if it a palindrome
            string word;
            char[] chars;

            Console.Write("What word do you want to check to see if it is a palindrome? ");
            word = Console.ReadLine();

            
            word = "racecar";

            char[] letter2 = { 'r', 'a', 'c', 'e', 'c', 'a', 'r' };
            
            char[] letter3 = new char[7];

                letter3[0] = 'r';
                letter3[1] = 'a';
                letter3[2] = 'c';
                letter3[3] = 'e';
                letter3[4] = 'c';
                letter3[5] = 'a';
                letter3[6] = 'r';

            foreach(char l in letter3)
            {
                Console.WriteLine(l);
            }

            switch(letter3[0])
            {
                case 'r':
                    Console.WriteLine();
                    break;
                case 'a':
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }


            char[] letter = word.ToCharArray();
            

            //   chars = MySuperSpecialToCharacterArray(word);

            Console.WriteLine(CheckForPalindrome(word));
            Console.WriteLine(word);

            Convert.ToInt32(Console.ReadLine());

            for (int n = 0; 0 < word.Length; n++)
            {

            }



            double myvariableisgreat = 100;
        }

        public static char[] MySuperSpecialToCharacterArray(string word) 
        {
            char[] letters;

            if (word is not null)
            {
               letters = new char[word.Length];
            }
            else if(word == "" || word == " ")
            {
                return new char[0];
            }
            else
            {
               return new char[0];
            }
        
            for (int i = 0; i < word.Length; i++)
            {
                letters[i] = word[i];
            }

            return letters;
           
        }

        public static bool CheckForPalindrome(string word) 
        {
            word = word.ToLower();

            for (int i = 0; i < (word.Length / 2); i++)
            {
                if(word[i] != word[word.Length - (i+1)])
                {
                    return false;
                }
               
            }
            return true;

        }
    
    }//end class

}//end namespace