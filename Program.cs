// Screen Sound



string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string>{ "U2", "The Beatles", "Calypso" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10,8,6});
bandasRegistradas.Add("The Beatles", new List<int>());




//void usado para função que nao espera um retorno.
void ExibindoLogo()
{
    Console.WriteLine(@"\r\n
        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    
    ExibindoLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");

    string opcarEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcarEscolhida);

    // if (opcaoEscolhidaNumerica == 1)
    // {
    //     Console.WriteLine("Você digitou a opção " + opcarEscolhida);
    // } else if (opcaoEscolhidaNumerica == 2)
    // {
    //     Console.WriteLine("Você digitou a opção " + opcarEscolhida);
    // } else if (opcaoEscolhidaNumerica == 3)
    // {
    //     Console.WriteLine("Você digitou a opção " + opcarEscolhida);
    // } else if (opcaoEscolhidaNumerica == 4)
    // {
    //     Console.WriteLine("Você digitou a opção " + opcarEscolhida);
    // } else if (opcaoEscolhidaNumerica == -1)
    // {
    //     Console.WriteLine("Você digitou a opção " + opcarEscolhida);
    // }

    switch (opcaoEscolhidaNumerica)
    {
        case 1 : Registrarbandas();
        break;
        case 2 : MontrarBandasRegistradas();
        break;
        case 3 : AvaliarUmaBanda();
        break;
        case 4 : MostrarMediaDeNotas();
        break;
        case -1 : Console.WriteLine("Tchau tchau :)");
        break;
        default: Console.WriteLine("Opção inválida");
        break;
    }
}

void MostrarMediaDeNotas()
{

    Console.Clear();
    ExibirTituloDaOpcao("Média da Banda");

    Console.Write("Digite o nome da banda que deseja Ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;

     if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        double mediaBanda = bandasRegistradas[nomeDaBanda].Average();
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {mediaBanda}.");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else 
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    Console.Clear();
    ExibirOpcoesDoMenu();
}

void Registrarbandas() {
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com suceso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
    
}

void MontrarBandasRegistradas()
{
    Console.Clear();

    ExibirTituloDaOpcao("Exibindo as bandas registradas");

    // for (int i = 0; i < listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }

    foreach (string banda in bandasRegistradas.Keys) 
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo) 
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}


void AvaliarUmaBanda()
{
    //pesquisar banda que deseja avaliar
    //se a banda existir no dicionario >> atribuir uma nota
    //se não existir mostrar uma mensagem e volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota essa banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else 
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibindoLogo();
ExibirOpcoesDoMenu();