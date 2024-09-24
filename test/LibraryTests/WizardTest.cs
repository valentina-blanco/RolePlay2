using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace TestLibrary;

public class WizardTest
{
    [Test]
    public void WizardAtacaTest()
    {
        Wizard wizard = new Wizard("Wizard")
        {
            SpellsBook = new SpellsBook()
            {
                Spells = new Spell[]
                {
                    new Spell()
                }
            },
            Staff = new Staff()
        };
        
        Archer archer = new Archer("Archer")
        {
            Bow = new Bow(),
            Helmet = new Helmet()
        };
        int health = archer.Health;
        archer.ReceiveAttack(wizard.AttackValue);
        
        int expectedHealth = health - (wizard.AttackValue - archer.DefenseValue);
        expectedHealth = expectedHealth < 0 ? 0 : expectedHealth;
        
        Assert.That(archer.Health, Is.EqualTo(expectedHealth));
    }
}