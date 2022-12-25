// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int getNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end+1);
    return number;
}
int SecondDigit(int number)
{
   int digit3 = number / 10;
   int result = digit3 % 10;
   return result;
} 
int randomNumber = getNumberFromRange(100,999);
int numberSecond = SecondDigit(randomNumber);
Console.WriteLine($"Вторая цифра числа {randomNumber} равна {numberSecond}");