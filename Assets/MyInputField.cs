using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyInputField : InputFieldOriginal
{
   

    public override void OnUpdateSelected(BaseEventData eventData)
    {
        base.OnUpdateSelected(eventData);
        m_CaretPosition = m_CaretSelectPosition = m_Text.Length;

    }


}