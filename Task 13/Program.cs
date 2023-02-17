Console.Write("Введите число  >> ");
string value = Console.ReadLine();
if (value.Length < 3){
    Console.Write("третьей цифры нет");
}
else{
    Console.Write($"У числа {value} третья цифра {value[2]}");
}