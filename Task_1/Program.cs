
Console.WriteLine("Для сравнения введите два числа");
Console.Write("Введите число  A >> ");
int value_a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число  B >> ");
int value_b = Convert.ToInt32(Console.ReadLine());

int max_value = value_a;
if (value_b > max_value){
    max_value = value_b;
}

System.Console.WriteLine($"max = {max_value}");

System.Console.WriteLine($"Наибольшим числом из {value_a} и {value_b} является число {max_value}");