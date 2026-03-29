namespace ChainOfResponsibility;

public class Damage
{
    public float Value { get; set; }
    public DamageType Type { get; set; }
}

public enum DamageType
{
    Physical,
    Magical
}