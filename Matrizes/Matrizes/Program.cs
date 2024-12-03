/*  Armazenar seis valores em uma matriz de ordem 3x2. 
Apresentar os valores na tela. */

int[,] valores = new int[3, 2];

for (int coluna = 0; coluna < valores.GetLength(0) /* colunas */; coluna++)
{
    for (int linha = 0; linha < valores.GetLength(1) /* linhas */; linha++)
    {
        Console.WriteLine("Digite um valor para armazenar na posição [{0}, {1}] da matriz", coluna, linha);
        valores[coluna, linha] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Valores armazenados:");

for (int coluna = 0; coluna < valores.GetLength(0) /* colunas */; coluna++)
{
    for (int linha = 0; linha < valores.GetLength(1) /* linhas */; linha++)
    {
        Console.WriteLine(valores[coluna, linha]);
    }
}

/* Entrar via teclado com doze valores e armazená-los em uma 
matriz de ordem 3x4. Após a digitação dos valores solicitar 
uma constante multiplicativa, que deverá multiplicar cada valor 
matriz e armazenar o resultado na própria matriz, nas posições 
correspondentes. */

int[,] valores = new int[3, 4];

for (int coluna = 0; coluna < valores.GetLength(0) /* colunas */; coluna++)
{
    for (int linha = 0; linha < valores.GetLength(1) /* linhas */; linha++)
    {
        Console.WriteLine("Digite um valor para armazenar na posição [{0}, {1}] da matriz", coluna, linha);
        valores[coluna, linha] = int.Parse(Console.ReadLine());
    }
}

Console.Write("Informe uma constante multiplicativa: ");
int constante = int.Parse(Console.ReadLine());

for (int coluna = 0; coluna < valores.GetLength(0) /* colunas */; coluna++)
{
    for (int linha = 0; linha < valores.GetLength(1) /* linhas */; linha++)
    {
        valores[coluna, linha] *= constante;
        Console.WriteLine(valores[coluna, linha]);
    }
}

/* Entrar via teclado com doze valores e armazená-los em uma 
matriz de ordem 3x4. Após a digitação dos valores solicitar 
uma constante multiplicativa, que deverá multiplicar cada valor 
matriz e armazenar o resultado em outra matriz de mesma 
ordem, nas posições correspondentes. Exibir as matrizes na 
tela, sob a forma matricial, ou seja, linhas por colunas.*/

int valorColuna = 3;
int valorLinha = 4;

int[,] matrizUm = new int[valorColuna, valorLinha];
int[,] matrizDois = new int[valorColuna, valorLinha];

for (int coluna = 0; coluna < matrizUm.GetLength(0) /* colunas */; coluna++)
{
    for (int linha = 0; linha < matrizUm.GetLength(1) /* linhas */; linha++)
    {
        Console.WriteLine("Digite um valor para armazenar na posição [{0}, {1}] da matriz", coluna, linha);
        matrizUm[coluna, linha] = int.Parse(Console.ReadLine());
    }
}

Console.Write("Informe uma constante multiplicativa: ");
int constante = int.Parse(Console.ReadLine());

for (int coluna = 0; coluna < matrizUm.GetLength(0) /* colunas */; coluna++)
{
    for (int linha = 0; linha < matrizUm.GetLength(1) /* linhas */; linha++)
    {
        matrizDois[coluna, linha] = matrizUm[coluna, linha] * constante;
    }
}

Console.WriteLine("\nPrimeira matriz:");

for (int coluna = 0; coluna < matrizUm.GetLength(0) /* colunas */; coluna++)
{
    for (int linha = 0; linha < matrizUm.GetLength(1) /* linhas */; linha++)
    {
        Console.Write("{0} ", matrizUm[coluna, linha]);
    }

    Console.WriteLine();
}

Console.WriteLine("\nSegunda matriz com CM {0}:", constante);

for (int coluna = 0; coluna < matrizDois.GetLength(0) /* colunas */; coluna++)
{
    for (int linha = 0; linha < matrizDois.GetLength(1) /* linhas */; linha++)
    {
        Console.Write("{0} ", matrizDois[coluna, linha]);
    }

    Console.WriteLine();
}

/* Entrar com uma matriz de ordem MxN, onde a ordem também 
será escolhida pelo usuário, sendo que no máximo 10x10. 
Após a digitação dos elementos, criar e exibir a matriz 
transposta. */

int m, n;

do
{
    Console.WriteLine("Informe a ordem M (colunas) da matriz:");
    m = int.Parse(Console.ReadLine());
    if (m > 10 || m <= 0)
    {
        Console.WriteLine("Valor inválido, deve ser entre 1 e 10.");
    }
} while (m > 10 || m <= 0);

do
{
    Console.WriteLine("Informe a ordem N (linhas) da matriz:");
    n = int.Parse(Console.ReadLine());
    if (n > 10 || n <= 0)
    {
        Console.WriteLine("Valor inválido, deve ser entre 1 e 10.");
    }
} while (n > 10 || n <= 0);

int[,] matriz = new int[m, n];

for (int coluna = 0; coluna < matriz.GetLength(0) /* colunas */; coluna++)
{
    for (int linha = 0; linha < matriz.GetLength(1) /* linhas */; linha++)
    {
        Console.WriteLine("Digite um valor para armazenar na posição [{0}, {1}] da matriz", coluna, linha);
        matriz[coluna, linha] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Matriz transposta:\n");

for (int coluna = 0; coluna < matriz.GetLength(0) /* colunas */; coluna++)
{
    for (int linha = 0; linha < matriz.GetLength(1) /* linhas */; linha++)
    {
        Console.Write("{0} ", matriz[coluna, linha]);
    }
    Console.WriteLine();
}


/* Criar um programa para controlar as reservas de poltronas de uma peça teatral, 
sabendo que o teatro possui “X” seções de “Y” fileiras com “Z” cadeiras cada. 
Os valores de “X”, “Y” e “Z”serão digitados. O usuário digita seu nome, número da seção, 
fileira e cadeira que pretende reservar, e se estiver livre a reserva será efetuada, 
caso contrário, o programa deverá enviar mensagem comunicando que a cadeira está ocupada e 
solicitar outro lugar. Perguntar ao usuário se mais alguém pretende fazer reservas. 
As reservas poderão ser efetuadas até completar um máximo de quatro quintos da capacidade 
total do teatro. No final do programa de reservas, exibir um “mapa” mostrando as cadeiras 
do teatro com os nomes de cada ocupante, ou ainda com a informação “Livre”. */

Console.WriteLine("Informe o número X de seções que existem no teatro:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o número Y de fileiras que existem no teatro:");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o número Z de cadeiras que existem no teatro:");
int z = int.Parse(Console.ReadLine());

string[,,] teatro = new string[x, y, z];
int setor, fileira, cadeira, contador = 0;
string nome;
char resp = 'N';
bool ocupada = false;

do
{
    do
    {
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite o setor: ");
        setor = int.Parse(Console.ReadLine());

        Console.Write("Digite a fileira: ");
        fileira = int.Parse(Console.ReadLine());

        Console.Write("Digite a cadeira: ");
        cadeira = int.Parse(Console.ReadLine());


        if (teatro[setor - 1, fileira - 1, cadeira - 1] == null)
        {
            teatro[setor - 1, fileira - 1, cadeira - 1] = nome;
            ocupada = false;
        }
        else
        {
            Console.WriteLine("Cadeira ocupada, por favor selecionar outra.");
            ocupada = true;
        }
    } while (ocupada);

    contador++;

    if (contador < teatro.GetLength(0) * teatro.GetLength(1) * teatro.GetLength(2))
    {
        Console.Write("Mais alguém pretende fazer reservas (S/N)? ");
        resp = char.Parse(Console.ReadLine().ToUpper());
    }

} while (resp != 'N' && (contador < ((teatro.GetLength(0) * teatro.GetLength(1) * teatro.GetLength(2)) * 0.8)));

Console.WriteLine("\nMapa de ocupação do Teatro:\n");

for (setor = 0; setor < teatro.GetLength(0); setor++)
{
    for (fileira = 0; fileira < teatro.GetLength(1); fileira++)
    {
        for (cadeira = 0; cadeira < teatro.GetLength(2); cadeira++)
        {
            if (teatro[setor, fileira, cadeira] != null)
            {
                Console.WriteLine("OCUPADA: Nome = {0}, Setor = {1}, Fileira = {2}, Cadeira {3}", teatro[setor, fileira,
               cadeira], setor + 1, fileira + 1, cadeira + 1);
            }
            else
            {
                Console.WriteLine("VAZIA: Setor: {0}, Fileira: {1}, Cadeira: {2}", setor + 1, fileira + 1, cadeira + 1);
            }
        }
    }
}