using System;

class Loja {
    List<Item> estoque = new List<Item>(); // Lista de estoque

    Item item = new Item("Item 0", 0, 0.0); // Inicialização do  
    

    // Listas que contém os dados que serão importados para dentro do estoque
    List<string> descricao = new List<string> {"10 COLOUR SPACEBOY PEN","SET/10 BLUE POLKADOT PARTY CANDLES","POTTING SHED SOW \'N\' GROW SET","PAPERWEIGHT KINGS CHOICE ","WOVEN BERRIES CUSHION COVER ","WHITE/PINK MINI CRYSTALS NECKLACE","SET/3 RED GINGHAM ROSE STORAGE BOX","MAGNETS PACK OF 4 VINTAGE LABELS ","WHITE CHRYSANTHEMUMS ART FLOWER","WHITE FRANGIPANI NECKLACE","SILVER FABRIC MIRROR","PINK  HONEYCOMB PAPER FAN","PINK BOUDOIR T-LIGHT HOLDER","BLACK CHERRY LIGHTS","GLASS CAKE COVER AND PLATE","DECORATION SITTING BUNNY","ANTIQUE MID BLUE FLOWER EARRINGS","VINTAGE LEAF CHOPPING BOARD  ","SNACK TRAY I LOVE LONDON","DECROTIVEVINTAGE COFFEE GRINDER BOX","IVORY ENCHANTED FOREST PLACEMAT","ANTIQUE SILVER TEA GLASS ETCHED","BLUE FELT HANGING HEART W FLOWER","PACK OF 12 COLOURED PENCILS","CLAM SHELL SMALL ","TWO DOOR CURIO CABINET","GREEN GOOSE FEATHER CHRISTMAS TREE ","MULTICOLOUR HONEYCOMB FAN","GREEN DROP EARRINGS W BEAD CLUSTER","BOTANICAL LILY GREETING CARD","SILVER DROP EARRINGS WITH FLOWER","CANDY SPOT BUNNY","WHITE WITH BLACK CATS PLATE","VEGETABLE MAGNETIC  SHOPPING LIST","FLOWER PURPLE CLOCK WITH SUCKER","VINTAGE CHRISTMAS GIFT SACK","found box","SET 10 CARDS SNOWY SNOWDROPS  17100","JUMBO SHOPPER VINTAGE RED PAISLEY","SET OF 4 ENGLISH ROSE PLACEMATS","FELTCRAFT HAIRBAND RED AND BLUE","BLUE GIANT GARDEN THERMOMETER","VINTAGE PAISLEY STATIONERY SET","SET OF 4 NAPKIN CHARMS CUTLERY","CARAVAN SQUARE TISSUE BOX","FRENCH PAISLEY CUSHION COVER ","GOLD FISHING GNOME","PINK BABY BUNTING","DROP DIAMANTE EARRINGS CRYSTAL","RED FLOCK LOVE HEART PHOTO FRAME"};
    List<int> quantidade = new List<int> {93, 43, 73, 11, 3, 41, 69, 3, 81, 5, 95, 14, 67, 67, 51, 14, 49, 17, 76, 95, 10, 93, 81, 19, 87, 45, 75, 36, 45, 46, 26, 8, 16, 16, 22, 73, 5, 33, 47, 53, 47, 53, 43, 5, 11, 4, 91, 69, 5, 95}; // Foi usado geração aleatória no excel para determinar valores de estoque
    List<double> valor = new List<double> {10.65,9.13,0.66,175.69,15.5,206.4,194.7,3.26,2019.05,109.19,404.49,157.08,183.2,124.87,888.42,736.38,0.84,0.07,2.4,24.96,9.72,160.0,18.62,14.75,2.82,10.2,29.74,19.96,80.46,183.09,152.19,49.13,8.0,138.46,135.08,2.41,10.82,425.14,2028.25,5.13,20.38,5.76,199.33,192.44,2.62,201.84,170.92,0.0,0.87,537.83};

    public static void AbrirLoja() { // Função que "importa" os dados de descrição, quantidade e valor que estão separados para dentro do estoque
        for(int i = 0; i < descricao.Count; i++) {
            item = new Item(descricao[i], quantidade[i], valor[i]);
            estoque.Add(item);
        }
    }
}

// Classe para guardar os atributos de cada item
class Item {
    string _descricao;
    int _quantidade;
    double _valor;

    // Construtor da classe
    public void Item (string descricao, int quantidade, double valor){
        _descricao = descricao;
        _quantidade = quantidade;
        _valor = valor;
    }

    // Getters e Setters para os atributos do Item
    public string descricao {
        get { return _descricao; }
        set { _descricao = value; }
    }
    public int quantidade {
        get { return _quantidade; }
        set { _quantidade = value; }
    }
    public double valor {
        get { return _valor; }
        set { _valor = value; }
    }
}