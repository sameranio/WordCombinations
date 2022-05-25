namespace WordCombinations.UnitTests
{
    internal class WordTests
    {
        [Test]
        public void Combine_Words_Gives_Back_List()
        {
            List<Word> words = new List<Word>();
            Word word1 = new Word("test");
            Word word2 = new Word("en");
            Word word3 = new Word("testen");
            words.Add(word1);
            words.Add(word2);
            words.Add(word3);

            Word word = new Word(6);
            List<string> output = word.CombinedWords(words);

            Assert.That(output[0], Is.EqualTo("test + en = testen"));
        }
    }
}
