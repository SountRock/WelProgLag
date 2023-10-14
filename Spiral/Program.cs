int[,] Udzumaki(int[,] matrix){
    int posX = 0; //индексы строк массива
    int posY = 1; //индексы стобцов массива
    //переменные, что определяют движение по массиву
    int partX = 0; //рулевая переменная для строк
    int partY = 1; //рулевая переменная для столбцов

    matrix[0,0] = 1;
    int cycle = 1;
    
    while(matrix[posX, posY] == 0){ 
        matrix[posX, posY] = matrix[posX + (-1)*partX, posY + (-1)*partY] + 1;

        //если мы выходим за границы, то сорершаем поворот на 90 градусов. 
        if(posY + partY >= matrix.GetLength(1) - Convert.ToInt32(cycle/5) 
        || posX + partX >= matrix.GetLength(0) - Convert.ToInt32(cycle/4)
        || posY + partY < 0 + Convert.ToInt32(cycle/5)
        || posX + partX < 0 + Convert.ToInt32(cycle/4)
        ){  
            cycle++;
            int temp = Convert.ToInt32(Math.Pow((-1), cycle))*partX;
            partX = Convert.ToInt32(Math.Pow((-1), cycle))*partY;
            partY = temp;
        }

        posY = posY + partY;
        posX = posX + partX;
        
    }

    return matrix;
}

Console.WriteLine();
Console.WriteLine("Program 62");
int[,] arr1 = new int[5, 7];
arr1 = Udzumaki(arr1);

for (int i = 0; i < arr1.GetLength(0); i++){
    for (int j = 0; j < arr1.GetLength(1); j++){
       Console.Write($"{arr1[i, j]}\t"); 
    }
    Console.WriteLine();
}

