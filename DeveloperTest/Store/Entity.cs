namespace Store;

public class Entity
{
    public Guid EntityId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Double Price { get; set; }
    public DateTime FetchDate { get; set; }

    public override string ToString()
    {
        return EntityId.ToString();
    }
}