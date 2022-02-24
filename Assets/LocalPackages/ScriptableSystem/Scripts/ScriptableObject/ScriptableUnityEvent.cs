using UnityEngine;
using UnityEngine.Events;

namespace ScriptableSystem
{
    [CreateAssetMenu(menuName = "ScriptableSystem/ScriptableUnityEvent")]
    public class ScriptableUnityEvent : ScriptableObject
    {
        UnityEvent unityEvent;
        public void SetScriptableUnityEvent(UnityEvent value)
        {
            unityEvent = value;
        }

        public void CallEvent()
        {
            unityEvent?.Invoke();
        }
    }
}