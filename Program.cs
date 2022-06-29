// Напишите программу, которая выводит случайное число из отрезка 10-99 и показывает наибольшую цифру числа.

Random rand = new Random();// Random - тип данных
int number = rand.Next(10,100);
Task9(number);
void Task9(int currentNumber)
{
    
    Console.WriteLine(currentNumber);
    int digitFirst = currentNumber/10;
    int digitSecond = currentNumber%10;
    if (digitFirst > digitSecond)
    {
        Console.WriteLine(digitFirst);
    }
    else
    {
        Console.WriteLine(digitSecond);
    }
}