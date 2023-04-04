namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information

            //Primeira aula academia Atos;

            Console.WriteLine("Hello, World!");

            Console.WriteLine(2 + 2);

            Console.WriteLine("Escreva o seu nome: ");
            string nome; // Declaração;

            // Variaveis são Case-Sensitive, ou seja, Caractere maiuscula ou muniscula fazem a diferença;
            //nome = "Fabrício";
            nome = Console.ReadLine(); // Usuário digitará o valor;

            Console.WriteLine(nome);

            Console.WriteLine("Seu nome é: " + nome); // Concatenação;


            // Tipos de variaveis;

            int x; // Numeros inteiros;
            long l; // Numeros inteiros;
            float y; // Numeros Reais;
            double z; // Numeros Reais;
            bool a; // true / false;
            char c; // um caractere;
            string s; // Texto, frases, qualquer texto;


            int idade = 32;
            int idade1 = 10;
            int idade2 = 20;

            Console.WriteLine("Sua idade é: " + idade + " anos.");

            int soma;
            soma = idade1 + idade2;

            Console.WriteLine("A soma das idades são: " + soma);
            Console.WriteLine("A soma das idades são " + (idade1 + idade2)); // Lembre-se de colocar dentro dos parentases para somar;

            int sub = idade1 - idade2;

            Console.WriteLine("A subtração das idades é: " + sub);

            int multiplicacao = idade1 * idade2; // Multiplicação;

            Console.WriteLine("A subtração das idades é: " + multiplicacao);

            double div = (double)idade1 / (double)idade2; // Cast;
            double div2 = Convert.ToDouble(idade1) / Convert.ToDouble(idade2); // Outra forma de converter para double;

            Console.WriteLine("A divisão entre " + idade1 + " e " + idade2 + " é:" + div);
            Console.WriteLine("A divisão entre " + idade1 + " e " + idade2 + " é:" + div2);


            Console.Write("Digite um valor de A: ");
            int A = int.Parse(Console.ReadLine()); // Recebe uma string e converte para int;

            Console.WriteLine("O valor de A é: " + A);



            // Exercício 01 :
            Console.Write("Digite o 1º valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("A média do valor 1 " + valor1 + " e do valor 2 " + valor2 + " é de: " + (valor1 + valor2) / 2);


            // Exercício 02:
            Console.Write("Digite o valor em Celsius:");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("O valor em Celsius convertido em fahenheit é: " + fahrenheit);



            // Exercício 03:
            Console.Write("Digite o valor a: ");
            int valorA = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor b: ");
            int valorB = int.Parse(Console.ReadLine());

            int invert = valorA;
            valorA = valorB;
            valorB = invert;
            Console.WriteLine("Os valores invertidos são: " + valorB + " e " + invert);



        }
    }
}