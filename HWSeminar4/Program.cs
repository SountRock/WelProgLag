/////////////////////////////////////////////
double PoW(int num = 0, int n = 0){
    double res = 1;
    bool minus = n < 0;

    if (minus){
        n = n * (-1) ;
    } 

    for (int i = 1; i <= n; i++){
        res = res * num;
    }

    if (minus) {
        return res = 1 / res;
    } else {
        return res;
    }
}

Console.WriteLine();
Console.WriteLine("Program 25");

Console.WriteLine("Enter a number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the power of number:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num} to the power of {n} :");
double result = PoW(num, n);
if (result < 0) {
    Console.WriteLine($"{result} or 1/{1 / result}");
} else {
    Console.WriteLine(result);
}

/////////////////////////////////////////////

/////////////////////////////////////////////
void sumDigits1(string numStr = ""){
    int num = Convert.ToInt32(numStr);
    int sum = 0;

    if (numStr.Length > 1){
        int[] arrOfDigit = new int[numStr.Length];
        
        for (int i = 1; i < arrOfDigit.Length; i++){
            arrOfDigit[i] = Convert.ToInt32((((num % PoW(10, i)) - arrOfDigit[i - 1] * PoW(10, i - 2)) / PoW(10, i - 1)));
            sum += arrOfDigit[i];
    }

    arrOfDigit[0] = Convert.ToInt32((num - arrOfDigit[arrOfDigit.Length - 2] * PoW(10, arrOfDigit.Length - 3)) / PoW(10, arrOfDigit.Length - 1));
    sum += arrOfDigit[0];

    Console.WriteLine($"Sum of digits is {sum}");
    } else {
        Console.WriteLine($"Sum of digits is {num}");
    }
    
    
}

void sumDigits2(string numStr = ""){
    int sum = 0;
    
    for (int i = 0; i < numStr.Length; i++){
        sum += (Convert.ToInt32(numStr[i]) - 48);
    }

    Console.WriteLine($"Sum of digits is {sum}");
}

Console.WriteLine();
Console.WriteLine("Program 27");

Console.WriteLine("Enter a number:");
string numer = Console.ReadLine().Trim();

sumDigits1(numer);
sumDigits2(numer);
/////////////////////////////////////////////

/////////////////////////////////////////////
void FillAndPrint(){
    Console.WriteLine("Enter the array length:");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length > 0) {
        int[] arr = new int[length];

        for (int i = 0; i < length; i++){
            Console.WriteLine($"Enter {i} element:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("The array contains:");

        Console.Write("[");

        for (int j = 0; j < length; j++){
            Console.Write($"{arr[j]}");

            if (j < length - 1) {
                Console.Write(", ");
            } 
        }

        Console.Write("]");

    } else {
        Console.WriteLine("the length of the array must not be zero or negative");
    }
}

Console.WriteLine();
Console.WriteLine("Program 29");
FillAndPrint();
/////////////////////////////////////////////
