namespace FactoryPattern.AttackStrategies;

public class TackleAttack :IPokemonAttackStrategy
{
    public void Attack(string attackerName)
    {
        Console.WriteLine($"{attackerName} used Tackle!");
    }

}