namespace ChainOfResponsibility;

public class CharacterNew
{
    public float Armor { get; set; }
    public float Health { get; set; }
    private float _shield;

    public float Shield
    {
        get => _shield;
        set => _shield = value < 0 ? 0 : value;
    }

    public CharacterNew(float health, float armor, float shield)
    {
        Health = health;
        Armor = armor;
        Shield = shield;
    }

    public void Die()
    {
        Console.WriteLine("角色死了");
    }
}