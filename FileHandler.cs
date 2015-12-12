using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Release_Name_Generator
{
    static class FileHandler
    {
        /* These two constants are where the program will look for the adjective and */
        /* noun files. */

        /* Do remember that ./ is the current directory and that in C#, you can use */
        /* both windows-style and UNIX-style directory paths (i.e. the forward and backward slash) */
        private const string ADJECTIVES_DIR = @"./adjectives/";
        private const string NOUNS_DIR = @"./nouns/";

        /// <summary>
        /// Reads the noun file, depending on what syllable count is selected. Default is all.
        /// </summary>
        /// <param name="syllableCount">Enum of NounLevel which is used to select how many syllables in a noun you want</param>
        public static List<string> OpenNouns(NounLevel syllableCount)
        {
            if (syllableCount == NounLevel.All)
            {
                return File.ReadAllLines(NOUNS_DIR + @"91K nouns.txt").ToList();
            }
            else
            {
                return File.ReadAllLines(NOUNS_DIR + (int)syllableCount + "syllablenouns.txt").ToList();
            }
        }

        /// <summary>
        /// Reads the adjective file, depending on what syllable count is selected. Default is all.
        /// </summary>
        /// <param name="syllableCount">Enum of AdjectiveLevel which is used to select how many syllables in an adjective you want</param>
        public static List<string> OpenAdjectives(AdjectiveLevel syllableCount)
        {
            if (syllableCount == AdjectiveLevel.All)
            {
                return File.ReadAllLines(ADJECTIVES_DIR + @"28K adjectives.txt").ToList();
            }
            else
            {
                return File.ReadAllLines(ADJECTIVES_DIR + (int)syllableCount + @"syllableadjectives.txt").ToList();
            }
        }
    }
}
