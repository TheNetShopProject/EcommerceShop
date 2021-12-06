namespace UseCases.UseCaseInterfaces.Products
{
    public interface ISellProductUseCase
    {
        void Execute(int productId, int qtyToSell);
    }
}