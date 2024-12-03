# Recursividade

## O que é Recursividade?

**Recursividade** é um programa que chama a si mesmo, de forma direta ou indiretamente.

## Vantagens

- É a maneira mais natural e lógica de resolver um problema.
- Redução do tamanho do código-fonte.
- Permite descrever algoritmos de forma mais clara e concisa.

## Desvantagens

- O constante uso da pilha pode levar a uma execução mais lenta.
- O não gerenciamento dinâmico de memória pode levar a um “estouro” da pilha (Stack overflow).
- Redução do desempenho de execução devido ao tempo para gerenciamento de chamadas.
- Dificuldades na depuração de programas recursivos, especialmente se a recursão for muito profunda.

## Outros Aspectos

- Procedimentos recursivos introduzem a possibilidade de iterações que podem não terminar: existe a necessidade de considerar o problema de **terminação**.
- É fundamental que a chamada recursiva a um procedimento `P` esteja sujeita a uma condição `A`, a qual se torna satisfeita em algum momento da computação.
    - Ex.: Se não existisse a condição `n=0`, quando o procedimento terminaria?
- **Condição de terminação**:
    - Permite que o procedimento deixe de ser executado.
    - O procedimento deve ter pelo menos um caso básico para cada caso recursivo, o que significa a finalização do procedimento.

## Exemplo de Cálculo do Fatorial de um Número

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
        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("O fatorial de {0} é {1}", num, fatorial(num));
        Console.ReadKey();
    }
}
```