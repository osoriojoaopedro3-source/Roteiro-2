namespace Exercicio1_Produto
{
    public class Produto
    {
        // Atributos privados: só podem ser acessados de dentro da classe
        private string nome;
        private decimal preco;

        public Produto(string nome, decimal preco)
        {
            this.nome = nome;

            if (preco < 0)
            {
                Console.WriteLine("Erro: o preço não pode ser negativo. Preço definido como 0.");
                this.preco = 0;
            }
            else
            {
                this.preco = preco;
            }
        }

        public string ObterNome()
        {
            return nome;
        }

        public decimal ObterPreco()
        {
            return preco;
        }

        public void AlterarPreco(decimal novoPreco)
        {
            if (novoPreco < 0)
            {
                Console.WriteLine($"Erro: o preço não pode ser negativo ({novoPreco}). Alteração cancelada.");
                return;
            }

            preco = novoPreco;
            Console.WriteLine($"Preço alterado para {preco:C}.");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Produto: {nome} | Preço: {preco:C}");
        }
    }
}
