using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace TestLibrary;

public class ArcherAtacadoTest
{
    [Test]
    public void ArcherEsAtacadoTest()
    {
        Archer archer = new Archer("Archer")
        {
            Bow = new Bow(),
            Helmet = new Helmet()
        };

        Dwarf dwarf = new Dwarf("Enano")
        {
            Axe = new Axe(),
            Shield = new Shield(),
            Helmet = new Helmet()
        };
        
        archer.ReceiveAttack(dwarf.AttackValue);
        
        //Prueba Assert
        int healthEsperada = 100 - (dwarf.AttackValue - archer.DefenseValue);
        Assert.That(archer.Health, Is.EqualTo(healthEsperada));
    }
    
}
