StreamReader f = new StreamReader("information.txt");

int summaryOfGameNumbers = 0;
while (!f.EndOfStream)
{
    // Indivudual lines 
    string[] line = f.ReadLine().Split(":");
    string[] rounds = line[1].Split(";");
    
    // Counters
    int red = 0;
    int green = 0;
    int blue = 0;
    for (int i = 0; i < rounds.Length; i++)
    {
        // one round
        string[] oneInstanceOfRandomizing = rounds[i].Split(",");
        
        foreach (var y in oneInstanceOfRandomizing)
        {
            switch (y.Split(" ")[2])
            {
                case "red":
                    if (red < Convert.ToInt32(y.Split(" ")[1])) red = Convert.ToInt32(y.Split(" ")[1]);
                    break;
                case "green":
                    if (green < Convert.ToInt32(y.Split(" ")[1]))green = Convert.ToInt32(y.Split(" ")[1]);
                    break;
                case "blue":
                    if (blue < Convert.ToInt32(y.Split(" ")[1]))blue = Convert.ToInt32(y.Split(" ")[1]);
                    break;
            }
        }
    }
    summaryOfGameNumbers += red * green * blue;
}
Console.WriteLine($"The result is: {summaryOfGameNumbers}");