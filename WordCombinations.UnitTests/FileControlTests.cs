namespace WordCombinations.UnitTests
{
    public class FileControlTests
    {
        [Test]
        public void ReadFile_ExistingFile_ReturnsText()
        {
            FileControl file = new FileControl();

            List<Word>? words = file.Read("C:\\Users\\samug\\AppData\\Local\\Temp\\input.txt");

            Assert.IsNotNull(words);
        }
        [Test]
        public void WriteFile_WithFileText_ReturnsTrue()
        {
            FileControl file = new FileControl();
            List<string> words = new List<string>();
            string word1 = "Test1";
            string word2 = "Test2";
            string word3 = "Test3";
            words.Add(word1);
            words.Add(word2);
            words.Add(word3);

            Boolean completed = file.Write(words);

            Assert.IsTrue(completed);
        }
    }
}