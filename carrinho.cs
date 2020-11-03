class Carrinho{

  double soma_tot = 0.0;

  List<Item> sacola = new List<Item>("vazio", 0, 0.0, 0);

  Item item = new Item ("vazio", 0, 0.0, 0);

    // Mostrar ao usuário os itens que ele já tem adicionado
    public void mostrar_carrinho() {
        foreach (Item item in sacola) {
            Console.WriteLine("Codigo >> Item >> Quantidade >> Valor");
            Console.WriteLine("{0} >> {1} >> {2} >> {3}", item.codigo, item.descricao, item.quantidade, item.valor*item.quantidade);
        }
    }

    // Adicionar os itens à sacola
    public void adicionar_item (int codigo, string descricao, int quantidade, double valor) {
        if(sacola[0].descricao == "vazio") {
            sacola.Remove(sacola[0]);
        }

        item.codigo = codigo;
        item.descricao = descricao;
        item.quantidade = quantidade;
        item.valor = valor*quantidade;

        sacola.Add(item);
    }

    // retorna o valor total da sacola
    public double soma_total() { 
        for (int i = 0; i < sacola.Count; i++) {
            soma_tot += sacola[i].valor;
        }

        return soma_tot;
    }

}