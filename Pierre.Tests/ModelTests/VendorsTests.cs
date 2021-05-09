using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class PierreTests : IDisposable
  {

    public void Dispose()
    {
      Pierre.ClearAll();
    }

    [TestMethod]
    public void PierreConstructor_CreatesInstanceOfPierre_Vendors()
    {

    }
  }
}