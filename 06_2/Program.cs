var fish = new ulong[9];
var count = 0UL;

var line = string.Empty;

while ((line = Console.ReadLine()) != null)
{
    foreach (var t in line.Split(',').Select(s => int.Parse(s)))
    {
        fish[t]++;
        count++;
    }
}

for (var i = 0; i < 256; i++)
{
    var @new = fish[0];
    count += @new;

    for (var j = 0; j < fish.Length; j++)
    {
        if (j == 6)
        {
            fish[j] = fish[j + 1] + @new;
        }
        else if (j == 8)
        {
            fish[j] = @new;
        }
        else
        {
            fish[j] = fish[j + 1];
        }
    }
}

Console.WriteLine(count);
