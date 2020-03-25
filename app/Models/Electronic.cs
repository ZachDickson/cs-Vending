using cs_vending.Interfaces;


namespace cs_vending.Models
{
  class Electronic : IPurchasable
  {

    public Electronic(string name, int cost)
    {
      Name = name;
      Cost = cost;
    }


    public string Name { get; set; }
    public int Cost { get; set; }

  }
}