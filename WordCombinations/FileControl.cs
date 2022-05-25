using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace WordCombinations
{
    public class FileControl
    {
        /// <summary>
        /// Read out the file at the given source
        /// </summary>
        /// <param name="source"></param>
        /// <returns>a list of the type word.</returns>
        public List<Word>? Read(string source)
        {
            if (File.Exists(source))
            {
                List<Word> readWords = new List<Word>();

                foreach (string line in File.ReadLines(source))
                {
                    Word word;

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

        /// <summary>
        /// Write the given list out in the output.txt file
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public Boolean Write(List<string> words)
        {
            using StreamWriter file = new("Output.txt");

            if (file != null)
            {
                foreach (string word in words)
                {
                    file.Write(string.Concat(word.ToString(), "\n"));
                }

                file.Close();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
