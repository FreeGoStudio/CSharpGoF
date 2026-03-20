namespace Adapter;

// 手枪的适配器，实现统一的武器接口
public class PistolAdapter : IWeaponAdapter
{
    private Pistol _pistol;

    // 构造函数，注入被适配的 Pistol 对象
    public PistolAdapter(Pistol pistol)
    {
        _pistol = pistol;
    }

    // 实现统一的攻击方法，内部调用 Pistol 的 Fire 方法
    public void Attack()
    {
        _pistol.Fire();
    }
}