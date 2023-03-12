// See https://aka.ms/new-console-template for more information

double [] fill_random_array(double [] array){
    int size_array = array.Length;
    Random rnd = new Random();
    int znak = 1;
    for (int i = 0; i < size_array; i++){
        if (rnd.Next(0, 10) % 2 == 0) znak *= -1;
        array[i] = rnd.NextDouble() * 1000 * znak;
    }
    return array;
}
void print_array(double [] array){
    int size_array = array.Length;
    Console.Write($"[{Math.Round(array[0], 2)}");
    for (int i = 1; i < size_array; i++){
        Console.Write($"; {Math.Round(array[i], 2)}");
    }
    Console.Write("]");
}

Console.Write("Введите размер массива >> ");
int array_size = Convert.ToInt32(Console.ReadLine());
double [] my_array = new double[array_size];
my_array = fill_random_array(my_array);

double max = -10000, min = 10000;
for (int i = 0; i < my_array.Length; i++){
    if (my_array[i] > max) max = my_array[i];
    if (my_array[i] < min) min = my_array[i];
}

print_array(my_array);
Console.Write($" -> {Math.Round(max - min, 2)}");

