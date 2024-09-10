public abstract class Base : AtorNotificavel
{

    public Base()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
}