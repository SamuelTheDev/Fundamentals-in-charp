- É um recurso de C# para que dados de tipo valor (structs) possam receber o valor null.
- Uso comun:
	- Campos de bancos de dados que podem valer nulo (data de nascimento, algum valor numérico, etc.).
	- Dados e parâmetros opcionais.
```
double? x = null;
double? y = 10.0;
```
A interrogação define o struct como Nullable.
## Operador de coalescência nula

```
double? x = null;

double y = x ?? 0.0;
```
As duas interrogações verificam se o valor atribuído é nulo. Caso não ele joga o valor da direita.