int[,] fill_random_array(int n, int m){
    int[,] new_array = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            new_array[i, j] = rnd.Next(-100, 100);
        }
    }
    return new_array;
}

void print_array(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

double[] average_array(int[,] array){
    double[] average_value = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            average_value[j] += array[i, j];
        }
    }
    for(int j = 0; j < array.GetLength(1); j++){
            average_value[j] = average_value[j] / array.GetLength(0);
    }
    return average_value;
}
void print(double[] array){
    for(int i = 0; i < array.Length; i++){
        if(i > 0) Console.Write("; ");
        Console.Write(array[i]);
    }
    Console.Write(".");
}

Console.WriteLine("Введите размерность массива");
Console.Write("Сколько строчек вы хотите >> ");
int value_M = Convert.ToInt32(Console.ReadLine());
Console.Write("Сколько столбцов вы хотите >> ");
int value_N = Convert.ToInt32(Console.ReadLine());
int[,] array_data = fill_random_array(value_M, value_N);
print_array(array_data);

Console.Write("Среднее арифметическое каждого столбца: ");
double[] average_column = average_array(array_data);
print(average_column);