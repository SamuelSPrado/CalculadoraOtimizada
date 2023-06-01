using CalculadoraOtimizada;

class Program
{
    static void Main(string[] args)
    {
        // Cria um array de operações matemáticas disponíveis
        IOperacaoMatematica[] operacoes = new IOperacaoMatematica[]
        {
            new Soma (0, 0),
            new Subtracao(0, 0),
            new Multiplicacao(0, 0),
            new Divisao(0, 0),
            new RaizQuadrada(0)
        };

        // Exibe as opções de operações disponíveis
        Console.WriteLine("Escolha a operação desejada: ");
        for (int opcao = 0; opcao < operacoes.Length; opcao++)
        {
            Console.WriteLine($"{opcao + 1} - {operacoes[opcao].Descricao}");
        }

        // Lê a escolha do usuário
        Console.WriteLine();
        int escolha = int.Parse(Console.ReadLine());

        // Lê os valores para a operação escolhida
        double valorX;
        double valorY;

        Console.Write($"Digite o primeiro valor da operação {operacoes[escolha - 1].Descricao}: ");

        valorX = double.Parse(Console.ReadLine());
        valorY = 0;

        if (escolha != operacoes.Length)
        {
            Console.Write($"Digite o segundo valor da operação {operacoes[escolha - 1].Descricao}: ");
            valorY = double.Parse(Console.ReadLine());
        }

        // Realiza a operação escolhida
        IOperacaoMatematica operacao = operacoes[escolha - 1];
        operacao.SetValores(valorX, valorY);
        double resultado = operacao.Calcular();

        // Exibe o resultado da operação
        Console.WriteLine($"O resultado da {operacoes[escolha - 1].Descricao} é: { resultado}");
    }
}