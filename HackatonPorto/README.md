# Hackaton - Gerenciamento de Carga em Portos

## Descrição do Projeto

Este projeto foi desenvolvido para um hackathon com o objetivo de otimizar o armazenamento e carregamento de contêineres em um terminal portuário. O terminal é organizado em um layout de grid, onde cada célula da matriz representa um espaço de armazenamento para os contêineres. O sistema identifica, agrupa e reorganiza os blocos de contêineres de maneira contígua para facilitar o processo de transporte.

## Funcionalidades

1. **Identificação de Blocos Contíguos:**
   - O sistema identifica todos os blocos de contêineres do mesmo tipo que estão armazenados de forma adjacente, considerando apenas conexões na horizontal e vertical (não diagonais).
   
2. **Cálculo de Quantidade por Bloco:**
   - Para cada bloco identificado, o sistema calcula a quantidade total de contêineres presentes.

3. **Reordenação para Otimização:**
   - O sistema propõe uma nova disposição dos contêineres na matriz para agrupar os contêineres do mesmo tipo, maximizando o tamanho dos blocos contíguos.

## Exemplo de matriz 5x5 utilizado no projeto:

### Entrada:
```csharp
int[,] conteiners = new int[5, 5]
{
    {1, 1, 0, 2, 2 },
    {1, 1, 0, 0, 2 },
    {0, 1, 0, 0, 0 },
    {0, 0, 0, 2, 2 },
    {3, 3, 3, 0, 2 }
};
```

### Saída:

**Blocos Encontrados:**

- **Bloco 1:** Tipo 1, Coordenadas: [ (0,0) (1,0) (1,1) (0,1) (2,1) ], Quantidade: 5
- **Bloco 2:** Tipo 2, Coordenadas: [ (0,3) (0,4) (1,4) ], Quantidade: 3
- **Bloco 3:** Tipo 2, Coordenadas: [ (3,3) (3,4) (4,4) ], Quantidade: 3
- **Bloco 3:** Tipo 3, Coordenadas: [ (4,0) (4,1) (4,2) ], Quantidade: 3

**Matriz Reordenada:**

```
11111
22222
23330
00000
00000
```

## Estrutura do Código

- **Main:** O código inicializa uma matriz representando o terminal portuário e chama as funções necessárias para identificar os blocos de contêineres, calcular a quantidade por bloco e reordenar a matriz.
- **ExplorarDirecoes:** Função recursiva que verifica todos os contêineres adjacentes de um determinado tipo para formar um bloco.
- **OrdernarConteiners:** Função responsável por reorganizar os contêineres na matriz para maximizar o tamanho dos blocos de contêineres do mesmo tipo.
- **ExibirConteiners:** Função auxiliar para exibir a matriz de contêineres no console.

## Como Executar

Para executar este projeto, você pode fazer o download desta parte específica do repositório. Em seguida, abra-o em uma IDE de sua preferência. O projeto foi desenvolvido usando **Visual Studio 2022**, então recomendo o uso dessa versão para garantir compatibilidade.

### Passos:

1. Faça o download da pasta correspondente ao projeto dentro do repositório.
   
2. Abra a pasta do projeto na sua IDE (como **Visual Studio 2022**):
   - No Visual Studio, vá em **Arquivo > Abrir > Projeto/Solução** e selecione o arquivo `.sln` do projeto.

3. Compile e execute o projeto diretamente pela IDE.

## Requisitos

- .NET SDK 8.0



