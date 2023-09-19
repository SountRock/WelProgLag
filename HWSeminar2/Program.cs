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
/////////////////////////////////////////////


/////////////////////////////////////////////
void SecondDigital(int num = 0){
    if(num / 1000 == 0 && num / 100 != 0){
        int dig = num % 100 / 10;
        Console.WriteLine($"Answer is {dig}");
    } else {
        Console.WriteLine("Error: out of range!");
    }
}

bool repeat = true;
while (repeat){
    Console.WriteLine();
    Console.WriteLine("Program 10");
    int num = Convert.ToInt32(Console.ReadLine());
    SecondDigital(num);
    repeat = RepeatSys();
}
/////////////////////////////////////////////


/////////////////////////////////////////////
int ThirdDigital(string numStr = ""){
    if (numStr.Length > 2) {
        if (numStr[0] != '-') {
            return numStr[2] - 48;
            //походу индекс цифр здесь идет с 48. 
        } else {
            return numStr[3] - 48;
        }
    } else {
        return -1;
    } 
}

repeat = true;
while (repeat){
    Console.WriteLine();
    Console.WriteLine("Program 13");
    string number = Console.ReadLine(); 
    int thirdDig = ThirdDigital(number);
    if (thirdDig != -1) {
        Console.WriteLine($"Answer is {thirdDig}");
    } else {
       Console.WriteLine("third digital is not exist!"); 
    }
    repeat = RepeatSys();
} 
/////////////////////////////////////////////


/////////////////////////////////////////////
bool DayISWeekend(int day = 0){ 
    if (day == 6 || day == 7){
        return true;
    } else {
        return false;
    }
}

repeat = true;
while (repeat){
    Console.WriteLine();
    Console.WriteLine("Program 15");
    int day = Convert.ToInt32(Console.ReadLine());
    if (day > 0 && day < 8){
        if (DayISWeekend(day)){
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }
    } else {
        Console.WriteLine("Error: out of range!");
    }
    repeat = RepeatSys();
}
/////////////////////////////////////////////


