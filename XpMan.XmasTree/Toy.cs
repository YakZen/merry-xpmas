namespace XpMan.XmasTree
{
  public class Toy
  {
    public string Reason { get; set; }
    public string Type { get; set; }

    public Toy(string toyType, string reason = null)
    {
      Reason = reason;
      Type = toyType;
    }
  }
}