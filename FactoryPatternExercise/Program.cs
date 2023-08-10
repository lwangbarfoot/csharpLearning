// See https://aka.ms/new-console-template for more information

using FactoryPattern.AttackStrategies;
using FactoryPattern.Pokemons;

// Set up - create pokemon with Name & Type
var pikachu = PokemonFactory.CreatePokemon("Ling`s Pikachu", "Pikachu");
var charmander = PokemonFactory.CreatePokemon("Ling`s Charmander", "Charmander");
var squirtle = PokemonFactory.CreatePokemon("Ling`s Squirtle", "Squirtle");
var bulbasaur = PokemonFactory.CreatePokemon("Ling`s Bulbasaur", "Bulbasaur");
var eevee = PokemonFactory.CreatePokemon("Ling`s Eevee", "Eevee");

// Action - on their original attack
Console.WriteLine("-----------------Heaps of Pokemon appeared!!!!-------------------------");
Console.WriteLine();
Console.WriteLine("************ Action - on their original attack ************************");
pikachu.Attack();
charmander.Attack();
squirtle.Attack();
bulbasaur.Attack();
eevee.Attack();
Console.WriteLine();

// Action - choose a different type of attack
Console.WriteLine("************ Action - Pikachu chooses a different type of attack *******");
pikachu.SetNewStrategy(new FireboltAttack());
pikachu.Attack();

pikachu.SetNewStrategy(new WaterblastAttack());
pikachu.Attack();

pikachu.SetNewStrategy(new TackleAttack());
pikachu.Attack();

pikachu.SetNewStrategy(new TailWhipAttack());
pikachu.Attack();
Console.WriteLine();

Console.WriteLine("************ Action - New Pokemons choose a different type of attack ***");
squirtle.SetNewStrategy(new ThunderboltAttack());
squirtle.Attack();

eevee.SetNewStrategy(new TackleAttack());
eevee.Attack();
Console.WriteLine();
Console.WriteLine("--------------------------The End---------------------------------------");