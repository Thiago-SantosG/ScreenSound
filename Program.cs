//Screen Sound
string mensagemDeBoasVindas = "\nBoas Vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "Racionais Mcs", "Kyan", "NWA" };

Dictionary<string, List<int>> DicionarioDasBandas = new Dictionary<string, List<int>>();
DicionarioDasBandas.Add("Racionais", new List<int> { 10, 8, 7});
DicionarioDasBandas.Add("Link Park", new List<int> ());


void ExibirLogo()
{
    Console.WriteLine(@"
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
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
   

    switch (opcaoEscolhidaNumerica)
    {
            case 1:
            RegistrarBandas();
                break;
            case 2:
            ListarBandas(); 
                break;
            case 3:
            AvaliarUmaBanda();
                break;
            case 4:
            MediaDasBandasAvaliadas();
                break;
            case-1: Console.WriteLine("Bye Bye!"); 
                break;
            default: Console.WriteLine("Opção invalida!");
                break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas.");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    DicionarioDasBandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in DicionarioDasBandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomedaBanda = Console.ReadLine()!;
    if (DicionarioDasBandas.ContainsKey(nomedaBanda))
    {
        Console.Write($"Qual nota a banda {nomedaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine())!;
        DicionarioDasBandas[nomedaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomedaBanda}!!!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }else
    {
        Console.WriteLine($"\nA banda {nomedaBanda} não foi encontradda!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey(); 
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MediaDasBandasAvaliadas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir Média da Banda");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomedaBanda = Console.ReadLine()!;
    if (DicionarioDasBandas.ContainsKey (nomedaBanda)) 
    {
        List<int> notasDaBanda = DicionarioDasBandas[nomedaBanda];
        Console.WriteLine($"\nA média da banda {nomedaBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomedaBanda} não foi encontradda!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");
}

ExibirOpcoesDoMenu();