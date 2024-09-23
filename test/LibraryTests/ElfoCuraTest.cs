using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace TestLibrary;

public class ElfoCuraTest
{
    [Test]
    public void ElfocuraTest()
    {
        Knight elfo = new Knight("Elfo")
        {
            Sword = new Sword(),
            Shield = new Shield(),
            Armor = new Armor()
        };
        
        elfo.ReceiveAttack(50);
        
        elfo.Cure();
        
        Assert.That(100, Is.EqualTo(elfo.Health));
    }
}