double [,] fill_random_array(int n, int m){
    double[,] new_array = new double[n, m];
    Random rnd = new Random();
    int znak = 1;
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            if (rnd.Next(0, 10) % 2 == 0) znak *= -1;
            new_array[i, j] = rnd.NextDouble() * 1000 * znak;
        }
    }
    return new_array;
}

void print_array(double [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($" {Math.Round(array[i, j], 1)}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность массива");
Console.Write("Сколько строчек вы хотите >> ");
int value_M = Convert.ToInt32(Console.ReadLine());
Console.Write("Сколько столбцов вы хотите >> ");
int value_N = Convert.ToInt32(Console.ReadLine());
double[,] array_data = fill_random_array(value_M, value_N);
print_array(array_data);

Console.WriteLine("Введите позицию элемента в массиве");
Console.Write("В какой строчке находится искомый элемент >> ");
int find_m = Convert.ToInt32(Console.ReadLine());
Console.Write("В каком столбце находится искомый элемент >> ");
int find_n = Convert.ToInt32(Console.ReadLine());
Console.Write($"({find_m}, {find_n}) -> ");
if((find_m < value_M) && (find_n < value_N)){
    Console.Write($"{Math.Round(array_data[find_m, find_n], 1)}");
}
else{
    Console.Write("Такого числа в массиве нет");
}