using System.Collections.Generic;
using cs_vending.Models;

namespace cs_vending.Services
{
  class VendingService
  {
    private Store _store { get; set; } = new Store();
    public List<Message> SnackMessages = new List<Message>();
    public List<Message> ToyMessages = new List<Message>();
    public List<Message> ElectronicMessages = new List<Message>();



    #region snack methods

    public void ViewSnacks()
    {
      for (int i = 0; i < _store.Snacks.Count; i++)
      {
        var snack = _store.Snacks[i];
        SnackMessages.Add(new Message($"{i + 1}. {snack.Name} cost:${snack.Cost}"));
      }

    }

    public void BuySnacks()
    {

    }

    #endregion


    #region toys region
    public void ViewToys()
    {
      for (int i = 0; i < _store.Toys.Count; i++)
      {
        var toy = _store.Toys[i];
        ToyMessages.Add(new Message($"{i + 1}. {toy.Name} cost:${toy.Cost}"));
      }

    }
    #endregion


    #region electronics region
    public void ViewElectronics()
    {
      for (int i = 0; i < _store.Electronics.Count; i++)
      {
        var electronic = _store.Electronics[i];
        ToyMessages.Add(new Message($"{i + 1}. {electronic.Name} cost:${electronic.Cost}"));
      }

    }
    #endregion


  }

}