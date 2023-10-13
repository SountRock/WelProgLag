/////////////////////////////////////////////////////////////
void ShowRecurNum(int num){
    if(num > 0){
        Console.Write($"{num}\t");
        ShowRecurNum(num - 1);
    }
}

//////////////////////////////////////
int SumNumbers(int start, int end) { 
    if(start < end){
        return SumNumbers(start + 1, end) + start;
    }
    return start;
}

//Этот метод сделан для удобства пользователя. 
int SumNumbersInRange(int start, int end) {
    if (start < end) {
        return SumNumbers(start, end); 
    } else {
        return SumNumbers(end, start); 
    }
}
//////////////////////////////////////

int Ackerman(int i, int j) {
    if(i == 0){
        return j + 1;
    } else 
    if (i > 0 && j == 0) {
        return Ackerman(i - 1, 1);
    } else 
    if (i > 0 && j > 0) {
        return Ackerman(i - 1, Ackerman(i, j - 1));
    } else {
        return Ackerman(i, j);
    }        
}
/////////////////////////////////////////////////////////////

Console.WriteLine("Program 64");
Console.WriteLine("Enter a num:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Print numbers:");
ShowRecurNum(num); 

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Program 66");
Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter M:");
int m = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbersInRange(n, m);
Console.WriteLine("The sum of range:");
Console.WriteLine(sum);

Console.WriteLine();

Console.WriteLine("Program 68");
Console.WriteLine("Enter N:");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter M:");
m = Convert.ToInt32(Console.ReadLine());
int Ac = Ackerman(n, m);
Console.WriteLine("The Ackerman Value:");
Console.WriteLine(Ac);
//Только можете сказать, можно ли используя рекурсию решить проблемму с большими числами?
//Потому что при вводе к примеру 9,9 происходит переполнение стека.
