## Restrições para nomes de variáveis
- Não pode começar com dígito: use uma letra ou _ 
- Não usar acentos ou til 
- Não pode ter espaço em branco 
- Sugestão: use nomes que tenham um significado
![[Pasted image 20241111205410.png]]
## Convenções 
- Camel Case: lastName (parâmetros de métodos, variáveis dentro de métodos) 
- Pascal Case: LastName (namespaces, classe, properties e métodos) 
- Padrão _lastName (atributos "internos" da classe)

```
namespace Curso 
{ 
	class ContaBancaria 
	{ 
		public string Titular { get; set; } 
		private double _saldo; 
		
		public void Deposito(double quantia) 
		{ 
			_saldo += quantia; 
		} 
		
		public double GetSaldo() 
		{ 
			return _saldo; 
		} 
	} 
}
```