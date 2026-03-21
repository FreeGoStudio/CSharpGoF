namespace Memento;

/// <summary>
/// 备忘录模式（Memento Pattern）
/// 是一种 行为型设计模式。
/// 
/// 定义:
/// 在不破坏封装的前提下，保存对象的内部状态，并在之后恢复。
///
/// 直白说明:
/// 把对象当前状态“拍一张照片”，以后可以恢复到这个状态。
///
/// 结构:
/// Originator（原对象）
///     ↓
/// Memento（快照）
///     ↓
/// Caretaker（管理者）
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
        var player = new Player();
        player.Health = 100;
        player.Ammo = 20;

        var savedHealth = player.Health;
        var savedAmmo = player.Ammo;

        Console.WriteLine($"修改前: Health: {player.Health}, Ammo: {player.Ammo}");

        //修改状态
        player.Health = 20;
        Console.WriteLine($"修改后: Health: {player.Health}, Ammo: {player.Ammo}");

        //恢复状态
        player.Health = savedHealth;
        player.Ammo = savedAmmo;

        Console.WriteLine($"恢复后: Health: {player.Health}, Ammo: {player.Ammo}");

        // ❌ 状态分散（容易漏）
        // ❌ 不安全（外部随便改）
        // ❌ 不好扩展（字段一多就炸）
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用备忘录模式的代码:");

        var player = new PlayerNew();
        player.Health = 100;
        player.Ammo = 20;
        Console.WriteLine($"修改前: Health: {player.Health}, Ammo: {player.Ammo}");

        var saveSystem = new SaveSystem();
        saveSystem.Save(player);

        //修改状态
        player.Health = 20;
        Console.WriteLine($"修改后: Health: {player.Health}, Ammo: {player.Ammo}");

        //恢复状态
        saveSystem.Load(player);

        Console.WriteLine($"恢复后: Health: {player.Health}, Ammo: {player.Ammo}");
    }
}