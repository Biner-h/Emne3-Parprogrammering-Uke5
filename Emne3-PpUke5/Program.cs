//Appen du skal lage må ha en pokemontrener. Brukeren skal få velge navn og startpokemon.
//Treneren skal ha mulighet til å gå i forskjellig terreng (grass, vann) der vilkårlige pokemen kan dukke opp.
//Man kan fange eller kjempe mot de ville pokemenna som dukker opp (det kan hende de også stikker av).
//Treneren kan også gå inn i pokeshop for å skaffe seg flere pokeballer eller health potions som kan brukes i combat.
//Man skal ha mulighet til å se hvilke pokemen treneren har, og også annen inventory som pokeballer/potions.


using Emne3_PpUke5;

var grass = new Grass(new List<Pokemon>()
{
    new Pokemon("Pikachu", 100),
    new Pokemon("Bulbasaur", 54),
    new Pokemon("Charizard", 67)
});

var water = new Water(new List<Pokemon>()
{
    new Pokemon ("Lugia", 65),
    new Pokemon("MewTwo", 77),
    new Pokemon ("HO-OH", 23)
});

var pokeShop = new PokeShop(new List<Items>()
{
    new Items("Pokeballs"),
    new Items("Potion"),
    new Items("PokeEgg")
});

Console.WriteLine("Hva heter spilleren?");
var Name = Console.ReadLine();

Console.WriteLine("\nHvor mye liv har spilleren?");
var Health = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); 

var person = new Spiller(Name, Health);
person.showInfo();

while (true)
{
    Console.WriteLine("\n1. Gå til gress terreng");
    Console.WriteLine("\n2. Gå til vann terreng");
    Console.WriteLine("\n3. Gå til poke shop");
    Console.WriteLine("\n4. Gå til inventory");
    var input = Console.ReadLine();

    switch(input)
    {
        case "1":
            grass.GetGrassPokemon(); break;

        case "2":
            water.GetWaterPokemon(); break;
        
        case "3":
            pokeShop.ShowShop(); break;

        case "4":
            ; break;

        default: break; 
    }
}





