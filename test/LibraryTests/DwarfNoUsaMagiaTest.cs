using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace TestLibrary;

public class DwarfNoUsaMagiaTest
{
    [Test]
    public void DwarfnoUsaMagiaTest()
    {
        ICharacters dwarf = new Dwarf("Enano");
        IItems spellsBook = new SpellsBook();

        Assert.Throws<InvalidOperationException>(() => { UsarElementoMagico(dwarf, spellsBook); });
    }

    public void UsarElementoMagico(ICharacters character, IItems item)
        {
            if (!(character is Wizard) && item is SpellsBook)
            {
                throw new InvalidOperationException($"{character.Name} no puede usar magia.");
            }
            
        }    
}