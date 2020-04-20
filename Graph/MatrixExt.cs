using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    static class MatrixExt
    {
        public static int RowsCount(this int[,] matrix)
        {
            return matrix.GetUpperBound(0) + 1;
        }
        public static int ColumnsCount(this int[,] matrix)
        {
            return matrix.GetUpperBound(1) + 1;
        }
        public static int[,] BoolMatrixMultiplication(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.RowsCount())
                throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");

            var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

            for (var i = 0; i < matrixA.RowsCount(); i++)
            {
                for (var j = 0; j < matrixB.ColumnsCount(); j++)
                {
                    int mnoj = 0;
                    for (var k = 0; k < matrixA.ColumnsCount(); k++)
                    {
                        mnoj += matrixA[i, k] * matrixB[k, j];
                        if (mnoj > 0) matrixC[i, j] = 1;
                        else matrixC[i, j] = 0;
                    }
                }
            }

            return matrixC;
        }

        public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.RowsCount())
                throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");

            var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];

            for (var i = 0; i < matrixA.RowsCount(); i++)
            {
                for (var j = 0; j < matrixB.ColumnsCount(); j++)
                {
                    int mnoj = 0;
                    for (var k = 0; k < matrixA.ColumnsCount(); k++)
                    {
                        mnoj += matrixA[i, k] * matrixB[k, j];
                    }
                    matrixC[i, j] = mnoj;
                }
            }

            return matrixC;
        }

        public static int[,] BoolPowMatrix(int[,] matrixA, int n)
        {
            var matrixC = new int[matrixA.RowsCount(), matrixA.ColumnsCount()];
            for (int i = 0; i < n - 1; i++)
                matrixC = BoolMatrixMultiplication(matrixC, matrixA);
            return matrixC;
        }

        public static int[,] PowMatrix(int[,] matrixA, int n)
        {
            var matrixC = matrixA;
            for (int i = 0; i < n - 1; i++)
                matrixC = MatrixMultiplication(matrixC, matrixA);
            return matrixC;
        }
        public static int[,] BoolPlusMatrix(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.ColumnsCount() || matrixA.RowsCount() != matrixB.RowsCount())
                throw new Exception("Сложение не возможно! Количество столбцов/строк первой матрицы не равно количеству столбцов/строк второй матрицы.");
            var matrixC = new int[matrixA.RowsCount(), matrixA.ColumnsCount()];
            for (int i = 0; i < matrixA.RowsCount(); i++)
                for (int j = 0; j < matrixA.ColumnsCount(); j++)
                    if (matrixA[i, j] + matrixB[i, j] > 0) matrixC[i, j] = 1;
                    else matrixC[i, j] = 0;
            return matrixC;
        }
        public static int[,] GenerateE(int N)
        {
            var matrix = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (i == j) matrix[i, j] = 1;
                    else matrix[i, j] = 0;
            return matrix;
        }
        public static int[,] ConjuctionMatrix(int[,] matrixA, int[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.ColumnsCount() || matrixA.RowsCount() != matrixB.RowsCount())
                throw new Exception("Конъюкция не возможна! Количество столбцов/строк первой матрицы не равно количеству столбцов/строк второй матрицы.");
            var matrixC = new int[matrixA.RowsCount(), matrixA.ColumnsCount()];
            for (int i = 0; i < matrixA.RowsCount(); i++)
                for (int j = 0; j < matrixB.ColumnsCount(); j++)
                    if (matrixA[i, j] == 1 && matrixB[i, j] == 1) matrixC[i, j] = 1;
                    else matrixC[i, j] = 0;
            return matrixC;
        }
        public static int[,] TransposedMatrix(int[,] matrixA)
        {
            var matrixC = new int[matrixA.RowsCount(), matrixA.ColumnsCount()];
            for (int i = 0; i < matrixA.RowsCount(); i++)
                for (int j = 0; j < matrixA.ColumnsCount(); j++)
                    matrixC[j, i] = matrixA[i, j];
            return matrixC;
        }

        public static int[,] MarkedMatrix(int[,] matrix)
        {
            int[,] markedMatrix = new int[matrix.GetLength(0), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] != 0) markedMatrix[i, j] = int.Parse((i + 1).ToString() + (j + 1).ToString());
                    else markedMatrix[i, j] = 0;
                }
            }
            return markedMatrix;
        }

        public static int[,] AuxiliaryMatrix(int[,] markedMatrix)
        {
            int[,] auxiliaryMatrix = new int[markedMatrix.GetLength(0), markedMatrix.GetLength(0)];
            for (int i = 0; i < markedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < markedMatrix.GetLength(0); j++)
                {
                    if (markedMatrix[i, j] != 0) auxiliaryMatrix[i, j] = int.Parse(markedMatrix[i, j].ToString().Remove(0, 1));
                    else auxiliaryMatrix[i, j] = 0;
                }
            }
            return auxiliaryMatrix;
        }

        // конкатенация матрицы
        // 2 входные матрицы, одна выходная
        public static List<string>[,] ConcatenationMatrix(List<string>[,] matrixA, int[,] matrixB) 
        {
            List<string>[,] concatMatrix = new List<string>[matrixA.GetLength(0), matrixB.GetLength(0)]; // создаём новую матрицу
            for (var i = 0; i < matrixA.GetLength(0); i++) 
            {
                for (var j = 0; j < matrixB.GetLength(1); j++) 
                {
                    List<string> tmp = new List<string>(); // создаём временную переменную, для заполнения
                    for (int k = 0; k < matrixA.GetLength(1); k++) 
                        if (matrixA[i, k][0] != "0") // проверяем, не является ли число нулём
                            for (int y = 0; y < matrixA[i, k].Count; y++) // пробегаемся по всем путям , которые находятся в памяти для вершин i,k
                                if (matrixB[k, j] != 0)  // проверям на 0
                                {
                                    tmp.Add((matrixA[i, k][y].ToString() + matrixB[k, j].ToString())); // добавляем к пути новую вершину
                                }
                    if (tmp.Count == 0) // если tmp осталось пустым, тогда добавляем к нему 0 , для заполнености 
                        tmp.Add("0");
                    concatMatrix[i, j] = tmp; // для одной ячейки путь заполнен
                }
            }
            return concatMatrix; // возвращаем итоговую матрицу
        }

        public static List<string>[,] IntToListString(int[,] matrix)
        {
            List<string>[,] newMatrix = new List<string>[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = new List<string> { matrix[i, j].ToString() };
                }
            }
            return newMatrix;
        }
    }
}
