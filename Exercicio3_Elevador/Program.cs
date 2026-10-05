namespace Exercicio3_Elevador
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Teste principal ===");
            Elevador e = new Elevador(10);
            e.Subir();
            e.Subir();
            e.ExibirAndar(); // Deve exibir 2
            e.Descer();
            e.ExibirAndar(); // Deve exibir 1
            e.Descer();
            e.Descer();
            e.ExibirAndar(); // Deve continuar em 0

            Console.WriteLine();
            Console.WriteLine("=== Teste adicional (limites) ===");
            Elevador e2 = new Elevador(3);
            e2.Descer();
            e2.ExibirAndar(); // Deve continuar em 0
            e2.Subir();
            e2.Subir();
            e2.Subir();
            e2.Subir();
            e2.ExibirAndar(); // Deve continuar em 3
        }
    }
}
