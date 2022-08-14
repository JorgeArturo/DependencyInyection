using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInyectionTest.Utilities;

namespace DependencyInyectionTest
{
    public class BetterBusinessLogic : IApplication
    {
        private readonly IDataAccess _dataAccess;
        public BetterBusinessLogic(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void Run()
        {
            _dataAccess.PrintData();
            Console.WriteLine("BetterBusinessLogic");
        }
    }
}