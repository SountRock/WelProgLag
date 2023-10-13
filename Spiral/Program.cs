//!!!Исправить
//!!!использовать переменную степени для правильного задания рулевых переменных
int[,] Udzumaki(int[,] matrix){
    int posX = 0;
    int posY = 1;
    int partX = 0;
    int partY = -1;

    matrix[0,0] = 1;
    bool turn = true;
    int cycle = 0;
    while(matrix[posX, posY] == 0){ 
        
        matrix[posX, posY] = matrix[posX + partX, posY + partY] + 1;

        if(posY + (-1)*partY >= matrix.GetLength(0) || posX + (-1)*partX >= matrix.GetLength(1) 
        ){
            Console.WriteLine($"partX {partX}");
            Console.WriteLine($"partX {partY}");
            cycle++; 
            int temp = partX;
            partX = partY;
            partY = temp;
            Console.WriteLine($"Rev partX {partX}");
            Console.WriteLine($"Rev partX {partY}");
            //posY = (posY - 1) + (-1)*partY;
            //posX = (posX - 1) + (-1)*partX;
   
            
        } 

        posY = posY + (-1)*partY;
        posX = posX + (-1)*partX; 

        //posY--;
        //posX--;
        Console.WriteLine($"posY {posY}");
        Console.WriteLine($"posX {posX}");
    }

    return matrix;
}

Console.WriteLine();
Console.WriteLine("Program 62");
int[,] arr1 = new int[5, 5];
arr1 = Udzumaki(arr1);

for (int i = 0; i < arr1.GetLength(0); i++){
    for (int j = 0; j < arr1.GetLength(1); j++){
       Console.Write($"{arr1[i, j]}\t"); 
    }
    Console.WriteLine();
}

Console.WriteLine();
