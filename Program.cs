namespace BeerKlasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beer beer1 = new("Et", BeerType.Lager, 5f, 50);
            Beer beer2 = new("To", BeerType.Doppelbock, 12f, 40);
            Beer beer3 = new("Tre", BeerType.Porter, 7f, 30);
            Beer beer4 = new("Fire", BeerType.WienerDortmunder, 5.5f, 33);
            Beer beer5 = new("Fem", BeerType.Pilsner, 5f, 25);

            Beer beer6 = (beer1 + beer4);

            List<Beer> beerList = new() { beer1, beer2, beer3, beer4, beer5, beer6 };
            beerList.Sort((a, b) => b.Procent.CompareTo(a.Procent));
            beerList.ForEach(beer =>
            {
                Console.WriteLine(beer.ToString() + "\n__________________________");
            });

            string obj = "beer1";
            Console.WriteLine($"\n---- {obj} ToString ----");
            Console.WriteLine(beer1.ToString());

          
            obj = "beer1 GetUnits";
            Console.WriteLine($"\n---- {obj} ToString ----");
            Console.WriteLine(beer1.GetUnits().ToString());

            obj = "beer4 GetUnits";
            Console.WriteLine($"\n---- {obj} ToString ----");
            Console.WriteLine(beer4.GetUnits().ToString());

            obj = "beer6 GetUnits";
            Console.WriteLine($"\n---- {obj} ToString ----");
            Console.WriteLine(beer6.GetUnits().ToString());

            CompareVolumen compareVolumen = new();

            obj = "CompareVolumen beer6, beer1";
            int compared = compareVolumen.Compare(beer6, beer1);
            Console.WriteLine($"\n---- {obj} ----");
            Console.WriteLine(compared);

            CompareName compareName = new();
            obj = "CompareName beer1, beer2";
            compared=compareName.Compare(beer1, beer2);
            Console.WriteLine($"\n---- {obj} ----");
            Console.WriteLine(compared);

        }
    }
}
