bool checkAnswer(string answer)
{
    if(answer.ToLower().Trim() == "y"){
            return true;
    } else {
        return false;
    }
}

bool repeat = true;
string answer;

int[] values = new int[2];

while (repeat) 
{
    Console.WriteLine();
    Console.WriteLine("Program 2");
    Console.WriteLine("Enter two values:");
    values[0] = Convert.ToInt32(Console.ReadLine());
    values[1] = Convert.ToInt32(Console.ReadLine());

    if (values[0] > values[1]) 
        Console.WriteLine($"max is {values[0]}");
    else if (values[1] > values[0]) 
        Console.WriteLine($"max is {values[1]}");
    else 
        Console.WriteLine($"{values[0]} = {values[1]}");

    Console.WriteLine("Repear?(Y/N)");
    answer = Console.ReadLine();

    if (answer.ToLower().Trim() == "y" || answer.ToLower().Trim() == "n")
    {
        repeat = checkAnswer(answer);
    } else {
        Console.WriteLine("Unknow command, please wtite again:");
        Console.WriteLine("Repear?(Y/N)");
        answer = Console.ReadLine();
        repeat = checkAnswer(answer);
    }
}

repeat = true;

values = new int[3];

while (repeat) 
{
    Console.WriteLine();
    Console.WriteLine("Program 4");

    Console.WriteLine("Enter tree values:");
    for(int i = 0; i < values.Length; i++)
        values[i] = Convert.ToInt32(Console.ReadLine());

    int max = values[0];
    for(int i = 0; i < values.Length; i++)
        if (values[i] > max)
            max = values[i];

    Console.WriteLine($"max is {max}");

    Console.WriteLine("Repear?(Y/N)");
    answer = Console.ReadLine();

    if (answer.ToLower().Trim() == "y" || answer.ToLower().Trim() == "n")
    {
        repeat = checkAnswer(answer);
    } else {
        Console.WriteLine("Unknow command, please wtite again:");
        Console.WriteLine("Repear?(Y/N)");
        answer = Console.ReadLine();
        repeat = checkAnswer(answer);
    }
}

repeat = true;

while (repeat) 
{
    Console.WriteLine();
    Console.WriteLine("Program 6");

    Console.WriteLine("Enter value:");
    int value = Convert.ToInt32(Console.ReadLine());

    if (value % 2 == 0)
        Console.WriteLine($"{value} is even");
    else 
        Console.WriteLine($"{value} is uneven");

    Console.WriteLine("Repear?(Y/N)");
    answer = Console.ReadLine();

    if (answer.ToLower().Trim() == "y" || answer.ToLower().Trim() == "n")
    {
        repeat = checkAnswer(answer);
    } else {
        Console.WriteLine("Unknow command, please wtite again:");
        Console.WriteLine("Repear?(Y/N)");
        answer = Console.ReadLine();
        repeat = checkAnswer(answer);
    }
}

repeat = true;

while (repeat) 
{
    Console.WriteLine();
    Console.WriteLine("Program 8");

    Console.WriteLine("Enter N:");
    int n = Convert.ToInt32(Console.ReadLine());

    for(int i = 2; i <= n; i += 2)
        Console.Write($" {i}");

    Console.WriteLine();

    Console.WriteLine("Repear?(Y/N)");
    answer = Console.ReadLine();

    if (answer.ToLower().Trim() == "y" || answer.ToLower().Trim() == "n")
    {
        repeat = checkAnswer(answer);
    } else {
        Console.WriteLine("Unknow command, please wtite again:");
        Console.WriteLine("Repear?(Y/N)");
        answer = Console.ReadLine();
        repeat = checkAnswer(answer);
    }
}   

Console.WriteLine("Goodbye");

