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
            int[,] twoDTempArr = new int[firstArr.GetLength(0), firstArr.GetLength(1)];
            for (int i = 0; i < firstArr.GetLength(0); i++)
            {
                for (int j = 0; j < firstArr.GetLength(1); j++)
                {
                    twoDTempArr[i, j] = firstArr[i, j] + secondArr[i, j];
                }
            }
            return twoDTempArr;
        }

        // Matrix printer from last assignment
        static void MatrixPrint(int[,] twoDIntArr)
        {
            for (int i = 0; i < twoDIntArr.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.Write("|");
                for (int j = 0; j < twoDIntArr.GetLength(1); j++)
                {
                    Console.Write($" {twoDIntArr[i, j]} |");
                }
            }
        }
    }
}
