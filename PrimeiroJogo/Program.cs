Console.Write("Digite seu nome, caro jogador: ");
string nomeJogador = Console.ReadLine()!;
Console.Clear();

void BoasVindas(string nome)
{
    Console.Write("********************************************");
    Console.WriteLine("\r\n█████████████████████████████████████████████████████████████████████████" +
                      "\r\n█▄─▄▄▀██▀▄─██▄─▀█▄─▄█▄─▄▄▀█─▄▄─█▄─▀█▀─▄█▄─▄█░▄▄░▄██▀▄─██▄─▄▄▀█─▄▄─█▄─▄▄▀█" +
                      "\r\n██─▄─▄██─▀─███─█▄▀─███─██─█─██─██─█▄█─███─███▀▄█▀██─▀─███─██─█─██─██─▄─▄█" +
                      "\r\n▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▄▄▄▀▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▄▄▀▄▄▀" +
                      "\r\n█████████████████████████████████████████████████████████████████████████");
    Console.WriteLine("********************************************");
    Console.WriteLine($"Seja muito bem-vindo(a) caro {nome}\n");
}

void ExibirMenu()
{
    Console.WriteLine("\nAntes de tudo, leia as opções: ");
    Console.WriteLine("Digite 1 para iniciar o jogo!");
    Console.WriteLine("Digite 0 para sair do jogo!");
    Console.Write("---> ");
}

int NumeroAleatorio()
{
    Random random = new Random();
    int numero = random.Next(1, 100);
    return numero;
}

void TentativaNumero()
{
    int numeroEscolha;

    do
    {
        Console.Write("\nDigite um número inteiro (1 a 100): ");
        numeroEscolha = Convert.ToInt32(Console.ReadLine());

        if (numeroEscolha > NumeroAleatorio())
        {
            Console.WriteLine("\nNúmero errado, escolha algum menor!!!");
        } else if (numeroEscolha < NumeroAleatorio())
        {
            Console.WriteLine("\nNúmero errado, escolha algum maior!!!");
        } else
        {
            Console.WriteLine("Parabéns, você acertou o número!!!");
            break;
        }

    } while (numeroEscolha != NumeroAleatorio());
}

void ExecutarPrgrama()
{
    BoasVindas(nomeJogador);

    bool sair = false;

    while(!sair)
    {
        ExibirMenu();
        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                TentativaNumero();
                break;
            case 0:
                Console.WriteLine("\nEspero que tenha gostado, até a próxima!!!");
                sair = true;
                break;
            default:
                Console.WriteLine("\nNúmero Inválido!");
                break;
        }
    }
}

ExecutarPrgrama();