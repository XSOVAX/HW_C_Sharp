int [] new_array(int size){
    int [] my_array = new int[size];
    return fill_array(my_array);
}

int [] fill_array(int [] array){
    int size_array = array.Length;
    for (int i = 0; i < size_array; i++){
        Console.Write($"Введите {i + 1} / {size_array} массива >> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int [] print_array(int [] array){
    int size_array = array.Length;
    Console.Write($"Ваш массив -> [{array[0]}");
    for (int i = 1; i < size_array; i++){
        Console.Write($", {array[i]}");
    }
    Console.Write("]");
    return array;
}


print_array(new_array(8));