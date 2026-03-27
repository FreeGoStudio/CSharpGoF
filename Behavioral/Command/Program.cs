using Command.Command;

namespace Command;

/// <summary>
/// 命令模式（Command Pattern）
/// 是一种 行为型设计模式。
/// 
/// 定义:
/// 将一个请求封装为一个对象，从而使你可以用不同的请求对客户进行参数化、队列请求、记录日志或支持撤销操作。
///
/// 结构:
/// Client（客户端）
///     ↓
/// ConcreteCommand（具体命令）
///     ↓
/// Receiver（接收者）
///     ↑
/// Invoker（调用者）
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
        player.Gun = new Gun();
        player.Shoot();
        player.Reload();
        // Player 直接依赖 Gun，不易扩展新操作。
        // 想支持“撤销操作”或“组合技能”很难。
        // 代码耦合度高，不利于复用和测试。
    }

    private static void UsedDesignPattern()
    {
        Console.WriteLine("\n使用命令模式的代码:");
        var player = new PlayerNew();
        var gun = new Gun();
        var shootCommand = new ShootCommand(gun);
        var reloadCommand = new ReloadCommand(gun);
        player.SetCommand(shootCommand, reloadCommand);
        player.Shoot();
        player.Reload();
        player.Reload();
        player.Shoot();
        player.Undo();
        player.Undo();
        player.Undo();
        player.Undo();
    }
}