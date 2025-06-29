using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPriciple
{
    public class PdfGenerator : IGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating PDF report...");
        }
    }
}
