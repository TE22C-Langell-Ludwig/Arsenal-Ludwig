using System.Text.Json.Serialization;

public class Weapon
{
    [JsonInclude]
    public string Name;

    [JsonInclude]
    public int DamageMax;

    [JsonInclude]
    public int DamageMin;

    public int Attack()
    {

        int CalculatedDamage = Random.Shared.Next(DamageMin, DamageMax);
        return CalculatedDamage;
    }
}