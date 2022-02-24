using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwipeController : MonoBehaviour
{
    [SerializeField] UnityEvent onSwipeUp;
    [SerializeField] UnityEvent onSwipeDown;
    [SerializeField] UnityEvent onSwipeRight;
    [SerializeField] UnityEvent onSwipeLeft;

    Vector2 lastPosition;
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
            lastPosition = Input.mousePosition;
        else if(Input.GetMouseButton(0))
        {
            var difX =  lastPosition.x - Input.mousePosition.x;
            var difY =  lastPosition.y - Input.mousePosition.y;
            if(Mathf.Abs(difX)> Mathf.Abs(difY))
            {
                if (difX > 0)
                    onSwipeRight?.Invoke();
                else
                    onSwipeLeft?.Invoke();
            }
            else
            {
                if (difY > 0)
                    onSwipeUp?.Invoke();
                else
                    onSwipeDown?.Invoke();
            }
            lastPosition = Input.mousePosition;
        }

    }
}
