using System.Xml.Linq;
using FactoryPattern.AttackStrategies;

namespace FactoryPattern.Pokemons;

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