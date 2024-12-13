using System;

namespace c_sharp_pract_2.Entity
{
    internal class Matrix
    {
        private int[,] data;
        private int rows;
        private int columns;


        public Matrix()
        {
            rows = 0;
            columns = 0;
            data = new int[rows, columns];
        }


        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            data = new int[rows, columns];
        }


        public Matrix(int[,] initialData)
        {
            rows = initialData.GetLength(0);
            columns = initialData.GetLength(1);
            data = initialData;
        }


        public void SetElement(int row, int column, int value)
        {
            if (row >= 0 && row < rows && column >= 0 && column < columns)
            {
                data[row, column] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }


        public int GetElement(int row, int column)
        {
            if (row >= 0 && row < rows && column >= 0 && column < columns)
            {
                return data[row, column];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }


        public void DisplayMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(data[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            {
                throw new InvalidOperationException("Matrices must have the same dimensions");
            }
            Matrix result = new Matrix(matrix1.rows, matrix1.columns);
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result.data[i, j] = matrix1.data[i, j] + matrix2.data[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            {
                throw new InvalidOperationException("Matrices must have the same dimensions");
            }
            Matrix result = new Matrix(matrix1.rows, matrix1.columns);
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result.data[i, j] = matrix1.data[i, j] - matrix2.data[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.columns != matrix2.columns)
            {
                throw new InvalidOperationException("Matrices must have the same dimensions");
            }
            Matrix result = new Matrix(matrix1.rows, matrix1.columns);
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result.data[i, j] = matrix1.data[i, j] * matrix2.data[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix1, int number)
        {
            Matrix result = new Matrix(matrix1.rows, matrix1.columns);
            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.columns; j++)
                {
                    result.data[i, j] = matrix1.data[i, j] * number;
                }
            }
            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Matrix matrix = (Matrix)obj;
            if (rows != matrix.rows || columns != matrix.columns)
            {
                return false;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (data[i, j] != matrix.data[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            return matrix1.Equals(matrix2);
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return !matrix1.Equals(matrix2);
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result += data[i, j] + "\t";
                }
                result += "\n";
            }
            return result;
        }


        public int GetMax()
        {
            int max = data[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (data[i, j] > max)
                    {
                        max = data[i, j];
                    }
                }
            }
            return max;
        }


        public int GetMin()
        {
            int min = data[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (data[i, j] < min)
                    {
                        min = data[i, j];
                    }
                }
            }
            return min;
        }
    }
}
