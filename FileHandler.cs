using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Release_Name_Generator
{
    static class FileHandler
    {
        private const string ADJECTIVES_DIR = @"./adjectives/";
        private const string NOUNS_DIR = @"./nouns/";
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
