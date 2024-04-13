string[] heroes = { "Ironman", "Batman", "Dr.Strange", "Thor" };
string[] villains = { "Thanos", "Joker", "Pickle-Rick", "Loki", "Dormammu" };
string[] weapon = { "Gun", "Toothpick", "Rocket", "Sword", "Fork" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}