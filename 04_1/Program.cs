var line = Console.ReadLine() ?? string.Empty;
var numbers = new List<int>(line.Split(',').Select(n => int.Parse(n)));
var boards = new List<(int number, bool marked)[,]>();
var row = 0;

while ((line = Console.ReadLine()) != null)
{
    if (line.Length == 0)
    {
        boards.Add(new (int number, bool marked)[5, 5]);
        row = 0;
    }
    else
    {
        boards[^1][row, 0] = (int.Parse(line.Substring(0, 2)), false);
        boards[^1][row, 1] = (int.Parse(line.Substring(3, 2)), false);
        boards[^1][row, 2] = (int.Parse(line.Substring(6, 2)), false);
        boards[^1][row, 3] = (int.Parse(line.Substring(9, 2)), false);
        boards[^1][row, 4] = (int.Parse(line.Substring(12, 2)), false);

        row++;
    }
}

void Bingo()
{
    foreach (var num in numbers)
    {
        foreach (var board in boards)
        {
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    if (board[i, j].number == num)
                    {
                        board[i, j].marked = true;

                        var row = 0;
                        var col = 0;

                        for (var k = 0; k < 5; k++)
                        {
                            if (board[i, k].marked)
                            {
                                row++;
                            }
                            
                            if (board[k, j].marked)
                            {
                                col++;
                            }
                        }

                        if (row == 5 || col == 5)
                        {
                            var score = 0;

                            for (var k = 0; k < 5; k++)
                            {
                                for (var l = 0; l < 5; l++)
                                {
                                    if (!board[k, l].marked)
                                    {
                                        score += board[k, l].number;
                                    }
                                }
                            }

                            Console.WriteLine(score * num);
                            return;
                        }
                    }
                }
            }
        }
    }
}

Bingo();
