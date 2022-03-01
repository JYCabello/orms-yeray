namespace EFCoreCaveats;

public class ParentEntity
{
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public virtual ICollection<ChildEntity> Children { get; set; } = null!;
}
