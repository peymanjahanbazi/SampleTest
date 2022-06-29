namespace Matrix;

public class MatrixSolver
{
    public MatrixSolver(int boxSize = 3)
    {
        this.boxSize = boxSize;
    }

    private readonly int boxSize;

    public (int row, int col) Solve(byte[,] matrix)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        int bestRow = row + 1;
        int bestCol = col + 1;
        int bestDistance = bestRow * bestRow + bestCol * bestCol;
        for (int i = 0; i < row - boxSize; i++)
        {
            for (int j = 0; j < col - boxSize; j++)
            {
                int distance = i * i + j * j;
                if (distance > bestDistance)
                {
                    break;
                }
                if (AnalyseBox(matrix, i, j))
                {
                    bestRow = i;
                    bestCol = j;
                    bestDistance = bestRow * bestRow + bestCol * bestCol;
                }
            }
        }
        return (bestRow, bestCol);
    }

    private bool AnalyseBox(byte[,] matrix, int startRow, int startCol)
    {
        for (int i = startRow; i < startRow + boxSize; i++)
        {
            for (int j = startCol; j < startCol + boxSize; j++)
            {
                if (matrix[i, j] == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
}