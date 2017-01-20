namespace XpMan.XmasTree
{
  public class SpaceshipToyMakingElf : IElf
  {
      private readonly Santa _santa;
      private readonly string _material;
      private readonly string _toyType;

      public SpaceshipToyMakingElf(Santa santa, string material, string toyType)
      {
          _santa = santa;
          _material = material;
          _toyType = toyType;
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
        var toyType = _material + " " + _toyType;
        this.TellSanta(toyType, child);
        return new Toy(toyType);
      }
      else
      {
        return new NaughtyChildToy(child);
      }
    }

    public string Name => $"{_material} Toy Making Elf";
  }
}