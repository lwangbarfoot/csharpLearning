using FactoryPattern.AttackStrategies;

namespace FactoryPattern.Pokemons;

public class Eevee : IPokemon
{
    string _name;
    IPokemonAttackStrategy _attackStrategy;

    public Eevee(string name, IPokemonAttackStrategy attackStrategy)
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