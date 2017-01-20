namespace XpMan.XmasTree
{
  public class PlasticToyMakingElf : IElf
  {
      private readonly Santa _santa;

      public PlasticToyMakingElf(Santa santa) 
      {
          _santa = santa;
      }

      public void TellSanta(string type, string child)
      {
            _santa.MadeAToy(Name, type, child);
        }

      public bool OnNaughtyList(string child)
      {
            return _santa.IsOnNaughtyList(child);
        }

      public Toy MakePresent(string child)
    {
      if (!OnNaughtyList(child))
      {
        var toyType = "Plastic Spaceship";
        this.TellSanta(toyType, child);
        return new Toy(toyType);
      }
      else
      {
        return new NaughtyChildToy(child);
      }
    }

    public string Name { get { return "Plastic Toy Making Elf"; } }
  }
}