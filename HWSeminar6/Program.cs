void PrintDoubleArray(double[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

double[] EnterArray(int size){
    double[] input = new double[size + 1];
    Console.WriteLine("Enter values:");
    for(int i = 1; i <= size; i++){
        input[i] = float.Parse(Console.ReadLine());
    }
    return input;
}
//////////////////////////////////////////////

double CountOfBiggestZeroNumber(double[] input){
    for (int i = 1; i < input.Length; i++)
    {
        input[0] += Convert.ToInt32(input[i] > 0);
    }
    return input[0];
}
//На основе того, что выше:
double CountOfBiggestZeroNumber2(double[] input2){
   for (int j = 1; j < input2.Length; input2[0] += Convert.ToInt32(input2[j] > 0), j++) {}
   return input2[0];
}

Console.WriteLine("Program 41");
Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());
double[] input = EnterArray(n);
Console.WriteLine($"The count of values that biggest zero - {CountOfBiggestZeroNumber(input)}");
input[0] = 0;
Console.WriteLine($"The count of values that biggest zero - {CountOfBiggestZeroNumber2(input)}");
/////////////////////////////////////////////////

Console.WriteLine();

/////////////////////////////////////////////////
double[] СhartsCrossing(double k1, double b1, double k2, double b2){
    double[] cross = new double[2];
    cross[0] = (b2 - b1)/(k1-k2);
    cross[1] = k1 * cross[0] + b1;
    return cross;
}

string СhartsCrossing2(double k1, double b1, double k2, double b2){
    string crossStr = "(" + ((b2 - b1)/(k1 - k2)).ToString() + ", " + ((b1 * k2 - b2 * k1)/(k2 - k1)).ToString() + ")";
    return crossStr;
}

Console.WriteLine("Program 43");
Console.WriteLine("Enter k1:");
double k1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter b1:");
double b1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter k2:");
double k2 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter b2:");
double b2 = float.Parse(Console.ReadLine());
Console.WriteLine("The crossing in position: ");

double[] position = СhartsCrossing(k1, b1, k2, b2);
PrintDoubleArray(position);
Console.WriteLine(СhartsCrossing2(k1, b1, k2, b2));
/////////////////////////////////////////////////

Console.WriteLine();

//My answer of last tast form seminar////////////
double[] findMax(double[] array){
    int maxIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] > array[maxIndex]){
            maxIndex = i;
      }
    }
    Console.WriteLine($"max is {array[maxIndex]}");
    array[maxIndex] = -2147483648;
    return array;
}

double findMax2(double[] array, double ignoreValue){
    double max = -2147483648;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] > max && array[i] != ignoreValue){
            max = array[i];
      }
    }

    return max;
}

Console.WriteLine("Last Seminar Program");
Console.WriteLine("Enter size:");
int size = Convert.ToInt32(Console.ReadLine());
double[] input2 = EnterArray(size);

double max1 = findMax2(input2, -2147483648);
Console.WriteLine($"max1 is {max1}");
double max2 = findMax2(input2, max1);
Console.WriteLine($"max2 is {max2}");

double[] inputCh = findMax(input2);
inputCh = findMax(inputCh);
/////////////////////////////////////////////////
