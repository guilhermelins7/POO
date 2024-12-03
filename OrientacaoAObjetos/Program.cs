/*
Declare uma classe “Funcionario” que possui 2 (dois)
campos (nome do funcionário e salário). Em seguida
realize a instanciação de um objeto da respectiva classe.
*/

namespace Program
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;
    }
    public class Program
    {
        static void Main()
        {
            Funcionario funcionarioUm = new Funcionario();
        }
    }
}

/*
Altere a classe do exercício anterior de tal a forma a
implementar um método construtor que realizar a
atribuição inicial para os campos da classe.
*/

namespace Program
{
    public class Funcionario
    {
        public string Nome;
        public double Salario;
        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
    public class Program
    {
        static void Main()
        {
            string nome = "Guilherme";
            double salario = 100000.50;
            Funcionario funcionarioUm = new Funcionario(nome, salario);
        }
    }
}

/*
Crie uma classe chamada “Nota Fiscal” que possa ser
utilizado por uma loja de suprimentos de tecnologia para
representar uma fatura de um item vendido na loja. Uma
Nota fiscal deve incluir as seguintes informações como
atributos: o número do item faturado; a descrição do item;
a quantidade comprada do item; o preço unitário do item.
Esta classe deve ter um construtor que inicialize os quatro
atributos. Além disso, forneça um método chamado
“getInvoiceAmount” que calcula o valor da fatura (isso é,
multiplica a quantidade pelo preço por item) e depois
retorna o valor como um double.
*/

namespace Program
{
    public class NotaFiscal
    {
        public int Numero;
        public string Descricao;
        public int Quantidade;
        public double Preco;
        public NotaFiscal(int numero, string descricao, int quantidade,
        double preco)
        {
            Numero = numero;
            Descricao = descricao;
            Quantidade = quantidade;
            Preco = preco;
        }
        public double GetInvoiceAmount()
        {
            return Quantidade * Preco;
        }
    }
    public class Program
    {
        static void Main()
        {
            int numero = 1;
            string descricao = "Teclado";
            int quantidade = 3;
            double preco = 720.50;
            NotaFiscal nota = new NotaFiscal(numero, descricao,
            quantidade, preco);
            double valorDaFatura = nota.GetInvoiceAmount();
            Console.WriteLine(valorDaFatura);
        }
    }
}

/*
Implemente uma classe “Pessoa” que possua como atributos nome,
idade, peso (em quilogramas) e altura (em metros). Faça com que 
os dados sejam inicializados através do construtor da classe. 
Adicione métodos para ler e alterar cada um dos atributos em separado.
*/

namespace Program
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        private float _peso;
        private float _altura;
        public Pessoa(string nome, int idade, float peso, float altura)
        {
            _nome = nome;
            _idade = idade;
            _peso = peso;
            _altura = altura;
        }
        public void AlterarNome(string nome)
        {
            _nome = nome;
        }
        public void LerNome()
        {
            Console.WriteLine(_nome);
        }
        public void AlterarIdade(int idade)
        {
            _idade = idade;
        }
        public void LerIdade()
        {
            Console.WriteLine(_idade);
        }
        public void AlterarPeso(float peso)
        {
            _peso = _peso;
        }
        public void LerPeso()
        {
            Console.WriteLine(_peso);
        }
        public void AlterarAltura(float altura)
        {
            _altura = altura;
        }
        public void LerAltura()
        {
            Console.WriteLine(_altura);
        }
    }
    public class Program
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa("Guilherme", 21, 64.3f, 1.80f);
            pessoa.LerNome();
            pessoa.LerIdade();
            pessoa.LerPeso();
            pessoa.LerAltura();
            Console.WriteLine();
            pessoa.AlterarNome("João");
            pessoa.AlterarIdade(19);
            pessoa.AlterarPeso(77.3f);
            pessoa.AlterarAltura(1.73f);
            pessoa.LerNome();
            pessoa.LerIdade();
            pessoa.LerPeso();
            pessoa.LerAltura();
        }
    }
}

/*
Altere a classe “Pessoa” do exercício anterior de modo que ela seja capaz
de calcular o Índice de Massa Corporal (IMC). O cálculo é feito através da
fórmula IMC = peso/altura2. Adicionalmente, implemente um método que
informa a faixa de categoria do IMC que a pessoa se encontra, utilizando a
seguinte tabela:

    Peso          Categoria
--------------------------------
   < 20         Abaixo do peso
 > 20 e <=25     Peso normal
 >25 e <= 30      Sobrepeso
> 30 e <=35    Obesidade grau I
> 35 e <=40    Obesidade grau II
   > 40        Obesidade grau III
--------------------------------
*/

