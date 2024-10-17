using Adapter_Pattern;
internal class Program
{
    private static void Main(string[] args)
    {
        ComputerGame computerGame = new ComputerGame(name:"Red Dead Redemption",
            pegiAgeRating:PegiAgeRating.P7,budgetInMillionsOfDollars:65,minimumGpuMemoryInMegabytes:8,diskSpaceNeededInGB:122,ramNeededInGb:16,coresNeeded:8,coreSpeedInGhz:3.1);
        ComputerGameAdapter adapt = new ComputerGameAdapter(computerGame);
        Console.Write(adapt.getTitle());
        if (adapt.isTripleAGame())
        {
            Console.WriteLine(" AAA Game");
        }
        else
        {
            Console.WriteLine(" Indi game");
        }
        Console.WriteLine("allow age "+adapt.getPegiAllowedAge());
        Console.WriteLine(adapt.getRequirements().ToString());
       
    }
}
