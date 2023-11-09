using System;

record Pessoa(string Nome, int Idade, string Sexo);

class Program
{
    static void Main()
    {
        Pessoa[] pessoas = new Pessoa[]
        {
            new Pessoa("Alice", 30,"F"),
            new Pessoa("Bob", 25,"M"),
            new Pessoa("Luana", 38,"F"),
            new Pessoa("Gigi", 8,"F"),
            new Pessoa("Theo", 6,"M"),
            new Pessoa("Cauã", 1,"M"),
            new Pessoa("Isis", 8,"F"),
            new Pessoa("Patrick", 38,"M"),
            new Pessoa("Jeiel", 38,"M")
        };

        Console.WriteLine("Para solicitar a quantidade de pessoas do sexo esclhido, aperte 'F' (feminino) ou 'M' (masculino): ");
        char sexoEscolhido = Console.ReadLine();

        int resultado = quantidadeSexo(pessoas, sexoEscolhido);
        if (resultado == -1)
        {
            Console.WriteLine("Você naõ solicitou o sexo!");
        }
        else
        {
            Console.WriteLine($"A quantidade de pessoas do sexo solicitado foi: {resultado}");
        }
    }

    public static int quantidadeSexo(Pessoa[] pessoas, string tipoSexo)
    {
        int quantMasc = 0;
        int quantFem = 0;
        foreach (Pessoa pessoa in pessoas)
        {
            if (pessoa.Sexo == "M")
            {
                quantMasc++;
            }
            else if (pessoa.Sexo == "F")
            {
                quantFem++;
            }
        }
        if (tipoSexo == "M")
        {
            return quantMasc;
        }
        else if (tipoSexo == "F")
        {
            return quantFem;
        }
        return -1;
    }
}

        /*Console.WriteLine("Pessoas: ");

        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
        }

        for (int i = 0; i < pessoas.Length; i++)
        {
            Console.WriteLine($"Nome: {pessoas[i].Nome}, Idade: {pessoas[i].Idade}");
        }*/