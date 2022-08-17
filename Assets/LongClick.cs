using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LongClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public VirtualKeyboard virtualKeyboard;

    public UnityEvent onLongClick;

    private bool onPointerDown;

    private float timer;

    [SerializeField]
    float requiredHoldTime;

    [SerializeField]
    float holdTimeBorder;

    public void OnPointerDown(PointerEventData eventData)
    {
        onPointerDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Reset();
    }

    private void Update()
    {
        if (onPointerDown)
        {
            timer += Time.deltaTime;
            if (timer >= requiredHoldTime)
            {
                if (onLongClick != null)
                    onLongClick.Invoke();

                virtualKeyboard.KeyDelete();

            }else if (timer >= holdTimeBorder)
                Reset();

        }
    }

    public void Reset()
    {
        onPointerDown = false;
        timer = 0;
    }
}
