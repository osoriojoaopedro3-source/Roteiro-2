using System.Globalization;

namespace Exercicio1_Produto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

            Produto p = new Produto("Celular", 1500);
            p.ExibirDetalhes();
            p.AlterarPreco(-200); // Deve exibir uma mensagem de erro
            p.AlterarPreco(1200);
            p.ExibirDetalhes();

            // p.preco = -200; // ERRO: 'Produto.preco' é inacessível devido ao seu nível de proteção
        }
    }
}
