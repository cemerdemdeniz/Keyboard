using UnityEngine;

public class VirtualKeyboard : MonoBehaviour
{
    public MyInputField InputField;
    public VirtualKeyboard virtualKeyboard;


    bool m_isPressing;
    bool m_isPressedLeft;
    bool m_isPressedRight;
    bool m_isKeyPressed;


    private void Update()
    {
        if (m_isKeyPressed)
        {
            KeyPress("");
        }

        if (m_isPressing)
        {
            KeyDelete();
        }
        if (m_isPressedLeft)
        {
            KeyLeft();
        }
        if (m_isPressedRight)
        {
            KeyRight();
        }


    }



    public void KeyPress(string c)
    {
        InputField.text += c;
        InputField.ActivateInputField();
        InputField.UpdateCaretPosition();
    }


    public void KeyLeft()
    {
        string last = this.InputField.text;
        for (int i = 0 ; i < last.Length; i++)
        {
            if (i != last.Length)
            {
                InputField.caretPosition = InputField.selectionFocusPosition = i;
                InputField.ActivateInputField();
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
                InputField.caretPosition = InputField.selectionFocusPosition = i + 1;
                InputField.ActivateInputField();
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
        InputField.ActivateInputField();

    }


    #region EventTriggerBoolean
    public void IsBackSpaceOn()
    {
        m_isPressing = true;
    }

    public void IsBackSpaceOff()
    {
        m_isPressing = false;
    }

    public void IsKeyLeftOn()
    {
        m_isPressedLeft = true;
    }
    public void IsKeyLeftOff()
    {
        m_isPressedLeft = false;
    }
    public void IsKeyRightOn()
    {
        m_isPressedRight = true;
    }

    public void IsKeyRightOff()
    {
        m_isPressedRight = false;
    }

    public void IsKeyPressed()
    {
        m_isKeyPressed = true;
    }
    public void IsKeyPressedOff()
    {
        m_isKeyPressed = false;
    }
    #endregion


}
