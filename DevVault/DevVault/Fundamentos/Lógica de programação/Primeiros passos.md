
![[obs.png]]

## Algoritmo - 
 Sequência finita de instruções para se resolver um problema;

## Automação - 
 Consiste em utilizar máquina(s) para executar o procedimento desejado de forma 
 automática ou semiautomática

Programa de computador são algoritmos executados pelo computador -> O computador é uma máquina que automatiza a execução de algoritmos.
 - Processamento de dados
 - Cálculos
-----------------------------------------------------------------------------------
Para se fazer um programa:
 - Uma linguagem de programação
 - Uma IDE
 - Um compilador
 - Um gerador de código ou máquina virtual
-----------------------------------------------------------------------------------
## Linguagem de programação: 
Conjunto de refras léxicas (ortograficas) e sintáticas (gramaticais) para se escrever programas.

Truncar = Arrendondar 

Casting = Conversão explicita de um tipo para outro;

## Vetores: 

Corresponde a uma coleção de dados de tamanho fixo, indexada, unidimensional e homogenea.
- Indexada: Os elementos são acessados por meio de indices;
- Unidimencional: Uma dimensão;
- Homogenea: todos os dados são do mesmo tipo

```
string[] v;
v = new string[5];
v = [Maria, João, Carlos, Ana, Joaquim];
v[0] = Maria;
v[1] = João;
...
```

## Listas

- Listas é uma estrutura de dados:
	- Homogênea
	- Ordenada
	- Inicia vazia, e seus elementos são alocados sob demanda
	- Cada elemento ocupa um "nó" (ou nodo) da lista
- Vantagens:
	- Tamanho variável
	- Facilidade para se realizar inserções e deleções
- Desvantagens:
	- Acesso sequencial aos elementos
```
List<string> list = new List<string>();
List<string> list2 = new List<string> {"maria", "alex"};

//O Add sempre adiciona ao final da lista
list.Add("maria");
list.Add("alex");

//O Insert você escolhe onde alocar
list.Insert(2, "Marco");

//Tamanho da lista
list.count();

//Encontrar primeiro ou ultimo elemento da lista (Find ou FindLast)
//Expressão lamba predicado: "Eu quero o objeto x tal que x na posição 0 seja igual ao caracter A maiusculo"
string s1 = list.Find(x => x[0] == 'A');

//Encontrar posição (FindIndex ou FindLastIndex)
string s2 = list.FindIndex(x => x[0] == 'A');

//Filtrar a lista com base em um predicado (FindAll)
List<string> s3 = list.FindAll(x => x.Length == 5);

//Remover elementos da lista 
list.Remove("Alex");
list.RemoveAll(x => x[0] == 'M');
list.RemoveAt(3);
list.RemoveRange(2, 2);
```

## Matrizes
- Em programação, "matriz" é o nome dado a arranjos bidimensionais;
```
// 2 linhas e 3 colunas
double[,] mat = new double[2,3];

//Elementos no total
mat.Length();

//Quantidade de linhas
mat.Rank();

//Tamanho da primeira dimensão
mat.GetLength(0);
```


## O que foi estudado:
- [[Variáveis e tipos básicos]]
- [[Restrições e convenções para nomes]]
- [[Conversão implícita e casting]]
- [[Operadores]]
- [[Funções]]
- [[Estruturas]]
