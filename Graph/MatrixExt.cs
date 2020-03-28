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
        public static int[,] BoolPowMatrix(int[,] matrixA, int n)
        {
            var matrixC = new int[matrixA.RowsCount(), matrixA.ColumnsCount()];
            for (int i = 0; i < n - 1; i++)
                matrixC = BoolMatrixMultiplication(matrixC, matrixA);
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
    }
}
