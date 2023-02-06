/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int numberM = GetNumberFromUser("Введите натуральное число M: ", "Ошибка ввода попробуйте еще раз!");
int numberN = GetNumberFromUser("Введите натуральное число M: ", "Ошибка ввода попробуйте еще раз!");
double result = AckermannFunction(numberM, numberN);

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {result}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        if (isCorrect)
            return number;
        else
            Console.WriteLine(errorMessage);
    }


}
double AckermannFunction(double m, double n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return AckermannFunction(m, n);
}
