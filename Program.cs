namespace Assignment3_2_2
{
    internal class Program
    {
        // Write a program in C# Sharp for addition of two Matrices of same size.
        static void Main(string[] args)
        {
            int[,] firstMatrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] secondMatrix = { { 7, 8, 9 }, { 10, 11, 12 } };
            int[,] addedMatrix;

            addedMatrix = MatrixAddition(firstMatrix, secondMatrix);

            MatrixPrint(addedMatrix);
        }

        // Adds two int Matrixes together. (Matricies must be the same size to add so we can assume dimesion and row length based off one array)
        static int[,] MatrixAddition(int[,] firstArr, int[,] secondArr)
        {
            int rows = firstArr.GetLength(0);
            int cols = firstArr.GetLength(1);
            int[,] twoDTempArr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    twoDTempArr[i, j] = firstArr[i, j] + secondArr[i, j];
                }
            }
            return twoDTempArr;
        }

        // Matrix printer from last assignment
        static void MatrixPrint(int[,] twoDIntArr)
        {
            int rows = twoDIntArr.GetLength(0);
            int cols = twoDIntArr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                Console.Write("|");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($" {twoDIntArr[i, j]} |");
                }
            }
        }
    }
}
