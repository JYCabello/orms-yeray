namespace EFCoreCaveats;

public class ChildEntity
{
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public int ParentID { get; set; }
    public virtual ParentEntity Parent { get; set; } = null!;
}
