using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCombinations
{
    public class Word
    {
        public Word(string word)
        {
            Text = word;
            Length = word.Length;
        }

        int WordLengthToBuild = 6;

        public string Text { get; set; }
        public int Length { get; set; }
    }
}
