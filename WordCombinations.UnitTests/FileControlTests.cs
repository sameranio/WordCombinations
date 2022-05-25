global using NUnit.Framework;
global using WordCombinations;

namespace WordCombinations.UnitTests
{
    public class FileControlTests
    {
        [Test]
        public void ReadFile_ExistingFile_ReturnsText()
        {
            FileControl file = new FileControl();

            List<Word>? words = file.Read("input.txt");

            Assert.IsNotNull(words);
        }
        [Test]
        public void WriteFile_WithFileText_ReturnsTrue()
        {
            FileControl file = new FileControl();
            List<Word> words = new List<Word>();
            Word word1 = new Word("Test1");
            Word word2 = new Word("Test2");
            Word word3 = new Word("Test3");
            words.Add(word1);
            words.Add(word2);
            words.Add(word3);

            Boolean completed = file.Write(words)
        }
    }
}