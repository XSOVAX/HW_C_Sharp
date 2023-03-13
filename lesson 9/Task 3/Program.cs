int fun_Akkerman(int n, int m){
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return fun_Akkerman(n - 1, 1);
        else
            return fun_Akkerman(n - 1, fun_Akkerman(n, m - 1));
}

Console.Write("Введите значение M -> ");
int value_m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N -> ");
int value_n = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {value_m}, n = {value_n} -> A({value_m}, {value_n}) = {fun_Akkerman(value_m, value_n)}");
