namespace c_sharp_pract_2
{//lab ex-2
    using c_sharp_pract_2.Entity;
    internal class Program
    {

        static void Main()
        {
            var random = new Random();
            int[,] initialData = new int[3, 3];

            for (int i = 0; i < initialData.GetLength(0); i++)
            {
                for (int j = 0; j < initialData.GetLength(1); j++)
                {
                    initialData[i, j] = random.Next(0, 10);
                }
            }
            try
            {

                Matrix matrix = new Matrix(initialData);
                Console.WriteLine("Matrix 1:");
                matrix.DisplayMatrix();

                Matrix matrix2 = matrix;
                Console.WriteLine("Matrix 2:");
                matrix2.DisplayMatrix();

                Console.WriteLine($"Matrix 1 == matrix 2: {matrix == matrix2}");

                Console.WriteLine("Matrix 1 + matrix 2: ");
                Matrix matrix3 = matrix + matrix2;
                matrix3.DisplayMatrix();

                Console.WriteLine("Matrix 1 - matrix 2: ");
                Matrix matrix4 = matrix - matrix2;
                matrix4.DisplayMatrix();

                Console.WriteLine("Matrix 1 * matrix 2: ");
                Matrix matrix5 = matrix * matrix2;
                matrix5.DisplayMatrix();

                Console.WriteLine("Matrix 1 * 2: ");
                Matrix matrix6 = matrix * 2;
                matrix6.DisplayMatrix();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
