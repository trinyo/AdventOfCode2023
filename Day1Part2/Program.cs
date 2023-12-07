StreamReader f = new StreamReader("information.txt");

int result = 0;
while (!f.EndOfStream)
{
    string line = f.ReadLine();
    string numberInTextFormat = "";
    List<string> numberList = new List<string>();
    Dictionary<string, char> numbersFilter = new Dictionary<string, char>
    {
        ["zero"] = '0',
        ["one"] = '1',
        ["two"] = '2',
        ["three"] = '3',
        ["four"] = '4',
        ["five"] = '5',
        ["six"] = '6',
        ["seven"] = '7',
        ["eight"] = '8',
        ["nine"] = '9'
    };
    for (int i = 0; i < line.Length; i++)
    {
        // Basic number
        if (numbersFilter.ContainsValue(line[i])) numberList.Add(Convert.ToString(line[i]));
        //  String number
        if (i + 3 <= line.Length && numbersFilter.ContainsKey(line.Substring(i,3))) numberList.Add(Convert.ToString(numbersFilter[line.Substring(i,3)]));
        if (i + 4 <= line.Length && numbersFilter.ContainsKey(line.Substring(i,4))) numberList.Add(Convert.ToString(numbersFilter[line.Substring(i,4)]));
        if (i + 5 <= line.Length && numbersFilter.ContainsKey(line.Substring(i,5))) numberList.Add(Convert.ToString(numbersFilter[line.Substring(i,5)]));
    } 
    // Console.WriteLine($"{numberList[0]} és {numberList[numberList.Count - 1]}");
    result += Convert.ToInt32(numberList[0] + numberList[numberList.Count - 1]);
}
Console.WriteLine($"The result is: {result}");

// Completed!