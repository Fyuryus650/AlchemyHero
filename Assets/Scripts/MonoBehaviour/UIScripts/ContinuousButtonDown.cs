using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


// script referenced from https://answers.unity.com/questions/1491644/how-to-make-ui-button-fire-continuously.html
public class ContinuousButtonDown: MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed = false;
    public UnityEvent IfPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
    private void Update()
    {
        if (isPressed)
        {
            IfPressed.Invoke();
        }
    }
}