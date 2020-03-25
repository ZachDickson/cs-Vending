using System;
using cs_vending.Controllers;

namespace cs_vending
{
  class Program
  {
    static void Main(string[] args)
    {
      VendingController vc = new VendingController();
      vc.Run();
    }
  }
}
