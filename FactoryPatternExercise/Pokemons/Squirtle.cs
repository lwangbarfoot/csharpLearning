using StrategyExample.AttackStrategies;
using System.Xml.Linq;

namespace StrategyExample.Pokemons;

public class Squirtle : IPokemon
{
    string _name;
    IPokemonAttackStrategy _attackStrategy;
    public Squirtle(string name, IPokemonAttackStrategy attackStrategy)
    {
        _name = name;
        _attackStrategy = attackStrategy;
    }

    public void Attack()
    {
        _attackStrategy.Attack(_name);
    }

    public void SetNewStrategy(IPokemonAttackStrategy newAttackStrategy)
    {
        _attackStrategy = newAttackStrategy;
    }
}