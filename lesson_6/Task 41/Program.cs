int[] input_array (int value_M){
    Console.WriteLine("Введите элементы для проверки");
    int[] array = new int[value_M];
    for(int i = 0; i < value_M; i++){
        Console.Write($"Введите {i + 1} элемент : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int positive_value(int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) count++;
    return count;
}

string print(int[] array){
    string print_array = "";
    for(int i = 0; i < array.Length; i++){
        if (i > 0) print_array += "; ";
        print_array += Convert.ToString(array[i]);
    }
    return print_array;
}

Console.Write("Введите количество чисел для проверки >> ");
int value_M = Convert.ToInt32(Console.ReadLine());
int[] array_data = input_array(value_M);
Console.WriteLine($"В вашем массиве [{print(array_data)}]");
Console.Write($"Положительных чисел >> {positive_value(array_data)}");