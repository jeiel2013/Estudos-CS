using System;

class vetores_01
{
    static void Main()
    {
        //Declarando e inicializando um vetor com números inteiros
        int tamanhoVetor;
        Console.WriteLine("Digite o tamanho do vetor: ");
        tamanhoVetor = int.Parse(Console.ReadLine());
        int[] numeros = new int[tamanhoVetor];

        //Preenchimento do vetor com valores informados pelo user
        for (int i=0;i<tamanhoVetor;i++)
        {
            Console.WriteLine($"Digite o {i + 1}° número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        //Calcular a média dos valores no vetor
        double soma = 0;
        for (int i=0;i<tamanhoVetor;i++)
        {
            soma = soma + numeros[i];
        }
        double media = soma / tamanhoVetor;

        //Imprimir todos os valores armazenados no vetor 
        for (int i=0;i<tamanhoVetor;i++)
        {
            Console.WriteLine(numeros[i]);
        }

        // Imprimir a média dos valores no vetor
        Console.WriteLine("\n");
        Console.WriteLine($"A média dos valores acima é {media}");
    }
}
