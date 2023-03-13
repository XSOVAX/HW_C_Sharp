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

int find_row_mininal_sum(int[,] array){
    int min = 0, min_k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        min += array[0,i];
    
    for (int i = 0; i < array.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            sum += array[i, j];
        }
        if(sum < min){
            min = sum;
            min_k = i;
        }
    }
    return min_k;
}


Console.Write("Введите размерность массива >> ");
int array_value = Convert.ToInt32(Console.ReadLine());
int[,] array_data = fill_random_array(array_value, array_value);
print_array(array_data);

Console.WriteLine();
Console.Write($"Строка с минимальной суммой элементов -> {find_row_mininal_sum(array_data)}");