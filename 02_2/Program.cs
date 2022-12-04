var x = 0;
var z = 0;
var r = 0;
var line = string.Empty;

while ((line = Console.ReadLine()) != null)
{
    var v = int.Parse(line.Split(' ')[1]);

    switch (line[0])
    {
        case 'f':
            x += v;
            z += r * v;
            break;
        case 'd':
            r += v;
            break;
        case 'u':
            r -= v;
            break;
    }
}

Console.WriteLine(x * z);