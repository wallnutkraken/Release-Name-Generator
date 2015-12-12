using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Release_Name_Generator
{
    static class NameGenerator
    {
        static List<string> Nouns = null;
        static List<string> Adjectives = null;

        /// <summary>
        /// Capitalizes the first character of a string
        /// </summary>
        /// <param name="original">String to capitalize first character of</param>
        private static string CapitalizeFirst(string original)
        {
            /* Strings are, essencially, an array of char. That means that */
            /* original[0] is the first character of the string 'original' */
            /* However, strings, in this way, are read-only. So to change one */
            /* character, you have to make a new string with the new character, */
            /* and copy over the rest of the characters to the new string */
            char newCh = char.ToUpper(original[0]);
            string newStr = "" + newCh;
            for (int i = 1; i < original.Length; i++)
            {
                newStr += original[i];
            }
            return newStr;
        }
        /// <summary>
        /// Loads the files containing huge lists of nouns and adjectives
        /// </summary>
        public static void LoadFiles()
        {
            Nouns = FileHandler.OpenNouns(Settings.NounSetting);
            Adjectives = FileHandler.OpenAdjectives(Settings.AdjSetting);
        }
        /// <summary>
        /// Generates a random combination of a noun and an adjective
        /// </summary>
        public static string Generate()
        {
            if (Nouns == null || Adjectives == null)
            {
                LoadFiles();
            }
            /* Since this method has a return type of string, we can generate the string we want to return on the */
            /* same line as the return. What's happening here is that we get a random number that isn't bigger */
            /* than the number of string objects in the Nouns and Adjectives lists (above). Then using that number */
            /* we find the corresponding Adjective/Noun, capitalize the first character, put a space between them */
            /* and return the resulting string */
            return CapitalizeFirst(Adjectives[RandomGenerator.GetRandomNumber(0, Adjectives.Count - 1)]) + " " +
                CapitalizeFirst(Nouns[RandomGenerator.GetRandomNumber(0, Nouns.Count - 1)]);
        }
    }
}
