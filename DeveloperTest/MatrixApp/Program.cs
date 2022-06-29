using Matrix;

byte[,] matrix = GenerateMatrix();

MatrixSolver solver = new();
var result = solver.Solve(matrix);
Console.WriteLine(result);

byte[,] GenerateMatrix()
{
    int size = 100;
    byte[,] matrix = new byte[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (i < 15 || j < 15)
            {
                matrix[i, j] = (byte)((i + j) % 2);
            }
            else
            {
                matrix[i, j] = 1;
            }
        }
    }

    return matrix;
}