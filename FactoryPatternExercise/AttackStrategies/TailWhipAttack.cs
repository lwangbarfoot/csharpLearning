namespace StrategyExample.AttackStrategies;

public class TailWhipAttack : IPokemonAttackStrategy
{
    public void Attack(string attackerName)
    {
        Console.WriteLine($"{attackerName} used TailWhip!");
    }
}