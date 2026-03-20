namespace Adapter;

// 新的角色类，使用适配器接口进行攻击
public class CharacterNew
{
    // 攻击方法，接收实现了 IWeaponAdapter 的武器适配器
    public void Attack(IWeaponAdapter weapon)
    {
        weapon.Attack(); // 只需调用统一的 Attack 方法
    }
}