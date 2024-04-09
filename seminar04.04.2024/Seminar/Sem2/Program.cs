
// создаем метод по возведению в квадрат числа 'num'
void NumToQuad(int num)
{
    System.Console.WriteLine($"quad number = {num*num}");

}

// создаем второй метод по возведению в квадрат числа 'num'
int NumToQuad2(int num)
{
    return num*num;
}

// Запрос числа у пользователя
System.Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

//Вызов метода NumToQuad
NumToQuad(num);

//int result = NumToQuad2(num);
//System.Console.WriteLine($"quad number = {result}");
System.Console.WriteLine(NumToQuad2(num));

//Задача 1: Напишите программу, которая принимает на
//входе трехзначное число и удаляет вторую
//цифру этого числа.
//Пример
//а = 256 => 26
//a = 891 => 81

int DeleteSecondDigit(int num1)
{
    if (num1 >= 100 && num1 <=999)
    {
        int ed = num1 % 10;
        int sot = num1 / 100;
        return sot * 10 + ed;
    }
    else
    {
        Console.WriteLine("You input not three-digit number: ");
        return 0;
    }
    
}
System.Console.Write("Input three-digit number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine(DeleteSecondDigit(num1));

//Задача 2: Напишите программу, которая принимает на
//входе трехзначное число и возводит вторую цифру этого 
//числа в степень, равную третьей цифре.
//Пример
//487 => 8^7 = 2 097 152
//254 => 5^4 = 625

int SecondToThirdPower(int num2)
{
    if (num2 >= 100 && num2 <=999)
    {
        int ed = num2 % 10;
        int dec = num2 / 10 % 10;
        int result = 1;
        for (int i = 0; i < ed; i++)
        {
            result = result * dec;
        }
        return result; 
    }
    else
    {
        Console.WriteLine("You input not three-digit number: ");
        return 0;
    }
    
}

System.Console.Write("Input three-digit number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine(SecondToThirdPower(num2));

 //Задача 3: Напишите программу, которая принимает на
//входе два числа и выводить является ли первое число
//кратным второму. Если первое число не кратно второму,
// то выводится остаток от деления.
//Пример
//14, 5 => нет, 4
//18,8 => да

void CheIfDevides(int a, int b)
{
    if (a % b == 0)
    {
        System.Console.WriteLine("Yes");
    }
    else if (a % b != 0)
    {
        System.Console.WriteLine($"No {a%b}");
    }
   
}
System.Console.Write("Input number-1: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number-2: ");
int b = Convert.ToInt32(Console.ReadLine());
CheIfDevides(a,b);