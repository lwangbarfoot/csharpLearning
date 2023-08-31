namespace PokemonsViaTdd;

public class Pikachu
{
    private int _level;
    private string _attackType;
    private int _attackPower;

    public Pikachu()
    {
        _level = 1;
        _attackType = "Thunderstrike";
        _attackPower = 10;
    }

    public int Level
    {
        get => _level;
    }

    public void LevelUp()
    {
        _level++;
        if (_level >= 3)
        {
            _attackType = "Double Edge";
            _attackPower = 15;
        }
    }

    public AttackType Attack()
    {
        return new AttackType(_attackType, _attackPower);
    }
}