namespace AbstractFactory;

/// <summary>
/// 种族工厂接口，定义了种族相关的一系列创建方法。
/// 抽象工厂模式用于创建相关对象的家族，而无需指定具体类。
/// </summary>
public interface IRaceFactory
{
    /// <summary>
    /// 创建弓箭手单位。
    /// </summary>
    /// <returns>弓箭手单位实例。</returns>
    IUnit CreateArcher();

    /// <summary>
    /// 创建战士单位。
    /// </summary>
    /// <returns>战士单位实例。</returns>
    IUnit CreateWarrior();

    /// <summary>
    /// 创建法师单位。
    /// </summary>
    /// <returns>法师单位实例。</returns>
    IUnit CreateMage();

    /// <summary>
    /// 创建兵营建筑。
    /// </summary>
    /// <returns>兵营建筑实例。</returns>
    IBarracks CreateBarracks();

    /// <summary>
    /// 创建法师塔建筑。
    /// </summary>
    /// <returns>法师塔建筑实例。</returns>
    IMageTower CreateMageTower();
}