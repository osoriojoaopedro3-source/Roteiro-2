namespace Exercicio2_Carro
{
    public class Carro
    {
        private string modelo;
        private int velocidadeAtual;

        public Carro(string modelo)
        {
            this.modelo = modelo;
            velocidadeAtual = 0;
        }

        public void Acelerar(int valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Erro: o valor para acelerar não pode ser negativo.");
                return;
            }

            velocidadeAtual += valor;
        }

        public void Frear(int valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Erro: o valor para frear não pode ser negativo.");
                return;
            }

            velocidadeAtual -= valor;

            // A velocidade nunca pode ficar abaixo de 0
            if (velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }
        }

        public void ExibirVelocidade()
        {
            Console.WriteLine($"{modelo} - Velocidade atual: {velocidadeAtual} km/h");
        }
    }
}
