## Método
- Um método é um *bloco de código* que contém uma série de *instruções*.
- Um programa faz com que as instruções sejam executadas chamando o método e especificando *os argumentos* de métodos necessários.
- Na linguagem C#, todas as instruções executadas são realizadas no contexto de um *método* que são declarados em uma *classe*.
![[Pasted image 20241226143244.png]]
### Assinatura do método
Permite identificar um método de forma única:
![[Pasted image 20241226143440.png]]
### Métodos - Parâmetros opcionais
- No C# os métodos podem conter parâmetros obrigatórios e também parâmetros opcionais.
- Um método com parâmetros opcionais pode ser chamado sem a obrigação de passar argumentos para esses parâmetros.

**Como usar e declarar parâmetros opcionais?**
1 - Devem ser definidos após os parâmetros normais.
2 - Devem possuir um valor padrão constante.

![[Pasted image 20241208175727.png]]
### Métodos - Argumentos Nomeados
![[Pasted image 20241208180023.png]]
### Métodos de extensão
- Permitem que você adiciona uma nova funcionalidade a um tipo existente sem ter que criar um novo tipo derivado; dessa forma a funcionalidade se comporta como um outro membro do tipo.
- Podemos criar um novo método em um tipo que pode ser chamado como se ele fosse um método de instância desse tipo.

**Essa é uma forma de aplicar o principio aberto/fechado (OCP) que diz:
'Você deve ser capaz de estender um comportamento de uma classe, sem modificá-la'**

- São definidos como *estáticos*, mas são chamados usando a sintaxe do *método de instância*
- Seu primeiro parâmetro especifica em que tipo o método opera e o parâmetro é precedido pelo modificador *this*.
- Estarão no escopo somente quando você importar o *namespace* para o seu código-fonte com uma diretiva *using*.
```
public static string MetodoExtensao(this string valor)
{
	///
}
```

**Implementação:**
- Definir uma classe estática para conter o método de extensão;
- Implementar o método de extensão como um método estático com pelo menos a mesma visibilidade que a classe que a contém;
- O primeiro parâmetro do método especifica o tipo no qual o método opera. Ele deve ser precedido pelo modificador **Palavra THIS**.
- No código de chamada do método, adicione uma diretiva *using* para especificar o namespace que contém a classe do método de extensão.
- Chame os métodos como se fossem métodos de instância no tipo
![[Pasted image 20241208180946.png]]
![[Pasted image 20241208180922.png]] 
## Sobrecarga

- É um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porém com diferentes parâmetros.
![[Pasted image 20241208175337.png]]
 
### Proposta de melhoria

Ainda usando de exemplo o nosso [[Problema-produto.canvas|Problema-produto]]

Vamos criar um construtor opcional, o qual recebe apenas nome e preço do produto. A quantidade em estoque deste novo produto por padrão, deverá então ser iniciada com o valor zero:

- Nota: É possível também incluir um construtor padrão (sem parâmetros)

```
class Produto {
	public string Nome;
	public double Preco;
	public int Quantidade;

	public Produto(string nome, double preco, int quantidade)
	{
		Nome = nome;
		Preco = preco;
		Quantidade = quantidade;
	}

	//sobrecarga
	public Produto (string nome, double preco)
	{
		Nome = nome;
		Preco = preco;
		Quantidade = 5; 
	}
	(resto do código...)
}
```
### Palavra THIS
É uma referência do próprio objeto
Usos comuns:
- Diferenciar atributos de variáveis locais (Java)
- Referenciar outro construtor em um construtor
- Passar o próprio objeto como argumento na chamada de um método ou construtor
![[Pasted image 20241202173554.png]]

![[Pasted image 20241202173705.png]]

![[Pasted image 20241202173911.png]]

### Encapsulamento

- É um princípio que consiste em esconder detalhes de implementação de um componente, expondo apenas operações seguras e que o mantenha em um estado consistente.
- Regra de ouro: o objeto deve sempre estar em um estado consistente, e a própria classe deve garantir isso.

Nota: implementação manual não é tão comum no C# devido as properties.
![[Pasted image 20241202174740.png]]
![[Pasted image 20241202175601.png]]
#### Properties
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

- São definições de métodos encapsulados, porém expondo uma sintaxe similar à de atributos e não de métodos
- Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular. As propriedades podem ser usadas como se fossem atributos públicos, mas na verdade elas são métodos especiais chamados "acessadores". Isso permite que os dados sejam acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade dos métodos.
```
class Produto {
	private string _nome;
	private double _preco;
	private int _quantidade;

	public Produto(string nome, double preco, int quantidade)
	{
		_nome = nome;
		_preco = preco;
		_quantidade = quantidade;
	}
    
	public string Nome 
	{
		get { return _nome }
		set {
			if (value != null )
				_nome = value; 
			}	
	}

	public double Preco
	{
		get { return _preco }
	}
	
}
```

#### Auto Properties
- É uma forma simplificada de se declarar propriedades que não necessitam de lógicas particulares para as operações de get e set.
```
	public double Preco { get; private set; }
```
### Encapsulamento e Modelos de Domínio

- Como já dito, encapsular é ocultar os detalhes da implementação de um objeto de forma manter o seu estado consistente;
- O modelo de domínio é uma representação de classes conceituais a partir do mundo real;
- Modelar o domínio - entender a descrição do problema do projeto, converter os requisitos em componentes de software de uma solução.

Verifique a documentação [[Modelo de Domínio]]
#### Modificadores de acesso:
![[Pasted image 20241203133937.png]]

## Ordem sugerida para implementações de membros em uma classe
- Atributos privados;
- Propriedades auto implementadas
- Construtores
- Propriedades customizadas
- Outros métodos da classe

