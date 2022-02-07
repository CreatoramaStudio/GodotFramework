using Godot;
using System;

public class GameInstance : Singleton<GameInstance>
{
    [Export]
    public string Test = "";
    public GameInstance()
    {
        GD.Print("Test 1");
    }

    public override void _EnterTree()
    {
        GD.Print("Test 2");
    }

    public override void _Ready()
    {
        GD.Print("Test 3");
    }

    public override void _Process(float delta)
    {
        
    }

    public override void _ExitTree()
    {
        
    }
}
