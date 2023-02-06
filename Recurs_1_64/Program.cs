/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int userNumber = GetNumbetFromUser("Введите целое натуральное число: ", " Ошибка ввода!");

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
Console.Write($"N = {userNumber} -> ");
Console.Write(ShowLine(userNumber, 1));

string ShowLine(int start, int end)
{
    if (start == end) return end.ToString();
    else return start + ", " + ShowLine(start - 1, end);
}




