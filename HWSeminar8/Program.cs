//////////////////////////////////////////////////////////////////////
double[,,] CreateRandomMatrixDouble(int n, int m, int h){
//int[,,] CreateRandomMatrixDouble(int n, int m, int h){
        double[,,] matrix = new double[n,m,h];
        double[] registrUniq = new double[n*m*h];
        //int[,,] matrix = new int[n,m,h];
        //int[] registrUniq = new int[n*m*h];
        int countUniq = 1;
        for (int i = 0; i < matrix.GetLength(0); i++){
            for (int j = 0; j < matrix.GetLength(1); j++){
                for (int k = 0; k < matrix.GetLength(2); k++){
                    bool neW = true;
                    double temp = new Random().NextDouble() * (99 - 10) + 10 + 0.0001;
                    //int temp = new Random().Next(1,10);
                    for(int g = 0; g < countUniq; g++){
                        if(temp != registrUniq[g]){
                            neW = neW && true;
                        } else {
                            neW = false;
                        }
                    }
                    if(neW){
                        matrix[i, j, k] = temp;
                        registrUniq[countUniq - 1] = temp;
                        countUniq++;  
                    } else {
                        k--;
                    }
            }
        } 
    }

     return matrix;
}

void Print3DArray(double[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){;
                Console.Write($"{array[i, j, k].ToString("0.00")}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

int[,] Udzumaki(int[,] matrix, int PosX, int PosY, int PastVal, int side){
    if(matrix[PosX, PosY] == 0){
        matrix[PosX, PosY] = PastVal + 1;
        if(PosY + 1 < matrix.GetLength(1) && matrix[PosX, PosY + 1] == 0 && side == 1){
            Udzumaki(matrix, PosX, PosY + 1, matrix[PosX, PosY], 1);
        } else {
            side = 2;
        }

        if(PosX + 1 < matrix.GetLength(0) && matrix[PosX + 1, PosY] == 0 && side == 2){
            Udzumaki(matrix, PosX + 1, PosY, matrix[PosX, PosY], 2);
        } else {
            side = 3;
        } 

        if(PosY - 1 >= 0 && matrix[PosX, PosY - 1] == 0 && side == 3){
            Udzumaki(matrix, PosX, PosY - 1, matrix[PosX, PosY], 3);
        } else {
            side = 4;
        } 

        if(PosX - 1 >= 0 && matrix[PosX - 1, PosY] == 0 && side == 4){
            Udzumaki(matrix, PosX - 1, PosY, matrix[PosX, PosY], 4);
        } else {
            side = 1;
        } 

        if(PosY + 1 < matrix.GetLength(1)){
            Udzumaki(matrix, PosX, PosY + 1, matrix[PosX, PosY], 1);
        }
    }

    return matrix;
}

void Print2DArray(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]}\t");
        }
    Console.WriteLine();
    }
}

int[,] SortRowsDescending(int[,] matrix){
      bool flag = true;
      while(flag){
        flag = false;
        for (int i = 0; i < matrix.GetLength(0); i++){
          for (int j = 1; j < matrix.GetLength(1); j++){
            if(matrix[i,j - 1] < matrix[i,j]){
              int temp = matrix[i,j - 1];
              matrix[i,j - 1] = matrix[i,j];
              matrix[i,j] = temp;
              flag = true;
            }
          }
      }
    }
    return matrix;
}

int[,] FillArrayInt(int start, int end, int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

int[] MinimumSumRow(int[,] matrix)
    {
      int[] sum = new int[matrix.GetLength(0)];
      for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
          sum[i] += matrix[i, j];
        }
      }
      
      int[] min = new int[2];
      min[0] = 0;
      min[1] = sum[0];
      for (int i = 0; i < sum.Length; i++){
        if (sum[i] < sum[min[0]]){
          min[0] = i;
          min[1] = sum[i];
        }
      }
      return min;
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB){
    int[,] MMult = new int[matrixB.GetLength(0), matrixB.GetLength(1)];
     if(matrixA.GetLength(1) != matrixB.GetLength(0)){
          Console.WriteLine("It is impossible to multiply.");
        } else {
            for (int i = 0; i < matrixA.GetLength(0); i++){
                for (int j = 0; j < matrixB.GetLength(1); j++){
                    for (int k = 0; k < matrixA.GetLength(1); k++)
                        MMult[i,j] += matrixA[i,k] * matrixB[k,j];
                    }
                }
            } 
        
      return MMult;
}
//////////////////////////////////////////////////////////////////////

Console.WriteLine("Program 60");
Console.WriteLine("Enter the size of subarray1:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the size of subarray2:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the size of subarray3:");
int h = Convert.ToInt32(Console.ReadLine());
double[,,] arr = CreateRandomMatrixDouble(n, m, h);
//int[,,] arr = CreateRandomMatrixDouble(2, 2, 2);
Console.WriteLine("Full Array:");
Print3DArray(arr);

Console.WriteLine();
Console.WriteLine("Program 62");
int[,] arr1 = new int[5, 5];
arr1 = Udzumaki(arr1, 0, 0, 0, 1);
Console.WriteLine("The Spiral Array:");
Print2DArray(arr1);

Console.WriteLine();
Console.WriteLine("Program 54");
int[,] arr2 = new int[5, 5];
arr2 = FillArrayInt(1, 100, arr2);
Console.WriteLine("The new array:");
Print2DArray(arr2);
arr2 = SortRowsDescending(arr2);
Console.WriteLine("The sort array:");
Print2DArray(arr2);

Console.WriteLine();
Console.WriteLine("Program 56");
int[,] arr3 = new int[5, 5];
arr3 = FillArrayInt(1, 10, arr3);
Console.WriteLine("The new array:");
Print2DArray(arr3);
int[] minSum = MinimumSumRow(arr3);
Console.WriteLine($"The sum of minimum string (row {minSum[0] + 1}): {minSum[1]}");

Console.WriteLine();
Console.WriteLine("Program 58");
int[,] matrix1 = new int[5, 5];
matrix1 = FillArrayInt(1, 10, matrix1);
Console.WriteLine("The matrix1:");
Print2DArray(matrix1);
int[,] matrix2 = new int[5, 2];
matrix2 = FillArrayInt(9, 25, matrix2);
Console.WriteLine("The matrix2:");
Print2DArray(matrix2);
int[,] newMatrix = MatrixMultiplication(matrix1, matrix2);
Console.WriteLine("Сomposition equals:");
Print2DArray(newMatrix);
Console.WriteLine();
int[,] matrix3 = new int[3, 2];
matrix3 = FillArrayInt(9, 25, matrix3);
Console.WriteLine("The matrix3:");
Print2DArray(matrix3);
int[,] matrix4 = new int[5, 4];
matrix2 = FillArrayInt(9, 25, matrix4);
Console.WriteLine("The matrix4:");
Print2DArray(matrix4);
int[,] newMatrix2 = MatrixMultiplication(matrix3, matrix4);
Console.WriteLine("Сomposition equals:");
Print2DArray(newMatrix2);




