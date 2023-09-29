/////////////////////////////////////////////
//Эти методы просто для моего удобства, при проврке програм.
bool checkAnswer(string answer)
{
    if(answer.ToLower().Trim() == "y"){
        return true;
    } else {
        return false;
    }
}

bool RepeatSys() {
    Console.WriteLine("Repeat?(Y/N)");
    string answer = Console.ReadLine();

    if (answer.ToLower().Trim() == "y" || answer.ToLower().Trim() == "n")
    {
        return checkAnswer(answer);
    } else {
        Console.WriteLine("Unknow command, please wtite again:");
        Console.WriteLine("Repeat?(Y/N)");
        answer = Console.ReadLine();
        return checkAnswer(answer);
    }
}

//Basic Array Method////////////////////////////
int[] CreateIntArray(int size){
    if (size > 0) {
        int[] newArray = new int[size];
        return newArray;
    } else {
        Console.WriteLine("Array Size Error!");
        return null;
    }
}

double[] CreateDoubleArray(int size){
    if (size > 0) {
        double[] newArray = new double[size];
        return newArray;
    } else {
        Console.WriteLine("Array Size Error!");
        return null;
    }
}

int[] FillArrayInt(int start, int end, int[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

double[] FillArrayDouble(double start, double end, double[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        //А как лучше сделать, чтобы захватывало конечное значение тоже?
        //array[i] = Math.Round((new Random().NextDouble() + 0.001) * (end - start) + start, 3); //(1)
        array[i] = Math.Round((new Random().NextDouble()) * (end + 0.001 - start) + start, 3); //(2)
    }
    return array;
}

void PrintIntArray(int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

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
//Basic Array Method////////////////////////////

/////////////////////////////////////////////
void getEvenNumCount(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine($"The even number count is {count}");
}

void getEvenNumSum(int[] array){
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {  
        sum += array[i];
    }
    Console.WriteLine($"The even number sum is {sum}");
}

double[] ShakeSort(double[] array){
    int left = 0;
    int right = array.Length - 1;

    while(left <= right){
        for (int i = left; i < right; i++)
        {
            if (array[i] > array[i + 1]){
                double temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }
        }
        right--;
        for (int i = right; i > left; i--)
        {
            if (array[i - 1] > array[i]){
                double temp = array[i - 1];
                array[i - 1] = array[i];
                array[i] = temp;
            }
        }
        left++;
    }

    return array;
}

/////////////////////////////////////////////
Console.WriteLine("Enter the array size:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Array is Ineger(1) or Double(2)? Enter 1 or 2:");
int choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1) {
    Console.WriteLine("***It`s the answer to task 34 and 36:");
    Console.WriteLine("Enter the min value:");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the max value:");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] array = CreateIntArray(size);
    array = FillArrayInt(min, max, array);

    Console.WriteLine("The generated array:");
    PrintIntArray(array);
    getEvenNumCount(array);
    getEvenNumSum(array);

} else if (choice == 2){
    Console.WriteLine("***It`s the answer to task 38:");
    Console.WriteLine("Enter the min value:");
    double min = float.Parse(Console.ReadLine());
    Console.WriteLine("Enter the max value:");
    double max = float.Parse(Console.ReadLine());

    double[] array = CreateDoubleArray(size);
    array = FillArrayDouble(min, max, array);

    Console.WriteLine("The generated array:");
    PrintDoubleArray(array);

    double[] arraySort = ShakeSort(array);
    Console.WriteLine("The array after sort:");
    PrintDoubleArray(arraySort);

    double diff = arraySort[arraySort.Length - 1] - arraySort[0];
    Console.WriteLine($"The difference is {diff}");
}
    
/////////////////////////////////////////////
