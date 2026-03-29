namespace ChainOfResponsibility;

public class DamageNew(CharacterNew target, float value, DamageType type)
{
    public CharacterNew Target { get; set; } = target;
    public float Value { get; set; } = value;
    public DamageType Type { get; set; } = type;
}