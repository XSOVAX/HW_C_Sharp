
int max_value = 0;

Console.WriteLine("Для сравнения введите три числа");

for (int i = 1; i <= 3; i++){
    Console.Write($"Введите {i} число >> ");
    int value = Convert.ToInt32(Console.ReadLine());
    if (i == 1) {
        max_value = value;
    }
    if (value > max_value){
        max_value = value;
    }
}
System.Console.WriteLine($"max = {max_value}");
