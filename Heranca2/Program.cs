/* Exercicio 1 */
namespace Exercicio1
{
    class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}\n" +
            $"Modelo: {Modelo}\n" +
            $"Ano: {Ano}");
        }
    }
    class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Numero de portas: {NumeroDePortas}");
        }
    }
    class Moto : Veiculo
    {
        public string TipoDeGuidao { get; set; }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Tipo de Guidão: {TipoDeGuidao}");
        }
    }
    class Caminhao : Veiculo
    {
        public float CapacidadeCarga { get; set; }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Capacidade de carga: {CapacidadeCarga}");
        }
    }
    class Frota : Veiculo
    {
        public List<Veiculo> ListaVeiculos = new List<Veiculo>();
        public void AdicionarVeiculo(Veiculo veiculo)
        {
            ListaVeiculos.Add(veiculo);
        }
        public void MostrarTodosVeiculos()
        {
            foreach (var veiculo in ListaVeiculos)
            {
                veiculo.MostrarInfo();
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("indique os valores para o Carro:");
            Carro carro = new Carro();
            Console.Write("Marca: ");
            carro.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            carro.Modelo = Console.ReadLine();
            Console.Write("Ano: ");
            carro.Ano = int.Parse(Console.ReadLine());
            Console.Write("Numero de portas: ");
            carro.NumeroDePortas = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("indique os valores para a Moto:");
            Moto moto = new Moto();
            Console.Write("Marca: ");
            moto.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            moto.Modelo = Console.ReadLine();
            Console.Write("Ano: ");
            moto.Ano = int.Parse(Console.ReadLine());
            Console.Write("Tipo de Guidão: ");
            moto.TipoDeGuidao = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("indique os valores para o Caminhão:");
            Caminhao caminhao = new Caminhao();
            Console.Write("Marca: ");
            caminhao.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            caminhao.Modelo = Console.ReadLine();
            Console.Write("Ano: ");
            caminhao.Ano = int.Parse(Console.ReadLine());
            Console.Write("Capacidade de Carga: ");
            caminhao.CapacidadeCarga = float.Parse(Console.ReadLine());
            Console.Clear();
            Frota veiculos = new Frota();
            veiculos.AdicionarVeiculo(carro);
            veiculos.AdicionarVeiculo(moto);
            veiculos.AdicionarVeiculo(caminhao);
            veiculos.MostrarTodosVeiculos();
        }
    }
}

/* Exercicio 2: */

namespace Biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        private bool _disponivel = true;
        public void Emprestar()
        {
            _disponivel = false;
            Console.WriteLine($"{Titulo}: Livro Emprestado!");
        }
        public void Devolver()
        {
            _disponivel = true;
            Console.WriteLine($"{Titulo}: Livro Devolvido!");
        }
        public override string ToString()
        {
            return $"Titulo: {Titulo}\nAutor: {Autor}";
        }
    }
    public class Program
    {
        static void Main()
        {
            Livro livroUm = new Livro() { Titulo = "O Senhor dos Aneis", Autor = "J.R.R.Tolkien" };
            Livro livroDois = new Livro() { Titulo = "Harry Potter e a Pedra Filosofal", Autor = " J.K.Rowling" };

            Console.WriteLine("Livros na biblioteca:");
            Console.WriteLine(livroUm);
            Console.WriteLine();
            Console.WriteLine(livroDois);

            Console.WriteLine("\nEmprestar Livro 1: ");
            livroUm.Emprestar();

            Console.WriteLine("\nDevolver Livro 1:");
            livroUm.Devolver();
        }
    }
}

/* Exercicio 3: */
namespace Banco
{
    public class Conta
    {
        public double Saldo;
        public void LancarCredito(double valor)
        {
            Saldo -= valor;
        }
        public void LancarTransferencia(double valor, string conta)
        {
            Saldo = valor;
            Console.WriteLine($"Saldo de {valor} transferido para {conta}");
        }
        public double CalcularSaldo()
        {
            return Saldo;
        }
    }
    public class ContaInvestimento : Conta
    {
        public ContaInvestimento(double saldo)
        {
            Saldo = saldo;
        }
        public double CalcularRendimento(int meses, float taxaJuros)
        {
            double valorFinal = Saldo;

            for (int i = 1; i <= taxaJuros; i++)
            {
                valorFinal += Saldo * (taxaJuros * 0.1);
            }

            return valorFinal;
        }
    }
    public class ContaCorrente : Conta
    {
        public ContaCorrente(double saldo)
        {
            Saldo = saldo;
        }
        public void LancarDebito(double valor)
        {
            Saldo += valor;
        }
    }
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Inform o tipo de conta que deseja criar: \n1 - Conta Corrente;\n2 - Conta de Investimento.");

            string resposta = Console.ReadLine();

            if (resposta == "1")
            {
                Console.Write("Informe um saldo inicial:");
                double saldoInicial = double.Parse(Console.ReadLine());

                ContaCorrente contaCorrente = new ContaCorrente(saldoInicial);

                Console.Write("Informe um valor para lançar como credito: ");
                double credito = double.Parse(Console.ReadLine());
                contaCorrente.LancarCredito(credito);

                Console.Write("Informe um valor para lançar como debito: ");
                double debito = double.Parse(Console.ReadLine());
                contaCorrente.LancarDebito(debito);

                Console.Write("Saldo atual da conta: ");
                double saldoAtual = contaCorrente.CalcularSaldo();
                Console.WriteLine(saldoAtual);
            }
            else if (resposta == "2")
            {
                Console.Write("Informe um saldo inicial:");
                double saldoInicial = double.Parse(Console.ReadLine());

                ContaInvestimento contaInvestimento = new ContaInvestimento(saldoInicial);

                Console.WriteLine("Informe meses e taxa de juros para calcular investimento: ");
                Console.Write("Meses: ");
                int meses = int.Parse(Console.ReadLine());

                Console.Write("Taxa de juros (em %): ");
                float taxaDeJuros = float.Parse(Console.ReadLine());

                double rendimentos = contaInvestimento.CalcularRendimento(meses, taxaDeJuros);

                Console.WriteLine("Saldo final apos o periodo de acordo com taxa: " + rendimentos);
            }
        }
    }
}