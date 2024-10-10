global using System.Text.Json;

string textWeapon = File.ReadAllText("Weapons.json");
List<Weapon> weapons = JsonSerializer.Deserialize<List<Weapon>>(textWeapon);

for (int i = 0; i < weapons.Count; i++)
{

    Console.WriteLine(weapons[i].Name);
    Console.WriteLine(weapons[i].DamageMax + " Max damage");
    Console.WriteLine(weapons[i].DamageMin + " Min damage");

}

Console.WriteLine($"pick which weapon you want to use 1.{weapons[0].Name} 2.{weapons[1].Name}");
string Choice = Console.ReadLine();
while (Choice != "1" && Choice !=  "2")
    {
        Console.Clear();
        Console.WriteLine("Pick 1 or 2 dumb dumb");
        Choice = Console.ReadLine();
    }
if (Choice == "1")
{
    Console.Clear();
    Console.WriteLine($"woah you choose the {weapons[0].Name} Great job");
    Console.WriteLine("how many attacks do you want to do");
    int attacks = int.Parse(Console.ReadLine());    
    while (attacks > 15)
    {
        Console.WriteLine("Pick 15 or below dumb dumb");
        attacks = int.Parse(Console.ReadLine());
    }
    int damageDealt = 0;
    for (int i = 0; i < attacks; i++)
    {
        damageDealt+=weapons[0].Attack();
    }
    Console.Clear();
    Console.WriteLine($"you dealt {damageDealt} dmg");
}
else if (Choice == "2")
{
    Console.Clear();
    Console.WriteLine($"woah you choose the {weapons[1].Name} Great job");
    Console.WriteLine("how many attacks do you want to do");
    int attacks = int.Parse(Console.ReadLine());
    while (attacks > 15)
    {
        Console.WriteLine("Pick 15 or dumb dumb");
        attacks = int.Parse(Console.ReadLine());
    }
    int damageDealt = 0;
    for (int i = 0; i < attacks; i++)
    {
       damageDealt+=weapons[1].Attack();
    }
    Console.Clear();
    Console.WriteLine($"you dealt {damageDealt} dmg");

}

// else
// {

// }


Console.ReadLine();


    // Weapon Myfirstweapon = new Weapon()
    // {
    //  Name="axe",
    //  DamageMin=5,
    //  DamageMax=10
    // };

    // string jsonWeapon = JsonSerializer.Serialize(Myfirstweapon);
    // Console.WriteLine(jsonWeapon);

    // File.WriteAllText("Weapon.json", jsonWeapon);