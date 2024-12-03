/*
Desenvolva um algoritmo recursivo que soma todos
os valores compreendidos entre 1 e o número
digitado pelo usuário.
*/

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(Somar(numero));
    }
    static int Somar(int numero)
    {
        if (numero == 1) return 1; // Até que o número seja 1
        return numero + Somar(numero - 1);
    }
}

/*
Desenvolva um algoritmo recursivo que identifica o
maior elemento em um array.
*/

class Program
{
    static void Main()
    {
        int[] array = new int[] { 10, 30, 20 /*7, 10, 30, 20,*/ };
        Console.WriteLine(VerificarMaior((/* passar maior indice: */ array.Length - 1), array));
    }
    static int VerificarMaior(int index, int[] array)
    {
        int maiorValor;
        if (index == 0) maiorValor = array[0];
        else
        {
            maiorValor = VerificarMaior(index - 1, array);
            if (maiorValor < array[index]) maiorValor = array[index];
        }
        return maiorValor;
    }
}

/*
Implemente uma função recursiva chamadasoma_digitos que receba um número inteiro positivo
e retorne a soma de todos os seus dígitos.
*/

class Program
{
    static void Main()
    {
        Console.Write("Informe um valor para somar seus digitos: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine(soma_digitos(numero));
    }
    static int soma_digitos(int numero)
    {
        if (numero < 10) return numero;
        else return (numero % 10 /*pegar unidade*/) + soma_digitos(numero / 10);
    }
}