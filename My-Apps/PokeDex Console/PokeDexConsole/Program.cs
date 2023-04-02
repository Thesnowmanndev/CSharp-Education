bool exitApplication = false;

while (exitApplication == false)
{
    string banner = "PokeDex Console";
    Console.WriteLine();
    Console.WriteLine(banner);

    string pokemonName = string.Empty;
    string pokemonTypeOne = string.Empty;
    string pokemonTypeTwo = string.Empty;
    string pokemonDescription = string.Empty;
    int pokemonHP = 0;
    int pokemonAtk = 0;
    int pokemonDef = 0;
    int pokemonSAtk = 0;
    int pokemonSDef = 0;
    int pokemonSpeed = 0;
    int pokemonTot = 0;

    Console.WriteLine("Pokemon List: Bulbasaur, Charmander, Squirtle");
    Console.Write("Which pokemon would you like to see details on: ");
    pokemonName = Console.ReadLine().ToLower();

    if (pokemonName == "bulbasaur")
    {
        pokemonName = "Bulbasaur";
        pokemonTypeOne = "Grass";
        pokemonTypeTwo = "Poison";
        pokemonDescription = $"{pokemonName} can be seen napping in bright sunlight. There is a seed on its back. By soaking up the sun's rays, the seed grows progressively larger.";
        pokemonHP = 45;
        pokemonAtk = 49;
        pokemonDef = 49;
        pokemonSAtk = 65;
        pokemonSDef = 65;
        pokemonSpeed = 45;
        pokemonTot = 318;

        Console.WriteLine();
        Console.WriteLine($"{pokemonName} Entry:");
        Console.WriteLine($"{pokemonDescription}");
        Console.WriteLine($"{pokemonName}'s types are: {pokemonTypeOne}" + " " + $"{pokemonTypeTwo}");
        Console.WriteLine($"{pokemonName}'s HP is {pokemonHP}. {pokemonName}'s attack is {pokemonAtk}. {pokemonName}'s Def is {pokemonDef}. {pokemonName}'s SAtk is {pokemonSAtk}. {pokemonName}'s SDef is {pokemonSDef}. " +
                            $"{pokemonName}'s speed is {pokemonSpeed}. {pokemonName}'s total stats ar {pokemonTot}.");
        Console.WriteLine();
    }
    if (pokemonName == "charmander")
    {
        pokemonName = "Charmander";
        pokemonTypeOne = "Fire";
        pokemonTypeTwo = string.Empty;
        pokemonDescription = $"The flame that burns at the tip of {pokemonName}'s tail is an indication of its emotions. The flame wavers when {pokemonName} is enjoying itself. If the Pokemon becomes enraged, the flame burns fiercely.";
        pokemonHP = 39;
        pokemonAtk = 52;
        pokemonDef = 43;
        pokemonSAtk = 50;
        pokemonSDef = 50;
        pokemonSpeed = 65;
        pokemonTot = 299;

        Console.WriteLine();
        Console.WriteLine($"{pokemonName}");
        Console.WriteLine($"{pokemonDescription}");
        Console.WriteLine($"{pokemonName}'s types are: {pokemonTypeOne}" + " " + $"{pokemonTypeTwo}");
        Console.WriteLine($"{pokemonName}'s HP is {pokemonHP}. {pokemonName}'s attack is {pokemonAtk}. {pokemonName}'s Def is {pokemonDef}. {pokemonName}'s SAtk is {pokemonSAtk}. {pokemonName}'s SDef is {pokemonSDef}. " +
                            $"{pokemonName}'s speed is {pokemonSpeed}. {pokemonName}'s total stats ar {pokemonTot}.");
        Console.WriteLine();
    }
    if(pokemonName == "squirtle")
    {
        pokemonName = "Squirtle";
        pokemonTypeOne = "Water";
        pokemonTypeTwo = string.Empty;
        pokemonDescription = $"{pokemonName}'s shell is not merely used for protection. The shell's rounded shape and the grooves on its surface help minimize resistance in water, enabling this Pokemon to swim at high speeds.";
        pokemonHP = 44;
        pokemonAtk = 48;
        pokemonDef = 65;
        pokemonSAtk = 50;
        pokemonSDef = 50;
        pokemonSpeed = 43;
        pokemonTot = 300;

        Console.WriteLine();
        Console.WriteLine($"{pokemonName}");
        Console.WriteLine($"{pokemonDescription}");
        Console.WriteLine($"{pokemonName}'s types are: {pokemonTypeOne}" + " " + $"{pokemonTypeTwo}");
        Console.WriteLine($"{pokemonName}'s HP is {pokemonHP}. {pokemonName}'s attack is {pokemonAtk}. {pokemonName}'s Def is {pokemonDef}. {pokemonName}'s SAtk is {pokemonSAtk}. {pokemonName}'s SDef is {pokemonSDef}. " +
                            $"{pokemonName}'s speed is {pokemonSpeed}. {pokemonName}'s total stats ar {pokemonTot}.");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("The string you entered was not an option.");
        Console.Write("Would you like to exit? Yes or No: ");
        string exitCommand = Console.ReadLine().ToLower();

        if (exitCommand == "yes")
        {
            exitApplication = true;
        }
    }
}