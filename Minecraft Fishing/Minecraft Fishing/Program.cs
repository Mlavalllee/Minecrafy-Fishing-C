//variables

// fishing rod's Enchantments array
var Enchant = new Dictionary<string, int>()
{
    {"Unbreaking", 0 },
    {"mending", 0 },
    {"LuckOfSea", 0 },
};

// Fish array and weight catch chance
var fish = new Dictionary<int, string>()
{
    {60, "Cod" },
    {25, "Salmon" },
    {13, "Pufferfish" },
    {2, "Tropical Fish" }
};

// Junk array and weight catch chance
var Junk = new Dictionary<int, string>()
{
    { 17,"Lilly pad"},
    { 10,"Bowl"},
    { 10,"Leather"},
    { 10,"Leather Boots"},
    { 10,"Rotten Flesh"},
    { 10,"Bone"},
    { 10,"Water Bottle"},
    { 10,"Trip Wire"},
    { 5,"Stick"},
    { 5,"String"},
    { 2,"Fishing Rod"},
    { 1,"Inc Sac"},
};
// no treasure array, they all have the same chance weight

//Fishing Menu
Menu();

void Menu() 
{
    Console.WriteLine("Fishing rod Enchantments");
    Console.WriteLine("");
    Console.WriteLine("");
}

// without luck of the sea
// 85% fish
// 10% junk
// 5% treasure

// luck of the seas 1
//84.8% fish
// 8.1% junk
// 7.1% treasure

// luck of the seas 2
// 84.7% fish
// 6.1% junk
//9.2% treasure

// luck of the seas 3
//84.5% fish
// 4.2% junk
//11.3% treasure