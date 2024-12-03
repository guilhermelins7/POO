using System;

int[,] conteiners = new int[5, 5]
{
    {1, 1, 0, 2, 2 },
    {1, 1, 0, 0, 2 },
    {0, 1, 0, 0, 0 },
    {0, 0, 0, 2, 2 },
    {3, 3, 3, 0, 2 }
};

bool[,] conteinerChecado = new bool[conteiners.GetLength(0), conteiners.GetLength(1)];
int[] conteiner = new int[] {1, 2, 3};
string coordenadas = "";
int blocos = 0;

Console.WriteLine($"Cargas atuais no porto:");
ExibirConteiners(conteiners);

Console.WriteLine("\nBlocos Encontrados:");

for (int ilinha = 0; ilinha < conteiners.GetLength(0); ilinha++)
{
    for (int icoluna = 0; icoluna < conteiners.GetLength(1); icoluna++)
    {
        if (!conteinerChecado[ilinha, icoluna] // Conteiner não foi visitado
            && conteiners[ilinha, icoluna] != 0 // indice possui um contêiner
            )
        {
            blocos++;
            Console.Write($"Bloco {blocos}: Tipo {conteiners[ilinha, icoluna]}, ");
            int quantidade = ExplorarDirecoes(conteiners, conteinerChecado, ilinha, icoluna, conteiners[ilinha, icoluna], ref coordenadas);
            Console.WriteLine($"Coordenadas: [ {coordenadas}], Quantidade: {quantidade}");
            coordenadas = "";
        }
    }
}

Console.WriteLine("\nConteiners reordenados:");

conteiners = OrdernarConteiners(conteiners);
ExibirConteiners(conteiners);

static int ExplorarDirecoes(int[,] conteiners, bool[,] conteinerChecado, int ilinha, int icoluna, int tipo, ref string coordenadas)
{
    int linhas = conteiners.GetLength(0);
    int colunas = conteiners.GetLength(1);

    // Caso de encerramentO:
    if (ilinha < 0 || ilinha >= linhas || // Limites linhas
        icoluna < 0 || icoluna >= colunas || // Limites Colunas
        conteinerChecado[ilinha, icoluna] || conteiners[ilinha, icoluna] != tipo)
        return 0;

    conteinerChecado[ilinha, icoluna] = true;
    coordenadas += $"({ilinha},{icoluna}) ";

    // Soma 1 para a célula atual
    int quantidade = 1;

    // continua explorando em todas as direções
    quantidade += ExplorarDirecoes(conteiners, conteinerChecado, ilinha - 1, icoluna, tipo, ref coordenadas); // Cima
    quantidade += ExplorarDirecoes(conteiners, conteinerChecado, ilinha + 1, icoluna, tipo, ref coordenadas); // Baixo
    quantidade += ExplorarDirecoes(conteiners, conteinerChecado, ilinha, icoluna - 1, tipo, ref coordenadas); // Esquerda
    quantidade += ExplorarDirecoes(conteiners, conteinerChecado, ilinha, icoluna + 1, tipo, ref coordenadas); // Direita

    return quantidade;
}

static int[,] OrdernarConteiners(int[,] conteiners)
{
    int linhas = conteiners.GetLength(0);
    int colunas = conteiners.GetLength(1);

    int[] array = new int[linhas * colunas];
    int indice = 0;

    for(int linha = 0; linha < linhas; linha++) // passar valores da matriz para vetor
    {
        for(int coluna = 0; coluna < colunas; coluna++)
        {
            array[indice] = conteiners[linha, coluna];
            indice++;
        }
    }

    for (int passagens = 0; passagens < array.Length - 1; passagens++) // Ordenar Array
    {
        for (indice = 0; indice < array.Length - 1 - passagens; indice++)
        {
            // Garantir que indice 0 seja jogado para o fim do array.
            if (array[indice] == 0) array[indice] = 9;
            else if (array[indice + 1] == 0) array[indice + 1] = 9; // Garantir que indice 0 seja jogado para o fim do array.

            if (array[indice] > array[indice + 1])
            {
                int temporario = array[indice];
                array[indice] = array[indice + 1];
                array[indice + 1] = temporario;
            }
        }
    }


    // repassar valores da do vetor ordenado para matriz:
    indice = 0;

    for (int linha = 0; linha < linhas; linha++)
    {
        for (int coluna = 0; coluna < colunas; coluna++)
        {
            if (array[indice] == 9) array[indice] = 0; // Reverter troca feita ao Ordenar Array, valores 0 ficam no fim do vetor
            conteiners[linha, coluna] = array[indice];
            indice++;
        }
    }

    return conteiners;
}

static void ExibirConteiners(int[,] conteiners)
{
    for (int linha = 0; linha < conteiners.GetLength(0); linha++)
    {
        for(int coluna = 0; coluna < conteiners.GetLength(1); coluna++)
        {
            Console.Write(conteiners[linha, coluna]);
        }
        Console.WriteLine();
    }
}