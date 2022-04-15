public class CsvMenuLoader: IMenuLoader{
    public string Path { get; set; }
    public CsvMenuLoader(string path)
    {
        Path = path;
    }
    public List<Product> LoadMenu(){
        var products = new List<Product>();
        using var reader = new StreamReader(Path);
        while(!reader.EndOfStream){
            var line = reader.ReadLine();
            var values = line.Split(";");
            products.Add(new Product(){
                Id = int.Parse(values[0]),
                Name = values[1],
                Price = decimal.Parse(values[2]),
                Type = values[3]
            });
        }
        return products;
    }
}