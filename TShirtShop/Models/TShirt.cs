namespace TShirtShop.Models;

public abstract class TShirt
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string FullDescription => $"{Name} - {Description}";
    public abstract void FormSize();
}
