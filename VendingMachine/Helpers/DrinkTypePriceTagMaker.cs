public class DrinkTypePriceTagMaker: PriceTagMaker{
    public override string MakePriceTagForProduct(Product product){
        var basePrice = base.MakePriceTagForProduct(product);
        return $"{basePrice} + {product.Price*0.1m:0.##} deposit fee.";
    }
}