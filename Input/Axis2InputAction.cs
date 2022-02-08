using Godot;
using System;
namespace GodotFramework
{
    public class Axis2InputAction : Resource
    {
        [Export]
        public string PositiveInputName = "Up";

        [Export]
        public string NegativeInputName = "Down";

        public float GetAxis()
        {
            return Input.GetAxis(NegativeInputName, PositiveInputName);
        }
    }
}