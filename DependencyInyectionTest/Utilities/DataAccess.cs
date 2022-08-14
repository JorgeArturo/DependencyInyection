using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInyectionTest.Utilities
{
    public class DataAccess : IDataAccess
    {
        public void PrintData()
        {
            Console.WriteLine("Data Access Library");
        }

    }
}