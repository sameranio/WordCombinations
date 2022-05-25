using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCombinations
{
    public class FileControl
    {
        public List<Word>? Read(string source)
        {
            if (File.Exists(source))
            {
                List<Word> readWords = new List<Word>();
                FileStream fs = new FileStream(source, FileMode.Open);

                using (StreamReader reader = new StreamReader(fs))
                {
                    Word word;

                    string? line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        word = new Word(line);
                        readWords.Add(word);
                    }
                }

                return readWords;
            }

            return null;
        }

        public Boolean Write(List<string> words)
        {
            using StreamWriter file = new("%temp%/output.txt");

            foreach (string word in words)
            {
                file.Write(word.ToString());
            }

            return true;
        }
    }
}
