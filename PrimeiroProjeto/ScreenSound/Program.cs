﻿// See https://aka.ms/new-console-template for more information

//List<string> listaDasBandas = new List<string> {"Tribalistas", "Supercombo"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 9, 5});
bandasRegistradas.Add("Metallica", new List<int> { 1, 2, 3 });
void ExibirLogo(){
    string mensagemDeBoasVindas = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";
    Console.WriteLine(mensagemDeBoasVindas);
}
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    
    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
  
    switch(opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção:" + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção:" + opcaoEscolhida);
            break;
        case -1:
            Console.WriteLine(@"
████████╗░█████╗░██╗░░██╗░█████╗░██╗░░░██╗
╚══██╔══╝██╔══██╗██║░░██║██╔══██╗██║░░░██║
░░░██║░░░██║░░╚═╝███████║███████║██║░░░██║
░░░██║░░░██║░░██╗██╔══██║██╔══██║██║░░░██║
░░░██║░░░╚█████╔╝██║░░██║██║░░██║╚██████╔╝
░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝░╚═════╝░");
            break;
        default: Console.WriteLine("Opção inválida"); 
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de banda");
    Console.Write("Digite o nome da banda que deseja registrar:");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso");
    Carregamento(3);
}
void ListarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista de bandas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"- {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Carregamento(3);
}
int Carregamento(int segundos)
{
    for (int i = 0; i < segundos; i++) {
        if (i<1)
        {
            Console.Write(".");
        }
        else
        {
            Console.Write(" .");
        }
        
        Thread.Sleep(1000);
    }
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
    return 0;
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos+"\n");
}
ExibirLogo();
ExibirOpcoesDoMenu();
