public static class ProductExtensions{
    public static PriceTagMaker GetPriceTagMaker(this Product product){
        switch(product.Type){
            case "Drink":
                return new DrinkTypePriceTagMaker();
            case "Fruit":
                return new FruitTypePriceTagMaker();
            default:
                return new PriceTagMaker();
        }
    }
}