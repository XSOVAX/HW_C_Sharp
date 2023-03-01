
int [] fill_random_array(int [] array, int min_value, int max_value){
    int size_array = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < size_array; i++){
        array[i] = rnd.Next(min_value, max_value);
    }
    return array;
}

void print_array(int [] array){
    int size_array = array.Length;
    Console.Write($"[{array[0]}");
    for (int i = 1; i < size_array; i++){
        Console.Write($", {array[i]}");
    }
    Console.Write("]");
}

Console.Write("Введите размер массива >> ");
int array_size = Convert.ToInt32(Console.ReadLine());
int [] my_array = new int[array_size];
my_array = fill_random_array(my_array, 100, 1000);

int count = 0;
for (int i = 0; i < my_array.Length; i++){
    if (my_array[i] % 2 == 0) count++;
}

print_array(my_array);
Console.Write(" -> ");
Console.Write(count);