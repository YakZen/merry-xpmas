namespace XpMan.XmasTree
{
  public class ToyMakingElf : IElf
  {
      private readonly Santa _santa;
      private readonly string _material;
      private string _toyType;
      public ToyMakingElf(Santa santa, string material, string toyType)
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
          if (_material != "")
          {
              _toyType = _material + " " + _toyType;
          }
        
        TellSanta(_toyType, child);
        return new Toy(_toyType);
      }
      else
      {
        return new NaughtyChildToy(child);
      }
    }

    public string Name => _material == "" ? "Toy Making Elf" : $"{_material} Toy Making Elf";
  }
}