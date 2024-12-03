/*
Escreva um programa que receba um número inteiro entre 1 e 10, 
inclusive, digitado pelo usuário. O programa deve utilizar uma 
função que receba este número como argumento e retorne o número 
correspondente por extenso.
*/

class Program
{
    static void Main()
    {
        int numero = 0;
        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 1 || numero > 10)
            {
                Console.WriteLine("Número inválido, digite um valor entre 1 e 10.");
            }
        } while (numero < 1 || numero > 10);

        string numeroExtenso = PassarParaExtenso(numero);

        Console.WriteLine($"número escrito por extenso: {numeroExtenso}");
    }
    static string PassarParaExtenso(int numero)
    {
        string numeroExtenso = "";

        switch (numero)
        {
            case 1:
                numeroExtenso = "um";
                break;
            case 2:
                numeroExtenso = "dois";
                break;
            case 3:
                numeroExtenso = "tres";
                break;
            case 4:
                numeroExtenso = "quatro";
                break;
            case 5:
                numeroExtenso = "cinco";
                break;
            case 6:
                numeroExtenso = "seis";
                break;
            case 7:
                numeroExtenso = "sete";
                break;
            case 8:
                numeroExtenso = "oito";
                break;
            case 9:
                numeroExtenso = "nove";
                break;
            case 10:
                numeroExtenso = "dez";
                break;
            default:
                numeroExtenso = "";
                break;
        }

        return numeroExtenso;
    }
}

/*
 Desenvolvoda um programa que funcione como uma calculadora simples. 
O programa deve solicitar ao usuário 2 (dois) números e uma operação 
matemática (adição, subtração, multiplicação ou divisão). Crie uma 
função para cada operação matemática que receba os dois números como 
argumentos e retorne o resultado da operação.
 */

class Program
{
    static void Main()
    {
        float valorUm, valorDois, resultado;
        char operacao;

        Console.WriteLine("-- Calculadora --");

        do // Tratativa em caso de tentativa de divisão por 0.
        {
            Console.Write("Digite o primeiro valor:");
            valorUm = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor:");
            valorDois = float.Parse(Console.ReadLine());

            do // garantir digitação de operação
            {
                Console.Write("Digite a operação matemática (+) (-) (*) (/): ");
                operacao = Console.ReadKey().KeyChar;

                if (operacao != '+' && operacao != '-' && operacao != '*' && operacao != '/')
                {
                    Console.WriteLine("\n\nCaractere inválido. Tente novamente\n");
                }
            } while (operacao != '+' && operacao != '-' && operacao != '*' && operacao != '/');

            if (valorDois == 0 && operacao == '/')
            {
                Console.WriteLine("\n\nNão é possível dividir qualquer número por zero. Tente novamente\n");
            }

        } while (valorDois == 0 && operacao == '/');

        resultado = Calcular(valorUm, valorDois, operacao);

        Console.WriteLine($"\nresultado da operação {valorUm} {operacao} {valorDois} = {resultado}");
    }

    static float Calcular(float valorUm, float valorDois, char operacao)
    {
        float resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = valorUm + valorDois;
                break;
            case '-':
                resultado = valorUm - valorDois;
                break;
            case '*':
                resultado = valorUm * valorDois;
                break;
            case '/':
                resultado = valorUm / valorDois;
                break;
            default:
                break;
        }

        return resultado;
    }
}

/*
Desenvolva um programa que receba via teclado o número do CPF 
do usuário e o valide através de uma função C#. 
*/

class Program
{
    static void Main()
    {
        string cpf;
        bool cpfValido;

        Console.Write("Informe o CPF para validação: ");
        cpf = Console.ReadLine();

        cpfValido = ValidarCpf(cpf);

        if (cpfValido)
        {
            Console.WriteLine($"O CPF: {cpf} é valido.");
        }
        else
        {
            Console.WriteLine($"O CPF: {cpf} é invalido.");
        }
    }

    static bool ValidarCpf(string cpf)
    {
        bool validacaoCpf = false;

        int validadorUm = 0;
        int moduloUm = 0;

        int validadorDois = 0;
        int moduloDois = 0;

        // Validando o primeiro dígito verificador
        for (int index = 0, multiplicador = 10; index < 9; index++, multiplicador--)
        {
            int numero = cpf[index] - '0';
            validadorUm += (numero * multiplicador);
        }

        moduloUm = validadorUm % 11;

        if (11 - moduloUm >= 10)
        {
            moduloUm = 0;
        }
        else
        {
            moduloUm = 11 - moduloUm;
        }

        // Validando o segundo dígito verificador
        for (int index = 0, multiplicador = 11; index < 10; index++, multiplicador--)
        {
            int numero = cpf[index] - '0';
            validadorDois += (numero * multiplicador);
        }

        moduloDois = validadorDois % 11;

        if (11 - moduloDois >= 10)
        {
            moduloDois = 0;
        }
        else
        {
            moduloDois = 11 - moduloDois;
        }

        // Checar se valores batem com string original e retornar validação
        validadorUm = cpf[9] - '0';
        validadorDois = cpf[10] - '0';

        if (moduloUm == validadorUm && moduloDois == validadorDois)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}