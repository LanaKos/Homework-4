/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else 
        {
        Console.WriteLine("Ввели не число");
        }
    }

return result;
}

int GetSumm(int number)
{
    int summ = 0;
    for (int i =0; i <= number; i++)
    {
        summ += number % 10;
        number /= 10;
    }
    return summ;
}

int number = GetNumber("Введите число:");
int summ = GetSumm(number);

Console.WriteLine($"Сумма чисел равна: {summ}");

