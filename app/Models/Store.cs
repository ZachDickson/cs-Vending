using System.Collections.Generic;

namespace cs_vending.Models
{
  class Store
  {
    public List<Snack> Snacks { get; set; }
    public List<Toy> Toys { get; set; }
    public List<Electronic> Electronics { get; set; }


    public Store()
    {
      Snacks = new List<Snack>()
      {
            new Snack ("chips", 1),
            new Snack ("gummy bears", 1),
            new Snack ("chocolate", 2)
          };

      Toys = new List<Toy>()
      {
            new Toy ("woody", 3),
            new Toy ("buzz", 4),
            new Toy ("squirtgun", 5)
      };

      Electronics = new List<Electronic>()
      {
          new Electronic ("iphone", 10),
          new Electronic (" laptop", 20)
      };
    }
  }

}