//Task1
Console.WriteLine("Task1: Qthe square of the number a")
Console.WriteLine("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Quad of {a} -> {a * a}");

//Task2
Console.WriteLine("Task2: is the first number the square of the second?")
Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 == num2 * num2)
{
    Console.WriteLine("The number is a square");
}
else
{
   Console.WriteLine("The number is not a square");
}

//Task3
Console.WriteLine("Task3: N -> -N,...,N");
Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
int start = -n;
while(start <= n)
{
   Console.Write(start + " ");
    start++;
}

//Task4
Console.WriteLine("Task4:The sum of the first and last digits in a three-digit number");
Console.WriteLine("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <=999)
{
  int ed = num % 10;
  int sot = num / 100;
  Console.WriteLine($"Sum of {ed} and {sot} -> {ed+sot}");
}
else
Console.WriteLine("You input not three-digit number: ");