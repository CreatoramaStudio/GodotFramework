using Godot;
using System;

namespace GodotFramework
{
    public abstract class Singleton<T> : Node where T : Singleton<T>
    {
        /// <summary>
        /// The static reference to the instance.
        /// </summary>
        public static T Instance
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets whether an instance of this singleton exists.
        /// </summary>
        public static bool InstanceExists => Instance != null;

        /// <summary>
        /// Gets the instance of this singleton, and returns true if it is not null.
        /// Prefer this whenever you would otherwise use InstanceExists and Instance together.
        /// </summary>
        public static bool TryGetInstance(out T result)
        {
            result = Instance;

            return result != null;
        }

        /// <summary>
        /// associate singleton with instance.
        /// </summary>
        public Singleton()
        {
            if (Instance != null)
            {
                GD.PushWarning("Trying to create a second instance of " + typeof(T));
                QueueFree();
            }
            else
            {
                Instance = (T)this;
            }
        }

        /// <summary>
        /// clear singleton association.
        /// </summary>
        public override void _ExitTree()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }
    }
}