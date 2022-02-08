using Godot;
using System;
namespace GodotFramework
{
    public class AxisInputAction : Resource
    {
        [Export]
        public string InputName = "Trigger";

        [Export]
        public bool Exact = false;

        public float GetAxis()
        {
            return Input.GetActionStrength(InputName, Exact);
        }
    }
}