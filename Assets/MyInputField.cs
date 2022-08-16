using UnityEngine;
using UnityEngine.EventSystems;

public class MyInputField : InputFieldOriginal
{
    public VirtualKeyboard virtualKeyboard;


    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        if (!hasSelection)
        {
            SelectAll();
            string empty = "";
            m_Text = empty;
            virtualKeyboard.KeyPress(empty);
        }
    }

    public void UpdateCaretPosition()
    {
        m_CaretPosition = m_CaretSelectPosition = m_Text.Length;
    }

  



}