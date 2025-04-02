## Categorias de classes

- Em um sistema orientado a objetos, de modo geral "tudo" é objeto.
- Por questões de design tais como organização, flexibilidade, reuso, delegação, etc., há várias categorias de classes:
![[Pasted image 20250119162529.png]]

### Entities

- Representa as entidades de negócio que podem ser associadas entre si as quais representam o domínio do sistema:
  ![[Pasted image 20250119162843.png]]

### Repository

- Objeto responsável por fazer operações com o banco de dados;
### Services

- Representam as funcionalidades principais do sistema. Basicamente é aonde fica encapsulada toda a regra de negócio:
- O exemplo abaixo o pedido está associado ao *Repository* 
  ![[Pasted image 20250119163025.png]]

