# Recursividade

## O que � Recursividade?

**Recursividade** � um programa que chama a si mesmo, de forma direta ou indiretamente.

## Vantagens

- � a maneira mais natural e l�gica de resolver um problema.
- Redu��o do tamanho do c�digo-fonte.
- Permite descrever algoritmos de forma mais clara e concisa.

## Desvantagens

- O constante uso da pilha pode levar a uma execu��o mais lenta.
- O n�o gerenciamento din�mico de mem�ria pode levar a um �estouro� da pilha (Stack overflow).
- Redu��o do desempenho de execu��o devido ao tempo para gerenciamento de chamadas.
- Dificuldades na depura��o de programas recursivos, especialmente se a recurs�o for muito profunda.

## Outros Aspectos

- Procedimentos recursivos introduzem a possibilidade de itera��es que podem n�o terminar: existe a necessidade de considerar o problema de **termina��o**.
- � fundamental que a chamada recursiva a um procedimento `P` esteja sujeita a uma condi��o `A`, a qual se torna satisfeita em algum momento da computa��o.
    - Ex.: Se n�o existisse a condi��o `n=0`, quando o procedimento terminaria?
- **Condi��o de termina��o**:
    - Permite que o procedimento deixe de ser executado.
    - O procedimento deve ter pelo menos um caso b�sico para cada caso recursivo, o que significa a finaliza��o do procedimento.

## Exemplo de C�lculo do Fatorial de um N�mero

```csharp
class Program
{
    static int fatorial(int n)
    {
        if (n == 0) return 1;
        return (n * fatorial(n - 1));
    }

    static void Main(string[] args)
    {
        int num;
        Console.Write("Digite um n�mero: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("O fatorial de {0} � {1}", num, fatorial(num));
        Console.ReadKey();
    }
}
```