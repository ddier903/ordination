namespace shared.Model;

public class Dato {
    public int DatoId { get; set; }
    public DateTime dato { get; set; }

    public Dato toDateTime()
    {
        throw new NotImplementedException();
    }
}