using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPriciple
{
    public class WordGenerator : IGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating WORD report...");
        }
    }
}
