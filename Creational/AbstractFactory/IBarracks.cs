using AbstractFactory.Unit;

namespace AbstractFactory;

/// <summary>
/// 兵营接口，定义了创建战士和弓箭手的方法。
/// 用于抽象兵营建筑的功能。
/// </summary>
public interface IBarracks : IBuilder
{
    /// <summary>
    /// 创建战士单位。
    /// </summary>
    /// <returns>战士实例。</returns>
    IUnit CreateWarrior();

    /// <summary>
    /// 创建精灵弓箭手单位。
    /// </summary>
    /// <returns>弓箭手实例。</returns>
    IUnit CreateArcher();
}