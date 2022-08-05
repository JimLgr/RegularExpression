using System.Text.RegularExpressions;

Console.WriteLine("Tappez une phrase");
string inPhrase2 = Console.ReadLine();
if (inPhrase2.Length > 1)
{ 
    Console.WriteLine(inPhrase2[1..^1]);
}













