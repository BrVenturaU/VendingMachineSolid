public class FruitTypePriceTagMaker: PriceTagMaker{
    public override string MakePriceTagForProduct(Product product)
    {
        var basePrice = base.MakePriceTagForProduct(product);
        return $"{basePrice} + {product.Price*0.05m:0.##} deposit fee.";
    }
}