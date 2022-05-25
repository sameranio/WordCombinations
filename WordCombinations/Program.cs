using WordCombinations;

string? source;
List<Word>? words;
List<string> outputWords;
string path = "../../../";

Console.WriteLine("Enter sourcefile to use (default is input.txt)");
source = Console.ReadLine();

if (string.IsNullOrEmpty(source))
{
    source = "input.txt";
}

Console.WriteLine("{0} is the sourcefile", source);

FileControl file = new FileControl();

words = file.Read(source);

if (words != null)
{
    foreach (Word word in words)
    {
        Console.WriteLine("Word: {0}, Length of word: {1}", word.Text, word.Length);
    }
} else
{
    Console.Write("No file was found.");
}

Console.Write("\nPress 'Enter' to exit the process, you wil find the output file in the root folder.");

while (Console.ReadKey().Key != ConsoleKey.Enter)
{
}