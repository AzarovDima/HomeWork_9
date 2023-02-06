/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int numberM = GetNumbetFromUser("Введите 1 число: ", " Ошибка ввода!");
int numberN = GetNumbetFromUser("Введите 2 число: ", " Ошибка ввода!");
int GetNumbetFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int temp = numberM;
if (numberM > numberN)
{
    numberM = numberN;
    numberN = temp;
}

ReversSum(numberM, numberN, temp = 0);

void ReversSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {sum} ");
        return;
    }
    ReversSum(m, n - 1, sum);
}