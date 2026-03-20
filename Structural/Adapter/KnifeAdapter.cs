namespace Adapter;

// 刀的适配器，实现统一的武器接口
public class KnifeAdapter : IWeaponAdapter
{
    private Knife _knife;

    // 构造函数，注入被适配的 Knife 对象
    public KnifeAdapter(Knife knife)
    {
        _knife = knife;
    }

    // 实现统一的攻击方法，内部调用 Knife 的 Stab 方法
    public void Attack()
    {
        _knife.Stab();
    }
}