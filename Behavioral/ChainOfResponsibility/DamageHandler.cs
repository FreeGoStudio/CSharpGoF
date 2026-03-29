namespace ChainOfResponsibility;

/// <summary>
/// DamageHandler 抽象伤害处理器，定义责任链节点的基本行为。
/// </summary>
public abstract class DamageHandler
{
    // 下一个处理器节点
    private DamageHandler? _nextHandler;

    /// <summary>
    /// 设置下一个处理器节点。
    /// </summary>
    /// <param name="nextHandler">下一个处理器</param>
    /// <returns>返回下一个处理器，便于链式调用</returns>
    public DamageHandler SetNext(DamageHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }

    /// <summary>
    /// 处理伤害的虚方法，默认传递到下一个处理器。
    /// </summary>
    /// <param name="damage">伤害对象</param>
    public virtual void Handle(DamageNew damage)
    {
        _nextHandler?.Handle(damage);
    }
}