int[,] fill_random_array(int n, int m){
    int[,] new_array = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            new_array[i, j] = rnd.Next(0, 5);
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

int[,] multiplication_array(int[,] array_A, int[,] array_B){
    int[,] array_C = new int[array_A.GetLength(0), array_B.GetLength(1)];
    for (int i = 0; i < array_C.GetLength(0); i++){
        for (int j = 0; j < array_C.GetLength(1); j++){
            array_C[i, j] = 0;
            for (int k = 0; k < array_A.GetLength(1); k++){
                array_C[i, j] += array_A[i, k] * array_B[k, j];
            }
        }
    }
    return array_C;
}


Console.WriteLine("Введите размерность массивов");
Console.Write("Количество строк в массиве А (количество колон в массиве В) -> ");
int value_c_r = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество колон в массиве А (количество строк в массиве В) -> ");
int value_r_c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Массив А");
int[,] array_data_A = fill_random_array(value_c_r, value_r_c);
print_array(array_data_A);
Console.WriteLine("Массив B");
int[,] array_data_B = fill_random_array(value_r_c, value_c_r);
print_array(array_data_B);


Console.WriteLine();
Console.WriteLine("Массив C = A * B");
int[,]array_data_C = multiplication_array(array_data_A, array_data_B);
print_array(array_data_C);
