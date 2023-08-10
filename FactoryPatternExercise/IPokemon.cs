using FactoryPattern.AttackStrategies;

namespace FactoryPattern;

public interface IPokemon
{
    void Attack();
    void SetNewStrategy(IPokemonAttackStrategy newAttackStrategy);
}