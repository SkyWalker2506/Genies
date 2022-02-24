using UnityEngine;

namespace ScriptableSystem
{
    public class ScriptableAnimatorSetter : MonoBehaviour
    {
        [SerializeField] Animator animator;
        [SerializeField] ScriptableAnimator scriptableAnimator;

        void Start()
        {
            SetScriptableAnimator();
        }

        void SetScriptableAnimator()
        {
            scriptableAnimator.SetAnimator(animator);
        }
    }
}