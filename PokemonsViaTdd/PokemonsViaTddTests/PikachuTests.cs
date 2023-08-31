using NUnit.Framework;
using PokemonsViaTdd;

namespace PokemonsViaTddTests;

// TDD(Test Driven Development) dev - life cycle
// 1.Write a test - run it and see it fails
// 2. Fix your code, so the tests will PASS
// 3. Refactor code and unit tests
// 
// Newly Added:
// Pikachu can learn a different move on level 3
//
// TODO:
// Pikachu cannot level down
// Pokemon gains experience points to level up
// Pokemon cannot change levels without expericence points
// 
// done: Pokemon cannot change its level directly
// done: when pickachu is created it starts from level 1
// done: Pikachu attak is Thunderstrike
// done: attack on level 1 should equal to 10 
public class PikachuTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PikachuAttakIsThunderstrikeAndOnLevel1ShouldEqualTo10()
    {
        var expectedAttakType = "Thunderstrike";
        var expectedAttakPower = 10;
        var sut = new Pikachu();

        var actualAttack = sut.Attack();

        Assert.AreEqual(expectedAttakType, actualAttack.Type);
        Assert.AreEqual(expectedAttakPower, actualAttack.Power);
    }

    [Test]
    public void WhenPickachuIsCreatedItStartsFromLevel_1_Test()
    {
        var expectedLevel = 1;
        var sut = new Pikachu();

        var actualLevel = sut.Level;

        Assert.AreEqual(expectedLevel, actualLevel);
    }

    [Test]
    public void PikachuLevelCannotBeChangedDirectly_Test()
    {
        // Arrange
        var expectedLevel = 1;
        var sut = new Pikachu();
        // through reflection, we use metadata of our object and write our test
        var levelProperty = sut.GetType().GetProperty("Level");

        // Act
        Assert.IsNotNull(levelProperty);
        if (levelProperty.CanWrite) levelProperty.SetValue(sut, 2);
        var actualLevel = sut.Level;

        // Assert
        Assert.AreEqual(expectedLevel, actualLevel);
    }

    [Test]
    public void PikachuLearnsNewMoveAtLevel3_Test()
    {
        var expectedAttakType = "Double Edge";
        var expectedAttakPower = 15;
        var sut = new Pikachu();

        for (int i = 1; i <= 3; i++)
        {
            sut.LevelUp();
        }

        var actualAttack = sut.Attack();

        Assert.AreEqual(expectedAttakType, actualAttack.Type);
        Assert.AreEqual(expectedAttakPower, actualAttack.Power);
    }
}