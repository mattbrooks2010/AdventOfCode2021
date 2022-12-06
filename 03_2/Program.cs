var diag = new List<string>();
var line = string.Empty;

while ((line = Console.ReadLine()) != null)
{
    diag.Add(line);
}

int GetRating(Func<int, bool> bitComparer)
{
    // Don't mutate original collection
    var data = diag.ToList();

    for (var i = 0; i < 12; i++)
    {
        var hist = 0;

        foreach (var line in data)
        {
            hist += line[i] == '1' ? 1 : -1;
        }

        var common = bitComparer(hist) ? '1' : '0';

        for (var j = 0; j < data.Count; j++)
        {
            if (common != data[j][i])
            {
                data.RemoveAt(j);
                j -= 1;
            }
        }

        if (data.Count == 1)
        {
            break;
        }
    }

    return Convert.ToInt32(string.Join(string.Empty, data[0]), 2);
}

var o2 = GetRating(h => h >= 0);
var co2 = GetRating(h => h < 0);

Console.WriteLine(o2 * co2);
