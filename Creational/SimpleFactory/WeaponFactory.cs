namespace SimpleFactory;

public static class WeaponFactory
{
    public static IWeapon CreateWeapon(WeaponType weaponType)
    {
        switch (weaponType)
        {
            case WeaponType.Default:
                return new DefaultWeapon();
            case WeaponType.Sword:
                return new Sword();
            case WeaponType.Bow:
                return new Bow();
            case WeaponType.Staff:
                return new Staff();
            default:
                throw new ArgumentException($"未知武器类型: {weaponType}", nameof(weaponType));
        }
    }
}