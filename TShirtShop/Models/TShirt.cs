namespace TShirtShop.Models;

public abstract class TShirt
{
    public string Name { get; set; }
    public string Size {get; set;}
    public string Region {get; set;}
    
    public virtual string Description => $"{Name} - A {Size} T-shirt designed for the {Region} region";
    public abstract void FormSize();
}
