var fish = new List<int>();
var line = string.Empty;

while ((line = Console.ReadLine()) != null)
{
    fish.AddRange(line.Split(',').Select(s => int.Parse(s)));
}

for (var day = 1; day <= 80; day++)
{
    var len = fish.Count;

    for (var i = 0; i < len; i++)
    {
        if (fish[i] == 0)
        {
            fish[i] = 6;
            fish.Add(8);
        }
        else
        {
            fish[i]--;
        }
    }
}

Console.WriteLine(fish.Count);
