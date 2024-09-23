namespace Ucu.Poo.RoleplayGame;

public interface ICharacters
{
    public int Health { get;  set; }
    public string Name { get; set; }
    public int AttackValue { get; }
    public int DefenseValue { get; }
    public void ReceiveAttack(int power);
    public void Cure();

}