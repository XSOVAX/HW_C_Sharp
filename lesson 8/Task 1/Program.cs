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

int[,] sorted_array(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1) - 1; j++){
            for (int k = j; k < array.GetLength(1); k++){
                if(array[i, j] < array[i, k]){
                    int value = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = value;  
                }
            }
        }
    }
    return array;
}


Console.WriteLine("Введите размерность массива");
Console.Write("Сколько строчек вы хотите >> ");
int value_M = Convert.ToInt32(Console.ReadLine());
Console.Write("Сколько столбцов вы хотите >> ");
int value_N = Convert.ToInt32(Console.ReadLine());
int[,] array_data = fill_random_array(value_M, value_N);
print_array(array_data);

Console.WriteLine();
array_data = sorted_array(array_data);
print_array(array_data);