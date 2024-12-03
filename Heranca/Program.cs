/*
Crie uma classe chamada Ingresso que possui um valor em reais e um método imprimeValor().
Crie uma classe VIP, que herda Ingresso e possui um valor adicional.
Crie um método que retorne o valor do ingresso VIP (com o adicional incluído).
Crie uma classe Normal, que herda Ingresso e possui um método que imprime: "Ingresso Normal".
Crie uma classe CamaroteInferior (que possui a localização do ingresso e métodos para acessar
e imprimir esta localização) e uma classe CamaroteSuperior, que é mais cara (possui valor adicional).
Esta última possui um método para retornar o valor do ingresso. Ambas as classes herdam a classe VIP.
*/

namespace App
{
    class Ingresso
    {
        public float Valor = 10.0f; // valor padrão.
        public void ImprimeValor()
        {
            Console.WriteLine(Valor);
        }
    }
    class VIP : Ingresso
    {
        public float ValorAdicional { get; set; }
        public double ValorIngressoVip()
        {
            ValorAdicional = 1.25f; // Valor exemplo +25%
            return Valor * ValorAdicional;
        }
    }
    class Normal : Ingresso
    {
        public void ImprimeIngressoNormal()
        {
            Console.WriteLine(Valor);
        }
    }
    class CamaroteInferior : VIP
    {
        private string _localizacaoIngresso;
        public CamaroteInferior(string localizacaoIngresso)
        {
            _localizacaoIngresso = localizacaoIngresso;
        }
        public void ExibirLocalizacaoIngresso()
        {
            Console.WriteLine(_localizacaoIngresso);
        }
        public double ValorIngressoCamaroteInferior()
        {
            ValorAdicional = 1.5f; // Valor exemplo +50%
            return Valor * ValorAdicional;
        }
    }
    class CamaroteSuperior : VIP
    {
        public double ValorIngressoCamaroteSuperior()
        {
            ValorAdicional = 1.75f; // Valor exemplo +75%
            return Valor * ValorAdicional;
        }
    }
    class Program
    {
        static void Main()
        {
            int tipoIngresso;

            do
            {
                Console.WriteLine(
                "Informe o tipo de ingresso desejado:" +
                "\n 1 - Ingresso Normal;" +
                "\n 2 - Ingresso VIP;" +
                "\n 3 - Camarote Inferior;" +
                "\n 4 - Camarote Superior." +
                "\n 5 - Finalizar");

                tipoIngresso = int.Parse(Console.ReadLine());

                switch (tipoIngresso)
                {
                    case 1:
                        Normal ingresssoNormal = new Normal();
                        Console.Write("Valor do ingresso normal: ");
                        ingresssoNormal.ImprimeIngressoNormal();
                        break;
                    case 2:
                        VIP ingressoVip = new VIP();
                        Console.Write("Valor do ingresso VIP : {0}", ingressoVip.ValorIngressoVip());
                        break;
                    case 3:
                        CamaroteInferior ingressoCamaroteInferior = new
                        CamaroteInferior("cadeira B, fileira A");
                        Console.Write($"Localização do ingresso: ");
                        ingressoCamaroteInferior.ExibirLocalizacaoIngresso();
                        Console.WriteLine("Valor do ingresso CamaroteInferior: {0}", ingressoCamaroteInferior.ValorIngressoCamaroteInferior());

                        break;
                    case 4:
                        CamaroteSuperior camaroteSuperior = new
                        CamaroteSuperior();
                        Console.Write("Valor do ingresso Camaronte Superior: {0}", camaroteSuperior.ValorIngressoCamaroteSuperior());
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Valor Inválido.");
                        break;
                }
                Console.WriteLine("\nDigite qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            } while (tipoIngresso < 5 && tipoIngresso > 0);
        }
    }
}

/*
Crie a classe Imovel, que possui um endereço e um preço.
Crie uma classe Novo, que herda Imovel e possui um adicional no preço.
Crie métodos de acesso e impressão deste valor adicional. Crie uma
classe Velho, que herda Imovel e possui um desconto no preço. Crie
métodos de acesso e impressão para este desconto.
*/

namespace App
{
    class Imovel
    {
        public string Endereco { get; set; }
        public float Preco = 10f;
        public void ConstrutorPadrao(string endereco)
        {
            Endereco = endereco;
        }
    }
    class Novo : Imovel
    {
        public double Valor;
        public void ExibirValor()
        {
            Console.WriteLine(Preco * 1.25); // Preco adicional de 25% exemplo.
        }
    }
    class Velho : Imovel
    {
        public void ExibirValor()
        {
            Console.WriteLine(Preco * 0.75); // Desconto de 25% exemplo.
        }
    }
    class Program
    {
        static void Main()
        {
            int tipoImovel;
            do
            {
                Console.WriteLine("Informe o tipo de imóvel que deseja consultar: " +
                "\n1 - Imóvel Novo" +
                "\n2 - Imóvel velho" +
                "\n3 - Finalizar.");
                tipoImovel = int.Parse(Console.ReadLine());

                switch (tipoImovel)
                {
                    case 1:
                        Novo imovelNovo = new Novo();
                        imovelNovo.ConstrutorPadrao("Rua Endereço novo, numero 02");

                        Console.WriteLine("Valor do imovel: ");
                        imovelNovo.ExibirValor();
                        Console.WriteLine("Endereço do imovel: {0}", imovelNovo.Endereco);
                        break;
                    case 2:
                        Velho imovelVelho = new Velho();
                        imovelVelho.ConstrutorPadrao("Rua Endereço velho, numero 01");

                        Console.WriteLine("Valor do imovel: ");
                        imovelVelho.ExibirValor();

                        Console.WriteLine("Endereço do imovel: {0}", imovelVelho.Endereco);
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Valor inválido.");
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("\nDigite qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            } while (tipoImovel < 3 && tipoImovel > 0);
        }
    }
}