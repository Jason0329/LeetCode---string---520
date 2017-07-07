using System;

namespace LeetCode___string___520
{
    class Program
    {
        static void Main(string[] args)
        {
            string sss = "USA";
            Solution ss = new Solution();
            Console.WriteLine(ss.DetectCapitalUse(sss));
        }

        
    }

    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            char[] WordChar = word.ToCharArray();

            if(WordChar[0]>=65 && WordChar[0] <=90)
            {
                if (WordChar.Length == 1)
                    return true;

                if (WordChar[1] >= 97 && WordChar[1] <= 122)
                {
                    for (int i = 2; i < WordChar.Length; i++)
                    {
                        if (WordChar[i] < 97 || WordChar[i] > 122)
                            return false;
                    }
                }
                else if (WordChar[1] >= 65 && WordChar[1] <= 90)
                {
                    for (int i = 2; i < WordChar.Length; i++)
                    {
                        if (WordChar[i] < 65 || WordChar[i] > 90)
                            return false;
                    }
                }

            }
            else if (WordChar[0] >=97 && WordChar[0] <=122)
            {
                for(int i=1; i<WordChar.Length; i++)
                {
                    if (WordChar[i] < 97 || WordChar[i] > 122)
                        return false;
                }
            }

            return true;

        }
    }
}