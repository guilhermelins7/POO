/* Sobrescrita: */

namespace RPG
{
    class Heroi
    {
        // Classe base atacar:
        public virtual void Atacar()
        {
            Console.WriteLine("Heroi atancado...");
        }
    }

    class Arqueiro : Heroi
    {
        // Metodo sobreescrito com ataque do arqueiro
        public override void Atacar()
        {
            Console.WriteLine("O Arqueiro atira uma flecha!");
        }
    }

    class Mago : Heroi
    {
        // Metodo sobreescrito com ataque do mago
        public override void Atacar()
        {
            Console.WriteLine("O Mago lança um feitiço!");
        }
    }

    class Guerreiro : Heroi
    {
        // Metodo sobreescrito com ataque do Guerreiro
        public override void Atacar()
        {
            Console.WriteLine("O Guerreiro ataca com a espada!");
        }
    }

    class Progrm
    {
        static void Main()
        {
            Arqueiro arqueiro = new Arqueiro();
            Mago mago = new Mago();
            Guerreiro guerreiro = new Guerreiro();

            // Exemplo do uso dos métodos sobreescritos:
            arqueiro.Atacar();
            mago.Atacar();
            guerreiro.Atacar();
        }
    }
}

namespace Linguagem
{
    // Classe base com exibição exemplo (Não será utilizada).
    class Country
    {
        public virtual void LinguaFalada()
        {
            Console.WriteLine("Um país tem uma língua nativa...");
        }
    }
    // Exeplo de sobrescrita do método LinguaFalada para cada país abaixo,
    class Brazil : Country
    {
        public override void LinguaFalada()
        {
            Console.WriteLine("No Brasil, o idioma falado é o Português.");
        }
    }

    class England : Country
    {
        public override void LinguaFalada()
        {
            Console.WriteLine("Na Inglaterra, o idioma falado é o inglês.");
        }
    }

    class Argentina : Country
    {
        public override void LinguaFalada()
        {
            Console.WriteLine("Na Argentina, o idioma falado é o espanhol.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Instanciando cada classe herdada de Contry:
            Brazil brazil = new Brazil();
            England england = new England();
            Argentina argentina = new Argentina();

            // Exemplo do uso do método sobrescrito:
            brazil.LinguaFalada();
            england.LinguaFalada();
            argentina.LinguaFalada();
        }
    }
}

/* Sobrecarga: */

namespace SistemaDeContatos
{
    class Contato
    {
        public int DDD { get; set; }
        public int Numero { get; set; }
        public string NomeDoContato { get; set; }

        // Construtor para adicionar apenas número:
        public Contato(int numero)
        {
            Numero = numero;
        }

        // Construtor para adicionar Número com DDD:
        public Contato(int ddd, int numero)
        {
            DDD = ddd;
            Numero = numero;
        }

        // Construtor para adicionar ddd, número e Nome
        public Contato(int ddd, int numero, string nome)
        {
            DDD = ddd;
            Numero = numero;
            NomeDoContato = nome;
        }

        // Método para definir como será exibido:
        public override string ToString()
        {
            return $"{DDD}, {Numero}, {NomeDoContato}";
        }
    }
    class Program
    {
        static void Main()
        {
            Contato numero = new Contato(996043636);
            Contato numeroEDDD = new Contato(13, 996043636);
            Contato numeroDDDNome = new Contato(13, 996043636, "Guilherme");

            // Exibição dos Exemplos:
            Console.WriteLine(numero);
            Console.WriteLine(numeroEDDD);
            Console.WriteLine(numeroDDDNome);
        }
    }
}

namespace FolhaDePagamento
{
    class PagamentoColaborador
    {
        public string NomeColaborador { get; set; }
        public decimal Salario { get; set; }
        public int AumentoEmPorcentagem { get; set; }
        public decimal Bonus { get; set; }

        // Construtor com pagamento mensal Padrão:
        public PagamentoColaborador(string nomeColaraborador, decimal salarioMes)
        {
            NomeColaborador = nomeColaraborador;
            Salario = salarioMes;
        }
        // Construtor com pagamento mensal com bonus:
        public PagamentoColaborador(string nomeColaraborador, decimal salarioMes, decimal bonus)
        {
            NomeColaborador = nomeColaraborador;
            Salario = salarioMes;
            Bonus = bonus;
        }
        // Construtor com pagamento mensal com aumento:
        public PagamentoColaborador(string nomeColaraborador, decimal salarioMes, int aumentoEmPorcentagem)
        {
            NomeColaborador = nomeColaraborador;
            Salario = salarioMes;
            AumentoEmPorcentagem = aumentoEmPorcentagem;
        }

        public override string ToString()
        {
            return $"Pagamento do colaborador: {NomeColaborador}\n" +
                   $"Salario: {Salario}\n" +
                   $"Bonus: {Bonus}\n" +
                   $"Aumento em porcentagem: {AumentoEmPorcentagem}%";
        }
    }

    class Program
    {
        static void Main()
        {
            // Exemplo de instanciação apenas com salario:
            PagamentoColaborador marcos = new PagamentoColaborador("Marcos", 2135.07m);
            // Exemplo de instanciação com salario e bonus:
            PagamentoColaborador guilherme = new PagamentoColaborador("Guilherme", 3179.32m, 12);
            // Exemplo de instanciação com salario e aumento:
            PagamentoColaborador joao = new PagamentoColaborador("João", 2892.33m, 900.44m);

            // Exibição dos pagamentos:
            Console.WriteLine(marcos);
            Console.WriteLine();
            Console.WriteLine(guilherme);
            Console.WriteLine();
            Console.WriteLine(joao);
        }
    }
}