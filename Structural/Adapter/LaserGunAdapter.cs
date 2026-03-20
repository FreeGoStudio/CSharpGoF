namespace Adapter;

// 激光枪的适配器，实现统一的武器接口
public class LaserGunAdapter : IWeaponAdapter
{
    private LaserGun _laserGun;

    // 构造函数，注入被适配的 LaserGun 对象
    public LaserGunAdapter(LaserGun laserGun)
    {
        _laserGun = laserGun;
    }

    // 实现统一的攻击方法，内部调用 LaserGun 的 ShootLaser 方法
    public void Attack()
    {
        _laserGun.ShootLaser();
    }
}