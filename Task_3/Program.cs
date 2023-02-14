Console.Write("Введите число для проверки четности >> ");
int value = Convert.ToInt32(Console.ReadLine());

string answer = "да";
if (value % 2  == 1) {
    answer = "нет";
}

Console.Write($"Введенное число четное (да/нет): {answer}");