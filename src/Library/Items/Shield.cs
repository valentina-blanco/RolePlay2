using Roleplaygame;

namespace Ucu.Poo.RoleplayGame;

public class Shield : IElemento
{


// agrego un AttackValue porq sino no me deja usar la interfaz
    public int AttackValue 
    {
        get{
            return 0;
        }
    }
    public int DefenseValue
    {
        get
        {
            return 14;
        }
    }
}
