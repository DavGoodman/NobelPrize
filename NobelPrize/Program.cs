using NobelPrize;
using System.Text.Json;

var prizesJson = File.ReadAllText("prizes.json");
var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var prizes = JsonSerializer.Deserialize<Prize[]>(prizesJson, options);

List<PrizeCount> prizeCount = new List<PrizeCount>();


foreach (var prize in prizes)
{
    if(prize.Laureates == null) continue;
    foreach (var laureate in prize.Laureates)
    {
        PrizeCount counter = prizeCount.FirstOrDefault(c => c._laureateId.ToString() == laureate.Id);
        if (counter == null)
        {
            prizeCount.Add(new PrizeCount(laureate.Id));
        }
        else
        {
            counter._prizeCount++;
        }
    }
}


foreach (var counter in prizeCount)
{
    if (counter._prizeCount > 1) counter.ShowPrizes(prizes);
}


//Console.WriteLine("Enter the year of prizes you wish to view");
//string yearQuery = Console.ReadLine();

//foreach (var prize in prizes)
//{
//    if(prize.Year == yearQuery) prize.PrintInfo();
//}



//Console.WriteLine($"Year: {prizes[0].Year}\n" +
//                  $"Category: {prizes[0].Category}");

//foreach (var winner in prizes[0].Laureates)
//{
//    Console.WriteLine($"{winner.Firstname} {winner.Surname}");
//}
