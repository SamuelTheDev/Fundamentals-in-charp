### Construtor
- É uma operação especial da classe, que executa no momento da instanciação do objeto
- Usos comuns:
	- Iniciar valores dos atributos
	- Permitir ou obrigar que o objeto receba dados / dependências no momento de sua instanciação (injeção de dependência)
- Se um construtor customizado não for especificado, a classe disponibiliza o construtor padrão:
	- Produto p = new Produto();
- É possível especificar mais de um construtor na mesma classe (sobrecarga)

#### Proposta de melhoria

Vamos seguir com uma proposta de melhoria com o uso de construtor para o seguinte exemplo: [[Problema-produto.canvas|Problema-produto]]

Quando executamos o comando abaixo, instanciamos um produto "p" com seus atributos "vazios":
![[Pasted image 20241129132349.png]]
Entretanto, faz sentido um produto que não tem nome? Faz sentido um produto que não tem preço?

Com o intuito de evitar a existência de produtos sem nome e sem preço, é possível fazer com que seja "obrigatória" a instanciação desses valores?

É aí que nós definimos um construtor:
```
class Produto {
	public string Nome;
	public double Preco;
	public int Quantidade;

	//construtor
	public Produto(string nome, double preco, int quantidade)
	{
		Nome = nome;
		Preco = preco;
		Quantidade = quantidade;
	}
	(resto do código...)
}
```

Agora ao instânciar:
```
Produto p = new Produto("TV", 500.0, 10);
```

