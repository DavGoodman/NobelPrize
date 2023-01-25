namespace NobelPrize
{

    public class Prize
    {
        public string Year { get; set; }
        public string Category { get; set; }
        public Laureate[] Laureates { get; set; }
        public string OverallMotivation { get; set; }

        

        public void PrintInfo()
        {
            Console.WriteLine($"Year: {Year}\n" +
                              $"Category: {Category}");
            foreach (var laureate in Laureates)
            {
                laureate.PrintLaureateName();
            }

        }

    }

    


}
