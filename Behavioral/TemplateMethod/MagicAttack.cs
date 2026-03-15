namespace TemplateMethod;

public class MagicAttack
{
    public void Prepare()
    {
        Console.WriteLine("准备攻击");
    }

    public void DoDamage()
    {
        Console.WriteLine("魔法造成30点伤害");
    }

    public void PlayAnimation()
    {
        Console.WriteLine("播放动画");
    }
}