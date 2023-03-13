int sum_numbers(int a, int b){
    if(a > b) return 0;
    return a + sum_numbers(a + 1, b);
}

Console.Write("Введите значение M -> ");
int value_m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N -> ");
int value_n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма чисел в диапозоне от {value_m} до {value_n} -> {sum_numbers(value_m, value_n)}");
