namespace Crud_Home.Models;

public class Home
{

    public Guid Id { get; set; }
    public string Location { get; set; }
    public List<string> Rooms { get; set; } = new List<string>();
    public double Price { get; set; }
    public int Floor { get; set; }
    public int Quantity { get; set; }


}
