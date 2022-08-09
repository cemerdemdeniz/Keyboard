using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualKeyboard : MonoBehaviour {

    public MyInputField InputField;

    public void KeyPress(string c)
    {
        InputField.text += c;
        InputField.ActivateInputField();
        
    }

    public void KeyLeft()
    {
       InputField.ProcessEvent(Event.KeyboardEvent(KeyCode.LeftArrow.ToString()));
        
    }


    public void KeyRight(int caretPosition)
    {
        InputField.caretPosition = caretPosition+1;
       if(InputField.caretPosition > 0)
        {
            InputField.text = caretPosition.ToString();
        }
    }


    public void KeyDelete()
    {
        if (InputField.text == null) return;

        string last = this.InputField.text;
        string newText = "";
        for (int i = 0; i < last.Length; i++)
        {
            if(i != last.Length - 1)
            {
                newText += last[i];
            }
        }
        this.InputField.text = newText;
    }
}
