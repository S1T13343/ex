
public class Matrix
{
    private int[,] data;

    public Matrix(string input)
    {
        var rows = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        int rowCount = rows.Length;
        int colCount = rows[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

        data = new int[rowCount, colCount];

        for (int i = 0; i < rowCount; i++)
        {
            var numbers = rows[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse).ToArray();
            for (int j = 0; j < colCount; j++)
            {
                data[i, j] = numbers[j];
            }
        }
    }

    public int[] Row(int row)
    {
        int rowIndex = row - 1;
        int cols = data.GetLength(1);
        int[] result = new int[cols];

        for (int j = 0; j < cols; j++)
        {
            result[j] = data[rowIndex, j];
        }

        return result;
    }

    public int[] Column(int col)
    {
        int colIndex = col - 1;
        int rows = data.GetLength(0);
        int[] result = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            result[i] = data[i, colIndex];
        }

        return result;
    }
}

