namespace Exercicio3_Elevador
{
    public class Elevador
    {
        private int andarAtual;
        private int totalAndares;

        public Elevador(int totalAndares)
        {
            if (totalAndares < 0)
            {
                Console.WriteLine("Erro: o total de andares não pode ser negativo. Definido como 0.");
                totalAndares = 0;
            }

            this.totalAndares = totalAndares;
            andarAtual = 0;
        }

        public void Subir()
        {
            if (andarAtual >= totalAndares)
            {
                Console.WriteLine($"O elevador já está no último andar ({totalAndares}).");
                return;
            }

            andarAtual++;
        }

        public void Descer()
        {
            if (andarAtual <= 0)
            {
                Console.WriteLine("O elevador já está no térreo (andar 0).");
                return;
            }

            andarAtual--;
        }

        public void ExibirAndar()
        {
            Console.WriteLine($"Andar atual: {andarAtual}");
        }
    }
}
