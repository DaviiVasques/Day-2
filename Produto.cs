using System.Globalization;

namespace Produtos;

class Produto
{
    private string _nome;
    private float _preco;
    private int _quantidade;

    CultureInfo Real = new CultureInfo("pt-BR");


    public Produto(string nome, float preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != null && value.Length > 1)
            {
                _nome = value;
            }
        }

    }

    public float Preco 
    {
        get{return _preco;}
    }

    public int Quantidade 
    {
        get{return _quantidade; }
    }


    public double ValorEstoque()
    {
        return _quantidade * _preco;
    }

    public void AdicionarProduto(int quantidadeAdicionada)
    {
        quantidadeAdicionada += _quantidade;
    }

    public void RemoverProduto(int quatidadeRemovida)
    {
        quatidadeRemovida -= _quantidade;
    }
    public override string ToString()
    {
        return "O produto "
        + _nome + ", tem "
        + _quantidade + " em estoque, e o seu preço é: "
        + _preco.ToString("C2", Real)
        + " e o seu Valor total do estoque: " + ValorEstoque().ToString("C2", Real);
    }
}