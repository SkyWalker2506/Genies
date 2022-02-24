using UnityEngine;
using UnityEngine.Events;

namespace ScriptableSystem
{
    public class ScriptableUnityEventSetter : MonoBehaviour
    {
        [SerializeField] UnityEvent unityEvent;
        [SerializeField] ScriptableUnityEvent scriptableUnityEvent;

        void Start()
        {
            SetScriptableUnityEvent();
        }

        void SetScriptableUnityEvent()
        {
            scriptableUnityEvent.SetScriptableUnityEvent(unityEvent);
        }
    }
}