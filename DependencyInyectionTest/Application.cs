using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInyectionTest.Utilities;

namespace DependencyInyectionTest
{
    public class Application : IApplication
    {
        private readonly IDataAccess _dataAccess;

        public Application(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void Run()
        {
            _dataAccess.PrintData();
        }
    }
}