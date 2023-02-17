Console.Write("Введите порядковый номер дня недели >> ");
int value = Convert.ToInt32(Console.ReadLine());

while (value > 7){
    Console.WriteLine("В неделе всего 7 дней");
    Console.WriteLine($"Возможно вы имели ввиду {value % 7}?");
    Console.Write("Для подтверждения введите номер дня недели снова >> ");
    value = Convert.ToInt32(Console.ReadLine());
}

string answer = "да";
if (value < 6) {
    answer = "нет";
}

Console.Write($"Введенный номер дня соответствует выходному (да / нет): {answer}");