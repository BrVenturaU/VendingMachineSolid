using System.Text.Json;

public class JsonMenuLoader: IMenuLoader{
    public string Path { get; set; }
    public JsonMenuLoader(string path)
    {
        Path = path;
    }
    public List<Product> LoadMenu(){
        var json = File.ReadAllText(Path);
        return JsonSerializer.Deserialize<List<Product>>(json);
    }
}