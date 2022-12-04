var x = 0;
var z = 0;
var line = string.Empty;

while ((line = Console.ReadLine()) != null)
{
    var v = int.Parse(line.Split(' ')[1]);

    switch (line[0])
    {
        case 'f':
            x += v;
            break;
        case 'd':
            z += v;
            break;
        case 'u':
            z -= v;
            break;
    }
}

Console.WriteLine(x * z);