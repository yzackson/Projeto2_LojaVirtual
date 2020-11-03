using System;
using System.Collections.Generic;

class Cliente {

    string _nome;
    string _endereco;
    int _telefone;

    // Get-Set do Nome do Cliente
    public string nome {
        get { return _nome; }
        set { _nome = value; }
    }

    // Get-Set do CPF do Cliente
    public string endereco {
        get { return _endereco; }
        set { _endereco = value; }
    }

    // Get-Set do Endereco do Cliente
    public int telefone {
        get { return _telefone; }
        set { _telefone = value; }
    }


}