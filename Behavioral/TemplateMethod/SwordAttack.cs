namespace TemplateMethod;

public class SwordAttack
{
    public void Prepare()
    {
        Console.WriteLine("准备攻击");
    }

    public void DoDamage()
    {
        Console.WriteLine("剑造成20点伤害");
    }

    public void PlayAnimation()
    {
        Console.WriteLine("播放动画");
    }
}