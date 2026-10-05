# Roteiro 2 — Encapsulamento em C#

Cada exercício é um projeto de console independente (.NET 8):

| Pasta | Classe | Executar |
|---|---|---|
| `Exercicio1_Produto` | `Produto` (nome, preço não negativo) | `dotnet run --project Exercicio1_Produto` |
| `Exercicio2_Carro` | `Carro` (velocidade nunca abaixo de 0) | `dotnet run --project Exercicio2_Carro` |
| `Exercicio3_Elevador` | `Elevador` (andar entre 0 e o total de andares) | `dotnet run --project Exercicio3_Elevador` |

Em todas as classes os atributos são `private`, então só podem ser alterados pelos
métodos públicos da própria classe. Uma linha como `p.preco = -200;` não compila
(erro CS0122: inacessível devido ao seu nível de proteção).
