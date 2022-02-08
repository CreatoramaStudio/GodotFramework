using Godot;
using System;
namespace GodotFramework
{
    public class ButtonInputAction : Resource
    {
        [Export]
        public string InputName = "Button";

        [Export]
        public bool Exact = false;

        public bool IsPressed()
        {
            return Input.IsActionJustPressed(InputName, Exact);
        }

        public bool IsReleased()
        {
            return Input.IsActionJustReleased(InputName, Exact);
        }

        public bool IsHolding()
        {
            return Input.IsActionPressed(InputName, Exact);
        }
    }
}