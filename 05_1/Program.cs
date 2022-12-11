var coords = new int[1000, 1000];
var line = string.Empty;

while ((line = Console.ReadLine()) != null)
{
    var parts = line.Split(" -> ");
    var x1y1 = parts[0].Split(',');
    var x2y2 = parts[1].Split(',');
    var x1 = int.Parse(x1y1[0]);
    var y1 = int.Parse(x1y1[1]);
    var x2 = int.Parse(x2y2[0]);
    var y2 = int.Parse(x2y2[1]);

    if (x1 == x2 || y1 == y2)
    {
        if (x1 > x2 || y1 > y2)
        {
            var x1tmp = x1;
            var y1tmp = y1;
            x1 = x2;
            y1 = y2;
            x2 = x1tmp;
            y2 = y1tmp;
        }

        for (var x = x1; x <= x2; x++)
        {
            for (var y = y1; y <= y2; y++)
            {
                coords[x, y]++;
            }
        }
    }
}

var overlaps = 0;

for (var i = 0; i < coords.GetLength(0); i++)
{
    for (var j = 0; j < coords.GetLength(1); j++)
    {
        if (coords[i, j] >= 2)
        {
            overlaps++;
        }
    }
}

Console.WriteLine(overlaps);