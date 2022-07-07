namespace magnetart.MagnetArt.Domain.Models;

public class Provider
{
    public int id  { get; set; }
    public string name  { get; set; }
    public string apiUrl  { get; set; }
    public bool keyRequired  { get; set; }
    public string apiKey  { get; set; }
}