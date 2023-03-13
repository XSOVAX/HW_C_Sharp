void even_numbers(int k, int a, int b){
    if(a <= b){
        if(k > 0) Console.Write("; ");
        Console.Write(a);
        even_numbers(k + 1, a + 2, b);
    }
}

Console.Write("Введите значение M -> ");
int value_m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N -> ");
int value_n = Convert.ToInt32(Console.ReadLine());
Console.Write($"В диапозоне от {value_m} до {value_n} -> ");
if(value_m % 2 == 0){
    if(value_m <= value_n) even_numbers(0, value_m, value_n);
    else Console.Write("нет четных чисел");
}
else{
    if(value_m + 1 <= value_n) even_numbers(0, value_m + 1, value_n);
    else Console.Write("нет четных чисел");
}