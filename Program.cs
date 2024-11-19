namespace Assignment_3_2_2
{
    internal class Program
    {
        static void Main(string[] args)

            //Get user input on size of matrix and convery to an integer. 
        {
            Console.Write("Input the size of the square matrix (less than 5): "); 
            int size = int.Parse(Console.ReadLine());


            // Dummy proof it. 
            if (size < 1 || size > 4)
            {
                Console.WriteLine("Invalid size. Please enter a size between 1 and 4.");
                return;
            }

            //Declare 2 matrices to add together and 1 to display as the sum. 
            int[,] matrix1 = new int[size, size];
            int[,] matrix2 = new int[size, size];
            int[,] resultMatrix = new int[size, size];

            Console.WriteLine("\nInput elements in the first matrix:");
            InputMatrix(matrix1);

            Console.WriteLine("\nInput elements in the second matrix:");
            InputMatrix(matrix2);

            Console.WriteLine("\nThe First matrix is:");
            PrintMatrix(matrix1);

            Console.WriteLine("\nThe Second matrix is:");
            PrintMatrix(matrix2);

            // Perform addition of the two matrices using a nested for loop. 
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j]; //Adding them together. 
                }
            }

            Console.WriteLine("\nThe sum of two matrices is:");
            PrintMatrix(resultMatrix);
        }

        // Method to input matrix values
        static void InputMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Method to print matrix in a formatted way
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
