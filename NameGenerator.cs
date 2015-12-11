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

        private static string CapitalizeFirst(string original)
        {
            char newCh = char.ToUpper(original[0]);
            string newStr = "" + newCh;
            for (int i = 1; i < original.Length; i++)
            {
                newStr += original[i];
            }
            return newStr;
        }
        public static void LoadFiles()
        {
            Nouns = FileHandler.OpenNouns(Settings.NounSetting);
            Adjectives = FileHandler.OpenAdjectives(Settings.AdjSetting);
        }
        public static string Generate()
        {
            if (Nouns == null || Adjectives == null)
            {
                LoadFiles();
            }
            Random dice = new Random();
            return CapitalizeFirst(Adjectives[dice.Next(0, Adjectives.Count - 1)]) + " " +
                CapitalizeFirst(Nouns[dice.Next(0, Nouns.Count - 1)]);
        }
    }
}
