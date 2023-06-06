using System;

namespace BeerEncapsulator
{
    public class BeerEncapsulator
    {
        private decimal _avalaibleBeerVolume ;
        private int _avalaibleBottles;
        private int _avalaibleCapsules;

        public void SetAvalaibleBeerVolume(decimal beerVolume)
        {
            _avalaibleBeerVolume = beerVolume * 100;
        }

        public decimal GetAvalaibleBeerVolume()
        {
            return _avalaibleBeerVolume;
        }

        public void SetAvalaibleBottles(int bottles)
        {
            _avalaibleBottles = bottles;
        }
        public int GetAvalaibleBottles()
        {
            return _avalaibleBottles;
        }

        public void SetAvalaibleCapsules(int capsules)
        {
            _avalaibleCapsules = capsules;
        }
        public int GetAvalaibleCapsules()
        {
            return _avalaibleCapsules;
        }
        public int AvalaibleBottles{get; set;}
        public int AvalaibleCapsules{get; set;}

        public bool AddBeer()
        {
             if(_avalaibleBeerVolume < 33)
            {
                Console.WriteLine("Veuillez ajouter de la bière !!");
                return false;
            }            
            else if (_avalaibleBottles< 1)
            {
                Console.WriteLine("Veuillez ajouter des bouilles!!");
                return false;
            }              
            else if(_avalaibleCapsules< 1)
                    {
                        Console.WriteLine("Veiillez ajouter des capsules !!");
                        return false;
                    }                       
                     else{
                                _avalaibleBeerVolume -= 33;
                                _avalaibleBottles -= 1;
                                _avalaibleCapsules -= 1;
                                return true;
                        }

        }

        public int ProduceEncapsulatedBeerBottles(int bottlesNumber)
        {
            int cpt = 0 ;
            for(int i=0; i< bottlesNumber;i++)
            {
                if(!AddBeer())
                    break;
                else
                    cpt++;                                 

            }
            Console.WriteLine($"{cpt} bouteilles remplis par la machine ");
            if (cpt == bottlesNumber)
                return 1;
            else return 0;
        }

      /*   public bool BrewOneBeer()
        {
            if(_avalaibleBeerVolume < 33)
            {
                Console.WriteLine("Veuillez ajouter de la bière !!");
                return false;
            }            
            else if (_avalaibleBottles< 1)
            {
                Console.WriteLine("Veuillez ajouter des bouilles!!");
                return false;
            }              
            else if(_avalaibleCapsules< 1)
                    {
                        Console.WriteLine("Veiillez ajouter des capsules !!");
                        return false;
                    }                       
                     else{
                                _avalaibleBeerVolume -= 33;
                                _avalaibleBottles -= 1;
                                _avalaibleCapsules -= 1;
                                return true;
                        }

        } */
    }
}
