namespace WordCombinations
{
    public class Word
    {
        private int WordLengthToBuild = 6;
        public string Text { get; set; }
        public int Length { get; set; }
        public Word(string word)
        {
            Text = word;
            Length = word.Length;
        }

        public Word(int wordLengthToBuild)
        {
            if (wordLengthToBuild != 0)
            {
                WordLengthToBuild = wordLengthToBuild;
            }
        }

        /// <summary>
        /// Split the list up into two lists one with all words to build towards and another with words to use for building.
        /// </summary>
        /// <param name="words"></param>
        /// <returns>combined words list.</returns>
        public List<string> CombinedWords(List<Word> words)
        {
            List<string> wordsToMatchAgainst = words.Where(x => x.Length == WordLengthToBuild).Select(x => x.Text.ToString()).ToList();
            List<string> wordsToMatch = words.Where(x => x.Length != WordLengthToBuild).Select(x => x.Text.ToString()).ToList();
            List<string> combinedWords = new List<string>();
            List<string> usedWords = new List<string>();

            foreach(string firstPart in wordsToMatch)
            {
                int lengthToCombineWith = WordLengthToBuild - firstPart.Length;
                List<string> wordsToCombineWith = wordsToMatch.Where(x => x.Length == lengthToCombineWith).Except(usedWords).ToList();

                foreach(string secondPart in wordsToCombineWith)
                {
                    string result = string.Concat(firstPart, secondPart);

                    if (wordsToMatchAgainst.Contains(result))
                    {
                        string output = string.Concat(firstPart, " + ", secondPart, " = ", result);

                        combinedWords.Add(output);
                        break;
                    }
                }

                usedWords.Add(firstPart);
            }

            return combinedWords;
        }
    }
}
