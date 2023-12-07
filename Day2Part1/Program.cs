StreamReader f = new StreamReader("information.txt");

int summaryOfGameNumbers = 0;
while (!f.EndOfStream)
{
    // Indivudual lines 
    string[] line = f.ReadLine().Split(":");
    string gameNumber = line[0].Split(" ")[1];
    string[] rounds = line[1].Split(";");
    // Counters
    int red = 0;
    int green = 0;
    int blue = 0;
    // StillGoodForTheFilter
    bool isGoodForAnswer = true;
    // Going through rounds
    for (int i = 0; i < rounds.Length; i++)
    {
        // one round
        string[] oneInstanceOfRandomizing = rounds[i].Split(",");
        // reseting numbers
        red = 0;
        green = 0;
        blue = 0;
        // Going through the individual numbers
        foreach (var y in oneInstanceOfRandomizing)
        {
            switch (y.Split(" ")[2])
            {
                case "red":
                    red += Convert.ToInt32(y.Split(" ")[1]);
                    break;
                case "green":
                    green += Convert.ToInt32(y.Split(" ")[1]);
                    break;
                case "blue":
                    blue += Convert.ToInt32(y.Split(" ")[1]);
                    break;
            }
        }
        if (red > 12 || green > 13 || blue > 14) isGoodForAnswer = false;
    }
    if (isGoodForAnswer)
    {
        summaryOfGameNumbers += Convert.ToInt32(gameNumber);
    }
}
Console.WriteLine($"The result is: {summaryOfGameNumbers}");