int sum_number (int n){
    if (n == 0) return 0;
    return n % 10 + sum_number(n / 10);
}


Console.Write("Введите число >> ");
int value = Convert.ToInt32(Console.ReadLine());

Console.Write($"{value} -> {sum_number(value)}");