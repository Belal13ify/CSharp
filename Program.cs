// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("What is your name?!");
string? name = Console.ReadLine();
Console.WriteLine("Welcome " + name + ", How are you?!");


int num1;
int num2;

Console.Write("Please input the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
            
int result = num1 * num2;
Console.WriteLine("The result is " + result);

Console.ReadKey();
