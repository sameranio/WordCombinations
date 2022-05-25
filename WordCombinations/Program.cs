using WordCombinations;

string? source;
string? wordLengthToMatch;
int wordLength;
List<Word>? words;
List<string> outputWords;

Console.WriteLine("Enter sourcefile to use (default is input.txt)");
source = Console.ReadLine();

if (string.IsNullOrEmpty(source))
{
    source = "input.txt";
}

Console.WriteLine("Enter length to match words to (default is 6)");
wordLengthToMatch = Console.ReadLine();
Int32.TryParse(wordLengthToMatch, out wordLength);

FileControl file = new FileControl();

words = file.Read(source);

if (words != null)
{
    Word word = new Word(wordLength);
    outputWords = word.CombinedWords(words);

    file.Write(outputWords);
}
else
{
    Console.Write("No file was found.");
}

Console.Write("\nPress 'Enter' to exit the process, you wil find the output file in the root folder.");

while (Console.ReadKey().Key != ConsoleKey.Enter)
{
}