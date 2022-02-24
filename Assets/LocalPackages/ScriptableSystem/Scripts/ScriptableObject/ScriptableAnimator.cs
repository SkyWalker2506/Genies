using UnityEngine;

namespace ScriptableSystem
{
    [CreateAssetMenu(menuName = "ScriptableSystem/ScriptableAnimator")]
    public class ScriptableAnimator : ScriptableObject
    {
        Animator animator;
        [SerializeField] string parameterName="";
        [SerializeField] int parameterID;

        public void SetAnimator(Animator animator)
        {
            this.animator = animator;
        }
        public void SetIntegerWithName(int value)
        {
            SetInteger(parameterName, value);
        }

        public void SetIntegerWithId(int value)
        {
            SetInteger(parameterID, value);
        }

        public void SetTrigger(string name)
        {
            animator.SetTrigger(name);
        }

        public void SetInteger(string name, int value)
        {
            animator.SetInteger(name, value);
        }

        public void SetInteger(int id, int value)
        {
            animator.SetInteger(id, value);
        }

        
        public void SetFloat(string name, float value)
        {
            animator.SetFloat(name, value);
        }

        public void SetFloat(int id, float value)
        {
            animator.SetFloat(id, value);
        }

        public void SetBool(string name, bool value)
        {
            animator.SetBool(name, value);
        }

        public void SetBool(int id, bool value)
        {
            animator.SetBool(id, value);
        }
    }
}