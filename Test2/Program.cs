void V(int n, int m){
    if(n < m + 1){
        Console.WriteLine(n);
        V(n + 1, m);
    } 
}

V(Math.Min(1,9), Math.Max(1,9));

int SumDig(int num){
    if(num>10){
        return SumDig(num / 10) + num % 10;
    } else {
        return num;
    }
}

Console.WriteLine();

Console.WriteLine(SumDig(562));
