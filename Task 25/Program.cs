Console.Write("Введите число для возведения в степень >> ");
int value = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень >> ");
int degree = Convert.ToInt32(Console.ReadLine());

int answer = 1;
while (degree != 0){
    answer *= value;
    degree--;
}

Console.Write($"{answer}");