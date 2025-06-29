using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPriciple
{
    public class ReportGenerator
    {
        private readonly ISender sender;
        private readonly IGenerator generator;

        public ReportGenerator(ISender sender, IGenerator generator)
        {
            this.sender = sender;
            this.generator = generator;
        }

        public void GenerateAndSendReport()
        {
            sender.SendMessage();
            generator.GenerateReport(); 
        }

    }
}
