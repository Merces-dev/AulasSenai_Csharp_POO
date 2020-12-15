namespace Aula26Interfaces
{
    public interface ICarrinho
    {
    void ReadProduct(); 
    void UpdateProduct(int _codigo, Produto _AlterarProduto); 
    void AddProduct(Produto _produto); 
    void DeleteProduct(Produto _produto); 
    void ShowTotal();
    }
}