
int value_degree (int n, int k){
    if (k == 0) return 1;
    if (k == 1) return n;
    return n * value_degree(n, k - 1);
}

Console.Write("Введите число для возведения в степень >> ");
int value = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень >> ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.Write($"{value}, {degree} -> {value_degree(value, degree)}");