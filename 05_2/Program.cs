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

    var dx = x2 - x1;
    var dy = y2 - y1;
    var len = Math.Max(Math.Abs(dx), Math.Abs(dy));

    for (var i = 0; i <= len; i++)
    {
        var x = x1 + (i * Math.Sign(dx));
        var y = y1 + (i * Math.Sign(dy));

        coords[x, y]++;
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