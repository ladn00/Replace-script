using System.Text.RegularExpressions;

string inputFilePath = @"C:\Users\zueva\Desktop\data2.txt";

try
{
    string content = File.ReadAllText(inputFilePath);
    WriteToOutputFileIds(content, @"width: 63px;"">(\d+)</td>");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void WriteToOutputFileIds(string content, string pattern)
{
    MatchCollection matches = Regex.Matches(content, pattern, RegexOptions.Singleline);

    using (StreamWriter outputFile = new StreamWriter("OutputIds.txt"))
    {
        foreach (Match match in matches)
        {
            outputFile.WriteLine(match.Groups[1].Value);
        }
    }
}