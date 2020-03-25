

using System;
using cs_vending.Services;

namespace cs_vending.Controllers
{
  class VendingController
  {

    private bool _running { get; set; } = true;
    private VendingService _vs { get; set; } = new VendingService();

    public void Run()
    {
      while (_running)
      {
        GetUserInput();
        _running = false;
      }
    }
    private void GetUserInput()
    {
      Console.Clear();
      System.Console.WriteLine("Welcome to the Vending Machine!");
      System.Console.WriteLine("what would you like? (snacks, toys, electronics) or say quit.");
      string userInput = Console.ReadLine().ToLower();

      switch (userInput)
      {
        case "quit":
          _running = false;
          break;

        case "snacks":
          _vs.ViewSnacks();
          PrintSnacks();
          System.Console.WriteLine("What snack would you like to buy?");
          _vs.BuySnacks();
          break;

        case "toys":
          _vs.ViewToys();
          PrintToys();
          break;

        case "electronics":
          _vs.ViewElectronics();
          PrintElectronics();
          break;

        default:
          System.Console.WriteLine("invalid option!");
          break;
      }

    }

    private void PrintSnacks()
    {
      foreach (Message message in _vs.SnackMessages)
      {
        System.Console.WriteLine(message.Body);
      }
      _vs.SnackMessages.Clear();
    }

    private void PrintToys()
    {
      foreach (Message message in _vs.ToyMessages)
      {
        System.Console.WriteLine(message.Body);
      }
      _vs.ToyMessages.Clear();
    }

    private void PrintElectronics()
    {
      foreach (Message message in _vs.ElectronicMessages)
      {
        System.Console.WriteLine(message.Body);
      }
      _vs.ElectronicMessages.Clear();

    }

  }
}