using System;

class vetor_CRUD
{
    static string[] nomes = new string[5];
    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Adicionar nome");
            Console.WriteLine("2 - Localizar nome");
            Console.WriteLine("3 - Alterar nome");
            Console.WriteLine("4 - Apagar nome");
            Console.WriteLine("0 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarNome();
                    break;
                case 2:
                    LocalizarNome();
                    break;
                case 3:
                    AlterarNome();
                    break;
                case 4:
                    ApagarNome();
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente!");
                    break;
            }
        } while (opcao != 0);
    }
    static void AdicionarNome()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome a ser adicionado: ");
        string nome = Console.ReadLine();

        for(int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == null)
            {
                nomes[i] = nome;
                Console.WriteLine("Nome adicionado com sucesso");
                return;
            }
        }
        Console.WriteLine("O vetor de nomes está cheio. Não é possível adicionar mais nomes!");
    }
    static void LocalizarNome()
    {

    }
    static void AlterarNome()
    {

    }
    static void ApagarNome()
    {

    }
}
