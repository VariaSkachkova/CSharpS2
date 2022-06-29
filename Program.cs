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
Console.WriteLine("Введите первое целое число: ");
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
}