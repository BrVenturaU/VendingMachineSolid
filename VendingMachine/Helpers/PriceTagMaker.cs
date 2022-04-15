public class PriceTagMaker{
    public virtual string MakePriceTagForProduct(Product product)
    {
        return $"${product.Price:0.##}";
    }
}