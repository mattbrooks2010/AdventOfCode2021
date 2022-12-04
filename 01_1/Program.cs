var count = 0;
var prev = int.MaxValue;
var line = string.Empty;

while ((line = Console.ReadLine()) != null)
{
    var curr = int.Parse(line);

    if (curr > prev)
    {
        count++;
    }

    prev = curr;
}

Console.WriteLine(count);