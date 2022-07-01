// Напишите программу, которая выводит случайное число из отрезка 10-99 и показывает наибольшую цифру числа.

Random rand = new Random();// Random - тип данных
//int number = rand.Next(10,100);
// Task9(number);
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
/* Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа. */
//rand = new Random();// Random - тип данных
//number = rand.Next(100,1000);
//Task11(number);
void Task11(int currentNumber)
{
    
    Console.WriteLine(currentNumber);
    int digitFirst = currentNumber/100;
    //int digitSecond = currentNumber % 100 / 10;
    int digitThird = currentNumber % 10;
    int result = digitFirst*10 + digitThird;
    Console.WriteLine(result);
    
}



//Console.WriteLine("Введите число:");
//string number = Console.ReadLine();
//Task11Alt(number);
void Task11Alt (string number)
{
    Console.WriteLine(number);
    Console.Write(number[0]);
    Console.Write(number[2]);
    Console.WriteLine();
}

/*Напишите программу, которая будет принимать
на вход два числа и выводить, является ли второе
число кратным первому. Если число 2 не кратно числу
1, то программа выводит остаток от деления.*/
/*Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Task12(num1, num2);
void Task12 (int num1, int num2) 
{
    int result = num1 % num2;
    if (result == 0)
    {
        Console.WriteLine("Первое число кратно второму ");
    }
    else
    {
        Console.WriteLine(result);
    }
}*/
// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

/*Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Task14(n);
void Task14 (int n)
{
    if (n % 7 == 0 && n % 23 == 0) // && - краткая конъюнкция (смотрит истинность первого значения и если ложное, дальше не проверяет), & - обычная конъюнкция
    {
        Console.WriteLine("Это число кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("Это число не кратно 7 и 23");
    }
}*/

// Напишите программу, которая принимает на
//вход два числа и проверяет, является ли одно
//число квадратом другого.

Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Task16(num1, num2);
void Task16 (int num1, int num2) 
{
    if (num2 == num1 * num1 | num1 == num2 * num2)
    {
        Console.WriteLine("Одно из чисел является квадратом другого");
    }
    else
    {
        Console.WriteLine("Ни одно из чисел не является квадратом другого");
    }
}