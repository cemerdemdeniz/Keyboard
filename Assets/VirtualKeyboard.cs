using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualKeyboard : MonoBehaviour
{


    public MyInputField InputField;

    bool m_isPressing;

    private void Update()
    {
        if (m_isPressing)
        {
            KeyDelete();
        }


    }

    public void KeyPress(string c)
    {

        InputField.text += c;
        InputField.ActivateInputField();


    }

    public void KeyLeft()
    {

        string last = this.InputField.text;
        for (int i = 0; i < last.Length; i++)
        {
            if (i != last.Length)
            {
                InputField.caretPosition = last.Length - 1;
            }
        }
    }


    public void KeyRight()
    {
        string last = this.InputField.text;
        for (int i = 0; i < last.Length; i++)
        {
            if (i != last.Length)
            {
                InputField.caretPosition = last.Length + 1;
            }
        }
    }


    public void KeyDelete()
    {
        if (InputField.text == null) return;

        string last = this.InputField.text;
        string newText = "";


        for (int i = 0; i < last.Length; i++)
        {
            if (i != last.Length - 1)
            {
                newText += last[i];
            }
        }
        this.InputField.text = newText;


    }


    public void IsPressingOn()
    {
        m_isPressing = true;
    }


    public void IsPressingOff()
    {
        m_isPressing = false;

    }


}
