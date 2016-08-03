using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tickets = new string[,] { { "EZE", "TIA"},{ "EZE", "HBA"},{ "AXA", "TIA"},{ "JFK", "AXA"},{ "ANU", "JFK"},{ "ADL", "ANU"},{ "TIA", "AUA"},{ "ANU", "AUA"},{ "ADL", "EZE"},{ "ADL", "EZE"},{ "EZE", "ADL"},{ "AXA", "EZE"},{ "AUA", "AXA"},{ "JFK", "AXA"},{ "AXA", "AUA"},{ "AUA", "ADL"},{ "ANU", "EZE"},{ "TIA", "ADL"},{ "EZE", "ANU"},{ "AUA", "ANU"} };
            IList<string> list = FindItinerary(tickets);
            
        }

        
    }
}
