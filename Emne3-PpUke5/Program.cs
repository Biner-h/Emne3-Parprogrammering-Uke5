//Appen du skal lage må ha en pokemontrener. Brukeren skal få velge navn og startpokemon.
//Treneren skal ha mulighet til å gå i forskjellig terreng (grass, vann) der vilkårlige pokemen kan dukke opp.
//Man kan fange eller kjempe mot de ville pokemenna som dukker opp (det kan hende de også stikker av).
//Treneren kan også gå inn i pokeshop for å skaffe seg flere pokeballer eller health potions som kan brukes i combat.
//Man skal ha mulighet til å se hvilke pokemen treneren har, og også annen inventory som pokeballer/potions.


using Emne3_PpUke5;

var grass = new Grass(new List<Pokemon>()
{
    new Pokemon("Pikachu"),
    new Pokemon("Bulbasaur"),
    new Pokemon("Charizard")
});

var water = new Water(new List<Pokemon>()
{
    new Pokemon ("Lugia"),
    new Pokemon("MewTwo"),
    new Pokemon ("HO-OH")
});

Console.WriteLine("Hva heter spilleren?");
var Name = Console.ReadLine();

Console.WriteLine("\nHvor mye liv har spilleren?");
var Health = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); 

var person = new Spiller(Name, Health);
person.showInfo();




