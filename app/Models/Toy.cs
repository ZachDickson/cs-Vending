using cs_vending.Interfaces;

namespace cs_vending.Models
{
  class Toy : IPurchasable
  {

    public Toy(string name, int cost)
    {
      Name = name;
      Cost = cost;
    }


    public string Name { get; set; }
    public int Cost { get; set; }

  }
}