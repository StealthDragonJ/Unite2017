// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEngine;

namespace RoboRyanTron.Unite2017.Variables
{
    [CreateAssetMenu]
    public class GenericVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public Vector3 Value;

        public void SetValue(Vector3 value)
        {
            Value = value;
        }

        public void SetValue(GenericVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(Vector3 amount)
        {
            Value += amount;
        }

        public void ApplyChange(GenericVariable amount)
        {
            Value += amount.Value;
        }
    }
}