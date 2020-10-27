using System;
using System.Collections.Generic;

class Cliente
{

    private string NomeDoCliente;
    private int IdadeDoCliente;
    private string CpfDoCliente;
    private string EnderecoDoCliente;

    // Construtor completo :: obriga o cliente a cadastrar todos os dados
    public Cliente(string nome, int idade, string cpf, string endereco)
    {
        NomeDoCliente = nome;
        IdadeDoCliente = idade;
        CpfDoCliente = cpf;
        EnderecoDoCliente = endereco;
    }

    // Get-Set do Nome do Cliente
    public string NomeCliente
    {
        get { return NomeDoCliente; }
        set { NomeDoCliente = value; }
    }

    // Get-Set da Idade do Cliente
    public int IdadeCliente
    {
        get { return IdadeDoCliente; }
        set { IdadeDoCliente = value; }
    }

    // Get-Set do CPF do Cliente
    public string CpfCliente
    {
        get { return CpfDoCliente; }
        set { CpfDoCliente = value; }
    }

    // Get-Set do Endereco do Cliente
    public string EnderecoCliente
    {
        get { return EnderecoDoCliente; }
        set { EnderecoDoCliente = value; }
    }


}