namespace Bridge;

/// <summary>
/// 桥接模式（Bridge Pattern）
/// 是一种 结构型设计模式。
/// 
/// 定义:
/// 将抽象与实现分离，使它们可以独立变化。
///
/// 桥接 = “两个独立变化维度 + 用组合连接”
/// 
/// 结构:
/// Weapon（抽象）
///     ↓ 持有
/// FireMode（实现）
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        //未使用设计模式
        UnusedDesignPattern();

        //使用设计模式
        UsedDesignPattern();
    }

    private static void UnusedDesignPattern()
    {
        Console.WriteLine("\n未使用设计模式的代码:");

        var pistolSingleFire = new PistolSingleFire();
        pistolSingleFire.Fire();

        var pistolAutoFire = new PistolAutoFire();
        pistolAutoFire.Fire();

        var rifleSingleFire = new RifleSingleFire();
        rifleSingleFire.Fire();

        var rifleAutoFire = new RifleAutoFire();
        rifleAutoFire.Fire();

        // 类数量 = N × M（爆炸）
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用桥接模式的代码:");

        var singleFire = new SingleFire();

        var autoFire = new AutoFire();

        var pistolSingleFire = new Pistol(singleFire);
        pistolSingleFire.Shoot();

        var pistolAutoFire = new Pistol(autoFire);
        pistolAutoFire.Shoot();

        var rifleSingleFire = new Rifle(singleFire);
        rifleSingleFire.Shoot();

        var rifleAutoFire = new Rifle(autoFire);
        rifleAutoFire.Shoot();

        //类的数量= N + M
    }
}