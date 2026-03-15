namespace TemplateMethod;

public abstract class AttackAction
{
    public void Execute()
    {
        Prepare();
        DoDamage();
        PlayAnimation();
    }

    private void Prepare()
    {
        Console.WriteLine("准备攻击");
    }

    protected abstract void DoDamage();

    private void PlayAnimation()
    {
        Console.WriteLine("播放动画");
    }
}