var hist = new int[12];
var line = string.Empty;

while ((line = Console.ReadLine()) != null)
{
    for (var i = 0; i < line.Length; i++)
    {
        hist[i] += line[i] == '1' ? 1 : -1;
    }
}

hist = hist
    .Select(v => v > 0 ? 1 : 0)
    .ToArray();

var gamma = Convert.ToInt32(string.Join(string.Empty, hist), 2);
var epsilon = gamma ^ 4095;

Console.WriteLine(gamma * epsilon);
