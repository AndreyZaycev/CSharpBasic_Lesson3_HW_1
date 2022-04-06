using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HomeWork_1
{
    internal class Program
    {
        //функция: заполнение матрицы случайными целами числами 
        public static int[,] GetMatrixData(int nRows, int nCols)
        {
            int[,] mtxOutData = new int[nRows, nCols]; //объявление матрицы
            Random rnd = new Random();                 //объект для генерации

            //заполнение масcива случайными целыми числами
            for (int i = 0; i < nRows; i++)
                for (int j = 0; j < nCols; j++)
                    mtxOutData[i, j] = rnd.Next(10, 99); //генерация  
                                                         //случайного целого числа от 10 до 99 
                                                         //и присвоение его элементу матрицы

            //вывод матрицы
            return mtxOutData;
        }

        //функция: вывод матрицы
        public static void PrintMatrix(int[,] mtxData)
        {
            //определение числа строк и столбцов матрицы
            int nRows = mtxData.GetLength(0);
            int nCols = mtxData.GetLength(1);

            //вывод
            Console.WriteLine("Матрица данных");
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nCols; j++) Console.Write($"{mtxData[i, j]} ");
                Console.WriteLine();
            }
        }

        //функция: вывод элементов главной и побочной диагонали
        public static string GetElementsDiag(int[,] mtxData)
        {
            int nRows = mtxData.GetLength(0);
            int nCols = mtxData.GetLength(1);

            //определение минимальной длины, по которой будет прослеживаться вывод
            int minSize = (nRows <= nCols) ? nRows : nCols;

            //определение элементов главной и побочной диаганали
            string sElemMainDiag = ""; //строка для записи элементов главной диаганали
            string sElemPobDiag = "";  //строка для записи элементов побочной диаганали
            for (int i = 0; i < minSize; i++)
            {
                sElemMainDiag += mtxData[i, i].ToString() + " ";
                sElemPobDiag += mtxData[i, minSize - 1 - i].ToString() + " ";
            }

            //
            return "Элементы главной диагонали: " + sElemMainDiag + "\n" +
                   "Элементы побочной диагонали: " + sElemPobDiag;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Урок 3, домашнее задание № 1");

            //ввод числа строк матрицы
            Console.Write("Введите число строк матрицы : ");
            int nRows = Convert.ToInt32(Console.ReadLine());

            //ввод числа столбцов матрицы
            Console.Write("Введите число столбцов матрицы : ");
            int nCols = Convert.ToInt32(Console.ReadLine());

            //получение матрицы данных 
            int[,] mtxData = GetMatrixData(nRows, nCols);

            //вывод матрицы данных
            PrintMatrix(mtxData);

            //вывод результата
            Console.WriteLine(GetElementsDiag(mtxData));

            //
            Console.ReadLine();
        }
    }
}
