Console.WriteLine("Введите предложение без знаков препинания");
string str = Console.ReadLine();
string[] strArray = str.Split();
string max = strArray[0];
foreach (string s in strArray)
{
    if (s.Length>max.Length)
    {
        max= s;
    }
}
Console.WriteLine("Самое длинное слово в предложении:");
Console.WriteLine(max);