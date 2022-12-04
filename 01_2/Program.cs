var count = 0;
var prev = int.MaxValue;
var group = new List<int>();
var line = string.Empty;

while ((line = Console.ReadLine()) != null)
{
    group.Add(int.Parse(line));

    if (group.Count == 3)
    {
        var curr = group.Sum();

        if (curr > prev)
        {
            count++;
        }
        
        prev = curr;
        group.RemoveAt(0);
    }
}

Console.WriteLine(count);