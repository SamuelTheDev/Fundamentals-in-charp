O domínio ==é o campo de conhecimento ou atividade que o software será desenvolvido para resolver==. É o coração do projeto e o foco da abordagem arquitetural do DDD. 

O domínio é fundamental para o DDD, pois todas as decisões de design e desenvolvimento devem ser guiadas por ele. Entender o domínio é essencial para criar um software que atenda às necessidades do negócio.
## Modelo de Domínio Anêmico
![[Pasted image 20241208174152.png]]
![[Pasted image 20241208181452.png]]
![[Pasted image 20241208181623.png]]
Exemplo de modelo de domínio anêmico:
- Somente dados
- Sem comportamentos
- Sem validações
- Sem lógica
- Sem regras de negócio nem cálculos

Como evitar o modelo Anêmico?
1 - Criar um construtor parametrizado (com validação):
![[Pasted image 20241208181857.png]]
2 -  Definir as propriedades set como private e adicionar a lógica de validação:
![[Pasted image 20241208181958.png]]
![[Pasted image 20241208182657.png]]

## Modelo de Domínio Rico
![[Pasted image 20241208174318.png]]
### Validação do modelo Rico
Um modelo de domínio rico **é um modelo que esta mais ajustado à filosofia DDD, onde temos uma classe definida com comportamentos e não apenas com gets e sets**. Em um modelo de domínio rico as entidades precisam implementar o comportamento, além de implementar os atributos de dados.
![[Pasted image 20241208174426.png]]
![[Pasted image 20241208174459.png]]
Para melhorar a solução de validação do modelo rico, implementar o padrão Notification Pattern (Martin Fowler)

### Quando Usar Cada Abordagem de validação no domínio rico

1. **Validações no Construtor**:
    
    - Use quando o objeto for **imutável** ou quando todas as propriedades são obrigatórias no momento da criação.
    - Ideal para **entidades com invariantes fortes**, como IDs que nunca mudam ou regras que dependem de múltiplas propriedades.
2. **Validações no `set`**:
    
    - Use quando o objeto precisa ser **mutável** ou quando a criação pode ser **incremental** (e.g., preenchimento de dados em um formulário ou ORM).
    - Útil em **domínios mais dinâmicos**, onde propriedades podem ser alteradas com frequência.

---

### **Abordagem Combinada**

Em alguns casos, você pode combinar as duas abordagens:

- Validações que garantem invariantes **globais** (dependem de várias propriedades) podem ser feitas no construtor.
- Validações específicas de propriedades podem ser feitas nos respectivos `setters`.
```
public class Cliente
{
    public string Nome { get; }
    private string _email;

    public string Email
    {
        get => _email;
        set
        {
            if (!value.Contains("@"))
                throw new ArgumentException("Email inválido.");
            _email = value;
        }
    }

    public Cliente(string nome, string email)
    {
        if (string.IsNullOrWhiteSpace(nome)) 
            throw new ArgumentException("Nome é obrigatório.");
        
        Nome = nome;
        Email = email; // Valida pelo setter
    }
}

```
