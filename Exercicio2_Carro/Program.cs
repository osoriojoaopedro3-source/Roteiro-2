namespace Exercicio2_Carro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Carro c = new Carro("Ferrari");
            c.Acelerar(50);
            c.ExibirVelocidade(); // Deve exibir 50
            c.Frear(30);
            c.ExibirVelocidade(); // Deve exibir 20
            c.Frear(50);
            c.ExibirVelocidade(); // Deve exibir 0

            // c.velocidadeAtual = -100; // ERRO: 'Carro.velocidadeAtual' é inacessível devido ao seu nível de proteção
        }
    }
}
