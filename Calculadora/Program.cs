using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o sinal da operação que deseja atribuir: ");
        string op = Console.ReadLine();

        Console.WriteLine("Digite o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Total da operação: " + (Calcular(num1, num2, op)));
    }

    static int Calcular(int num1, int num2, string op)
    {
        int total = 0;
        if (op == "+")
        {
            total = num1 + num2;
        }
        else if (op == "-")
        {
            total = num1 - num2;
        }
        else if (op == "*")
        {
            total = num1 * num2;
        }
        else if (op == "/")
        {
            total = num1 / num2;
        }

       return total;
    }    
}