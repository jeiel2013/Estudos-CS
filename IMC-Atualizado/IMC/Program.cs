using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apresentação
            Console.WriteLine("Vamos calcular seu IMC!");

            // Entrada Peso
            Console.WriteLine("Digite seu peso (em KG): ");
            float peso = float.Parse(Console.ReadLine());

            // Entrada Altura
            Console.WriteLine("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            // Chamar function para Calcular IMC
            float imc = calImc(peso, altura);

            // Escrever o valor do IMC calculado e depois como está
            Console.WriteLine("Seu IMC é de: " + imc + "! ");
            ClassImc(imc);

            // Ler resposta para sair do programa
            Console.ReadLine();
        }

        static float calImc(float peso, float altura)
        {
            float total = peso / (altura * altura);
            return total;
        }

        static void ClassImc(float imc)
        {
            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("Você está em faixa Saudável");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Você está com sobrepeso");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine("Você está com Obesidade 1");
            }
            else if (imc < 39.9)
            {
                Console.WriteLine("Você está com Obesidade 2");
            }
            else
            {
                Console.WriteLine("Você está com Obesidade 3");
            }
        }
    }
}