using Godot;
using System;

public class PlayerController : Node
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        if (GameInstance.TryGetInstance(out var gameInstance))
        {
            GD.Print(Name + " " + gameInstance.Test);
        }
    }
}
