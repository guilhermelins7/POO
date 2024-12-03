/*
 Escreva uma função que calcule e retorne o fatorial
de um número inteiro positivo.
*/

class Program
{
    static void Main()
    {
        Console.Write("Informe um valor para mostrar o seu fatorial: ");
        int valor = int.Parse(Console.ReadLine());

        int resultado = Fatorial(valor);

        Console.WriteLine(resultado);
    }

    static int Fatorial(int valor)
    {
        int resultado = 1;

        while (valor > 0)
        {
            resultado *= valor;
            valor--;
        }

        return resultado;
    }
}

/* Faça um algoritmo que leia a idade de uma 
pessoa expressa em anos, meses e dias e 
escreva a idade dessa pessoa expressa apenas 
em dias. Considerar ano com 365 dias e mês com 
30 dias.*/

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe sua idade:");
        Console.Write("Anos: ");
        int anosIdade = int.Parse(Console.ReadLine());

        Console.Write("Meses: ");
        int mesesIdade = int.Parse(Console.ReadLine());

        Console.Write("Dias: ");
        int diasIdade = int.Parse(Console.ReadLine());

        int diasAnos = AnosParaDias(anosIdade);
        int diasMes = MesesParaDias(mesesIdade);

        int diasTotais = diasAnos + diasMes + diasIdade;

        Console.WriteLine(diasTotais);
    }

    static int MesesParaDias(int meses)
    {
        return meses * 30;
    }

    static int AnosParaDias(int anos)
    {
        return anos * 365;
    }
}

/*
 Desenvolva um algoritmo que solicite a entrada de 
um número e calcule se o número é par ou ímpar.
*/

class Program
{
    static void Main()
    {
        int numero;

        Console.Write("Digite um numero: ");
        numero = int.Parse(Console.ReadLine());

        bool check = ChecarValorPar(numero);

        if (check)
        {
            Console.WriteLine("É Par");
        }
        else
        {
            Console.WriteLine("É Impar");
        }
    }
    static bool ChecarValorPar(int valor)
    {
        if (valor % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

/* 
 Escreva uma função que verifique se um número é
primo. Sua função deve retornar verdadeiro ou 
falso. O argumento de entrada é o número a ser 
verificado.
*/

class Program
{
    static void Main()
    {
        int valor;

        Console.Write("Informe um numero para checar se é primo: ");
        valor = int.Parse(Console.ReadLine());

        bool resultadoChecagemPrimo = VerificarPrimo(valor);

        if (resultadoChecagemPrimo) // Caso não seja primo
        {
            Console.WriteLine("{0} é primo", valor);
        }
        else
        {
            Console.WriteLine("{0} não é primo", valor);
        }
    }

    static bool VerificarPrimo(int valor)
    {
        bool Primo = true;
        int i = 2;

        if (valor == 1)
        {
            Primo = false;
            return Primo;
        }
        else if (valor == 2)
        {
            return Primo;
        }

        while (Primo && i < valor)
        {
            if (valor % i == 0)
            {
                Primo = false;
            }
            i++;
        }

        return Primo;
    }
}