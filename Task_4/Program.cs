

Console.WriteLine("Введите значение числа до которого нужно вывести четные числа");
Console.Write("Введите число >> ");
int value = Convert.ToInt32(Console.ReadLine());

if (value < 2){
    Console.Write("Таких четных натуральных чисел нет");
}
else{
    int comma = 0;
    for (int i = 2; i <= value; i += 2){
        if (comma == 1){
            Console.Write(", ");
        }
        else{
        comma = 1;
        }
        Console.Write(i);
    }
}