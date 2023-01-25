using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobelPrize
{
    internal class PrizeCount
    {
        public int _prizeCount { get; set; }
        public string _laureateId { get; private set; }

        public PrizeCount(string id)
        {
            _laureateId = id;
            _prizeCount = 1;
        }

        public void ShowPrizes(Prize[] prizes)
        {
            foreach (var prize in prizes)
            {
                if(prize.Laureates == null) continue;
                if (prize.Laureates.FirstOrDefault(p => p.Id == _laureateId) == null) continue;
                Console.WriteLine($"Year: {prize.Year}\n" +
                                  $"Category: {prize.Category}");
                foreach (var laureate in prize.Laureates)
                {
                    if(laureate.Id == _laureateId) Console.WriteLine($"Name: {laureate.Firstname} {laureate.Surname}\n" +
                                                                     $"Motivation: {laureate.Motivation}\n" +
                                                                     $"Share: {laureate.Share}\n");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