namespace Program
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        private float _peso;
        private float _altura;
        private float _IMC;
        public Pessoa(string nome, int idade, float peso, float altura)
        {
            _nome = nome;
            _idade = idade;
            _peso = peso;
            _altura = altura;
            _IMC = _peso / (_altura * _altura);
        }
        public void AlterarNome(string nome)
        {
            _nome = nome;
        }
        public void LerNome()
        {
            Console.WriteLine(_nome);
        }
        public void AlterarIdade(int idade)
        {
            _idade = idade;
        }
        public void LerIdade()
        {
            Console.WriteLine(_idade);
        }
        public void AlterarPeso(float peso)
        {
            _peso = peso;
        }
        public void LerPeso()
        {
            Console.WriteLine(_peso);
        }
        public void AlterarAltura(float altura)
        {
            _altura = altura;
        }
        public void LerAltura()
        {
            Console.WriteLine(_altura);
        }
        public void InformarCategoriaIMC()
        {
            string categoria = "";
            if (_IMC > 40) categoria = "Obesidade grau III";
            else if (_IMC > 35) categoria = "Obesidade grau II";
            else if (_IMC > 30) categoria = "Obesidade grau I";
            else if (_IMC > 25) categoria = "Sobrepeso";
            else if (_IMC > 20) categoria = "Peso normal";
            else categoria = "Abaixo do Peso";
            Console.WriteLine(categoria);
        }
    }
    public class Program
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa("Guilherme", 21, 64.3f, 1.80f);
            pessoa.LerNome();
            pessoa.LerIdade();
            pessoa.LerPeso();
            pessoa.LerAltura();
            pessoa.InformarCategoriaIMC();
            Console.WriteLine();
            pessoa.AlterarNome("João");
            pessoa.AlterarIdade(19);
            pessoa.AlterarPeso(87.3f);
            pessoa.AlterarAltura(1.73f);
            pessoa.LerNome();
            pessoa.LerIdade();
            pessoa.LerPeso();
            pessoa.LerAltura();
            pessoa.InformarCategoriaIMC();
        }
    }
}

/*
Escreva um programa que leia o valor de um capital investido e a taxa 
de juros mensais. Supondo que essa taxa seja constante ao longo de um ano, 
apresente o valor do investimento ao final de cada mês durante um ano.
*/

namespace Program
{
    class Investimento
    {
        private double _valor;
        private float _taxaDeJuros;
        public Investimento(double valor, float taxadeJuros)
        {
            _valor = valor;
            _taxaDeJuros = (taxadeJuros / 100f);
        }
        public void AcompanharInvestimento()
        {
            for (int i = 0; i < 12; i++)
            {
                _valor += _valor * _taxaDeJuros;
                Console.WriteLine("Valor no {0}º mês: {1}", i + 1,
                _valor);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Investimento investimento = new Investimento(1000.00,
            15.3f);
            investimento.AcompanharInvestimento();
        }
    }
}

/* Resolver o problema 2787 da Plataforma BeeCrowd. */

namespace Program
{
    class Xadrez
    {
        private int _linhas;
        private int _colunas;
        public int[,] Tabuleiro;
        public Xadrez(int linhas, int colunas)
        {
            _linhas = linhas;
            _colunas = colunas;
            Tabuleiro = new int[linhas, colunas];
            GerarTabuleiro();
        }
        public void GerarTabuleiro()
        {
            int init = 1;
            int tab = init;
            for (int linha = 0, coluna = 0; linha < Tabuleiro.GetLength
            (0); linha++)
            {
                Tabuleiro[linha, coluna] = init;
                if (init == 1) tab = 0;
                else if (init == 0) tab = 1;
                for (coluna = 1; coluna < Tabuleiro.GetLength(1);
                coluna++)
                {
                    Tabuleiro[linha, coluna] = tab;
                    if (tab == 1) tab = 0;
                    else if (tab == 0) tab = 1;
                }
                if (init == 1) init = 0;
                else if (init == 0) init = 1;
                coluna = 0;
            }
        }
        public void ExibirUltimaCasa()
        {
            Console.WriteLine(Tabuleiro[_linhas - 1, _colunas - 1]);
        }
    }
    class Program
    {
        static void Main()
        {
            int linhas = 6;
            int colunas = 9;
            Xadrez xadrez = new Xadrez(linhas, colunas);
            xadrez.ExibirUltimaCasa();
        }
    }
}

/* // Solução aceita na plataforma:

int l = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int[,] matriz = new int[l, c];

int init = 1;
int tab = init;

for (int linha = 0, coluna = 0; linha < matriz.GetLength(0); linha++)
{
    matriz[linha, coluna] = init;
    if (init == 1) tab = 0;
    else if (init == 0) tab = 1;
    for (coluna = 1; coluna < matriz.GetLength(1); coluna++)
    {
        matriz[linha, coluna] = tab;
        if (tab == 1) tab = 0;
        else if (tab == 0) tab = 1;
    }
    if (init == 1) init = 0;
    else if (init == 0) init = 1;
    coluna = 0;
}

for (int linha = 0; linha < matriz.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        Console.Write(matriz[linha, coluna]);
    }
    Console.WriteLine();
}

Console.WriteLine(matriz[l - 1, c - 1]); */