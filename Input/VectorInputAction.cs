using Godot;
using System;

namespace GodotFramework
{
    public class VectorInputAction : Resource
    {
        [Export]
        public string ForwardInputName = "Forward";

        [Export]
        public string BackInputName = "Back";

        [Export]
        public string RightInputName = "Right";

        [Export]
        public string LeftInputName = "Left";

        [Export]
        public float DeadZone = -1;

        public Vector2 GetVector()
        {
            return Input.GetVector(LeftInputName, RightInputName, BackInputName, ForwardInputName, DeadZone);
        }
    }
}