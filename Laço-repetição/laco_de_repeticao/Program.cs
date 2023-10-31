using System;

class lacosRepeticao
{
    static void Main(string[] args)
    {

        int option;
        while (true)
        {
            Console.WriteLine("Escolha o tipo de loop que você deseja executar: ");
            Console.WriteLine("1 - Loop For");
            Console.WriteLine("2 - Loop While");
            Console.WriteLine("3 - Loop Do While");
            Console.WriteLine("4 - Loop ForEach");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Digite a opção desejada: ");
            option = Convert.ToInt32(Console.ReadLine());
            if (option == 0)
            {
                Console.WriteLine("Saindo...");
                break;
            }
            Console.Clear();
            Console.WriteLine("Loop escolhido: ");

            switch (option)
            {
                case 1:
                    LoopFor();
                    break;
                case 2:
                    LoopWhile();
                    break;
                case 3:
                    LoopDoWhile();
                    break;
                case 4:
                    LoopForEach();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }

            Console.WriteLine("\n");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void LoopFor()
    {
        Console.WriteLine("LOOP FOR");
        for (int i = 0; i < 5; i++)
        {
            //Console.WriteLine("Esta é a volta número: " + (i+1));
            Console.WriteLine($"Esta é a volta número: {i + 1}");
        }
    }
    static void LoopWhile()
    {
        Console.WriteLine("LOOP WHILE");
        int i = 0;
        while (i < 5)
        {
            i++;
            Console.WriteLine(i);
        }
    }
    static void LoopDoWhile()
    {
        Console.WriteLine("LOOP DO WHILE");
        int j = 0;
        do
        {
            j++;
            Console.WriteLine(j);
        } while (j < 10);
    }
    static void LoopForEach()
    {
        Console.WriteLine("LOOP FOR EACH");
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }

}

