namespace Proxy;

public class NpcProxy : INpc
{
    private Npc? _realNpc;

    private float _updateDistance;

    public NpcProxy(float updateDistance)
    {
        _updateDistance = updateDistance;
    }

    public void Update()
    {
        var distance = GetDistanceToPlayer();
        if (distance <= _updateDistance)
        {
            //延迟创建
            _realNpc ??= new Npc();
            //延迟更新
            _realNpc.Update();
        }
        else
        {
            UpdateSimple();
        }
    }

    private void UpdateSimple()
    {
        Console.WriteLine("执行NPC简单的移动逻辑");
    }

    /// <summary>
    /// 计算自己和玩家的距离
    /// </summary>
    /// <returns></returns>
    private float GetDistanceToPlayer()
    {
        //这里使用随机数来模拟
        return new Random().Next(0, 100);
    }
}