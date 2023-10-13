void Print2DArrayInt(int [,] matrix)
    {
      Console.Write("\t");
      int tabSize = Console.CursorLeft;

      for (int m = 0; m < matrix.GetLength(1); m++){
          Console.Write($"{m}\t");
      }
      Console.WriteLine();
      Console.Write(new string('_', tabSize * (matrix.GetLength(1) + 1)));
      Console.WriteLine();

      for (int i = 0; i < matrix.GetLength(0); i++){
            Console.Write($"{i}:\t");
         for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]}\t");
         }
        Console.WriteLine();
      }
    }

     int[,] CreateIncreasingMatrixInt(int n, int m, int k)
    {
      int[,] matrix = new int[n,m];
      matrix[0, 0] = 1;
      for (int i = 0; i < matrix.GetLength(0); i++){
         for (int j = 1; j < matrix.GetLength(1); j++){
           matrix[i, j] = matrix[i, j - 1] + k; 
         }
        if (i + 1 < matrix.GetLength(0))
          matrix[i + 1, 0] = matrix[i, matrix.GetLength(1) - 1] + k;
      }
      return matrix;
    }

    //Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
    //В случае, если это невозможно, программа должна вывести сообщение для пользователя.


    int[,] crossRowsAndCols(int [,] matrix){
        int countRow = matrix.GetLength(0);
        int countCol = matrix.GetLength(1);

        if(countRow != countCol){
            int [,] buff = new int[countCol, countRow];

            for(int i = 0; i < countCol; i++){
                for(int j = 0; j < countRow; j++){
                    buff[i,j] = matrix[j, i];
                }
            }
            return buff;
        } else {

            for(int i = 0; i < countRow; i++){
                for(int j = i + 1; j < countCol; j++){
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
            return matrix;
        }
    }

    int[,] crossRowsAndCols1(int [,] matrix){
        int countRow = matrix.GetLength(0);
        int countCol = matrix.GetLength(1);

        for(int i = 0; i + 1 < countRow; i++){
            int temp = matrix[i, i + 1];
            matrix[i, i + 1] = matrix[i + 1, i];
            matrix[i + 1, i] = temp;
        }

        return matrix;
    }

    using System.Globalization;

  void PrintMatrix (int [,] matrix)
  {
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
          Console.Write($"{matrix[i, j]}\t");
      }
      Console.WriteLine();
    }
  }

int[,] CreateMatrix(int n, int m)
  {
    int[,] matrix = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {

        matrix[i, j] = random.Next(0, 5);

      }
    }

    return matrix;
  }

  void CountNumbers(int[,] matrix)
  {
    int[] uniqValues = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int[] friquancy = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int uc = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
        bool flag = false;
        for(int k = 0; k < uc; k++)
        {
          if(matrix[i, j] == uniqValues[k])
          {
            flag = true;
            friquancy[k]++;
          }
        }
        if(!flag) 
        {
          uniqValues[uc] = matrix[i,j];
          friquancy[uc] = 1;
          uc++;
        }
      }
    }
    for(int i = 0; i < uc; i++)
    {
      Console.WriteLine($"{uniqValues[i]} встречается {friquancy[i]} раз");
    }

  }
  
  int[,] matrix = CreateMatrix(3, 3);
  PrintMatrix(matrix);
  
  CountNumbers(matrix);

    int[,] arr1 = CreateIncreasingMatrixInt(6, 6, 3);
    Print2DArrayInt(arr1);
    Console.WriteLine();
    int[,] arr2 = crossRowsAndCols(arr1);
    Print2DArrayInt(arr2);
