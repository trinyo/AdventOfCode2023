StreamReader f = new StreamReader("information.txt");

char[] numberFileter = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

int result = 0;
while (!f.EndOfStream)
{
    List<string> number = new List<string>();
    string line = f.ReadLine();

    foreach (char i in line)
    {
        if (numberFileter.Contains(i))
        {
            number.Add(Convert.ToString(i));
        }
    }
    result += Convert.ToInt32(number[0] + number[number.Count - 1]);

}

Console.WriteLine($"The result is: {result}");

// Completed!