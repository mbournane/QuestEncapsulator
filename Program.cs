namespace BeerEncapsulator;

class Program
{
    static void Main(string[] args)
    {
        BeerEncapsulator encapsulator = new BeerEncapsulator();
        
        Console.Write("Veuillez saisir le nombre de litre de bière ");
        decimal beerVolume = Decimal.Parse(Console.ReadLine());
        encapsulator.SetAvalaibleBeerVolume(beerVolume);

        Console.Write("Veuillez saisir le nombre de bouteilles ");
        int beerBottles = Math.Abs(Int32.Parse(Console.ReadLine()));
        encapsulator.SetAvalaibleBottles(beerBottles);

        Console.Write("Veuillez saisir le nombre de capsule ");
        int beerCapsules = Math.Abs(Int32.Parse(Console.ReadLine()));
        encapsulator.SetAvalaibleCapsules(beerCapsules);

        Console.Write("Saisir le nombre de à fabriquer ");
        int nbBottles = Int32.Parse(Console.ReadLine());

        int nbBottlesVolume = (int) (beerVolume * 100)/33;

        if(nbBottles > nbBottlesVolume)
        {
            decimal beerVolumeLack = (decimal) ((nbBottles - nbBottlesVolume) * 33)/ 100;
            Console.WriteLine("il faut ajouter "+ beerVolumeLack +" litres de bière" );
        }

        encapsulator.ProduceEncapsulatedBeerBottles(nbBottles);


    }
}
