// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int Prompt(string msg)
{
    System.Console.Write($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int num = Prompt("Введите цифру, обозначающую день недели");

if (num > 0 && num < 6)
{
    System.Console.WriteLine($"День недели, который обозначается цифрой {num}, не является выходным.");
}
else if(num == 6 || num == 7)
{
    System.Console.WriteLine($"День недели, который обозначается цифрой {num}, является выходным.");
}
else
{
    System.Console.WriteLine($"Цифрой {num} день недели не обозначается.");
}