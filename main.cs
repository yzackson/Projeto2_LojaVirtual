using System;

class MainClass {
  public static void Main (string[] args) {
    
    int confirma = 0;

    Cliente cliente = new Cliente();

    Console.WriteLine("Seja bem-vindo a nossa Loja Virtual UCL Market");
    Console.WriteLine("Para poder acessar nossa loja vamos fazer um cadastro rápido");

    // ADICIONAR UMA CONFIRMAÇÃO DE CADASTRO... PERGUNTAR AO CLIENTE SE ELE CONFIRMA OS DADOS
    do{
        Console.Clear();
        Console.WriteLine("Nos diga seu nome, por favor");
        cliente.nome = Console.ReadLine();
        Console.WriteLine("Agora nos diga seu endereço");
        cliente.endereco = Console.ReadLine();
        Console.WriteLine("Pra finalizar, nos informe seu telefone");
        cliente.telefone = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine(" Nome: {0}\n Endereço: {1}\n Telefone: {2}", cliente.nome, cliente.endereco, cliente.telefone);
        Console.WriteLine("Confirma os dados? [1] Sim [2] Não");
    } while (confirma != 1);

    Console.WriteLine("Cadastro realizado com sucesso!");
    Console.Clear();

    Loja loja = new Loja();
    
        


  }
}