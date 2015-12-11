using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Release_Name_Generator
{
    static class Settings
    {
        public static AdjectiveLevel AdjSetting { get; set; } = AdjectiveLevel.All;
        public static NounLevel NounSetting { get; set; } = NounLevel.All;
    }
    public enum AdjectiveLevel
    {
        OneSyllable = 1,
        TwoSyllable,
        ThreeSyllable,
        FourSyllable,
        All
    } 

    public enum NounLevel
    {
        OneSyllable = 1,
        TwoSyllable,
        ThreeSyllable,
        FourSyllable,
        All
    }
}
