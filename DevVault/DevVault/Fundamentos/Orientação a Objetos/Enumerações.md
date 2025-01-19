- É um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas
- Palavra chave em C#: enum
	- Nota: enum é um tipo valor
- Vantagem: melhor semântica, código mais legível e auxiliado pelo compilador

Diagrama de máquina de estados (State machine):
![[Pasted image 20250119155143.png]]
```
enum OrderStatus : int {
	PendingPayment = 0,
	Processing = 1,
	Shipped = 2,
	Deliverd = 3
}

class Order {
	public int Id { get; set; }
	public DateTime Moment { get; set; }
	public OrderStatus Status { get; set; }
}
```
