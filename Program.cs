using System;

namespace MatrixMultiply
{
    class Program
    {

        // Input and Output of Arrays
        public void InputArr(int n, int m, int[,] arr){
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine();
            }
        }

        public void OutputArr(int n, int m, int[,] arr){
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Multiplication Function
        public void Multiply(int n, int m, int p, int q, int[,] first_arr, int[,] second_arr)
        {
            if (m != p)
            {
                Console.WriteLine("Matrix multiplication not possible (Incorrect count of rows or coulumns)");
                return;
            }
            int[,] result_arr = new int[n, q];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    result_arr[i, j] = 0;
                    for (int k = 0; k < m; k++)
                    {
                        result_arr[i, j] += first_arr[i, k] * second_arr[k, j]; 
                    }
                }
            }
            Console.WriteLine("The Product of two matrixes is: ");
            OutputArr(n, q, result_arr);
        }

        static void Main(string[] args)
        {
            // Input the first matrix
            Program obj = new Program();
            Console.WriteLine("Input the lengths rows and columns of first matrix:");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] first_arr = new int[n, m];
            Console.WriteLine("Input the elements of first matrix:");
            obj.InputArr(n, m, first_arr);
            Console.WriteLine();

            // Input the second matrix
            Console.WriteLine("Input the lengths rows and columns of second matrix:");
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int[,] second_arr = new int[p, q];
            Console.WriteLine("Input the elements of first matrix:");
            obj.InputArr(p, q, second_arr);
            Console.WriteLine();

            // Output Matrixes and result
            Console.WriteLine("First Matrix is: ");
            obj.OutputArr(n, m, first_arr);
            Console.WriteLine("Second Matrix is: ");
            obj.OutputArr(p, q, second_arr);

            obj.Multiply(n, m, p, q, first_arr, second_arr);
        }
    }
}
