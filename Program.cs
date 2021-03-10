using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitactionstest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string caseWorker in Enum.GetNames(typeof(Cases.CaseWorkers)))
            {
                Console.WriteLine("Case Worker: " + caseWorker + " (" + ((int)Enum.Parse(typeof(Cases.CaseWorkers), caseWorker)).ToString() + ")");
            }
        }
    }
}
