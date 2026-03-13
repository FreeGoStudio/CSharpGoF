namespace Proxy;

public class Npc : INpc
{
    public Npc()
    {
        LoadModel();
        InitAi();
    }

    public void Update()
    {
        Console.WriteLine("NPC思考和行动");
    }

    private void LoadModel()
    {
        Console.WriteLine("加载角色模型");
    }

    private void InitAi()
    {
        Console.WriteLine("初始化AI");
    }
}