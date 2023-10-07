//Basic Array Method////////////////////////////////////////////////////////
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

    void Print2DArrayDouble(double [,] matrix)
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
            Console.Write($"{matrix[i, j].ToString("0.00")}\t");
         }
        Console.WriteLine();
      }
    }
     
    //Я взял этот метод из автотестов, он мне понравился :)
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

    double[,] CreateRandomMatrixDouble(int n, int m, double minNumber, double maxNumber){
        double[,] matrix = new double[n,m];
        for (int i = 0; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++){
                matrix[i, j] = new Random().NextDouble() * (maxNumber - minNumber) + minNumber + 0.0001;
            }
        }
        return matrix;
    }
//Basic Array Method////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////
int findIndex(int i, int j, int[,] matrix){
    if(i < matrix.GetLength(0) && j < matrix.GetLength(1))
        return matrix[i, j];
    else 
        return -2147483648;
}

double[] findColumeMiddle(int[,] matrix){
    double[] columeMaxes = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++){
        for (int j = 0; j < matrix.GetLength(0); j++){
            columeMaxes[i] += matrix[j, i];
        }
        columeMaxes[i] = columeMaxes[i] / matrix.GetLength(0);
    }

    return columeMaxes;
}
////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Enter the array row:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the array col:");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the min value:");
double min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the max value:");
double max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandomMatrixDouble(row, col, min, max);

Console.WriteLine("The random array:");
Print2DArrayDouble(array);
Console.WriteLine();

Console.WriteLine("Enter part for array:");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The new array:");
int[,] newArray = CreateIncreasingMatrixInt(row, col, k);

Print2DArrayInt(newArray);

Console.WriteLine("Enter row index from search:");
int rowFind = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col index from search:");
int colFind = Convert.ToInt32(Console.ReadLine());
int findElement = findIndex(rowFind, colFind, newArray);

if(findElement != -2147483648){
    Console.WriteLine($"The Element value is {findElement}");
} else {
    Console.WriteLine("The Element is not exist");
}

double[] columeMaxes = findColumeMiddle(newArray);

Console.WriteLine();
Console.WriteLine("The columes middle values:");
for(int g = 0; g < columeMaxes.Length; g++){
  Console.Write($"{columeMaxes[g].ToString("0.00")}\t");
}