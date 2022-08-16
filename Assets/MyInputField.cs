using UnityEngine;
using UnityEngine.EventSystems;

public class MyInputField : InputFieldOriginal
{
    public VirtualKeyboard virtualKeyboard;


    public override void OnPointerClick(PointerEventData eventData)
    {
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
        caretPosition = selectionFocusPosition = text.Length;
    }



}