using UnityEngine;
using UnityEngine.UI;
public class VirtualKeyboard : MonoBehaviour
{
    public MyInputField InputField;
    public VirtualKeyboard virtualKeyboard;
   
    public Button buttonLeft;
    public Button buttonRight;
    public Button backSpace;
    public Button keys;

    protected int localPos = 0;

   

    private void Awake()
    {
        Button btn = buttonLeft.GetComponent<Button>();
        Button btnR = buttonRight.GetComponent<Button>();  
        Button backspace = backSpace.GetComponent<Button>();
        Button key = keys.GetComponent<Button>();
        btn.onClick.AddListener(KeyLeft);
        btnR.onClick.AddListener(KeyRight);
        backspace.onClick.AddListener(KeyDelete);
        key.onClick.AddListener(KeyPress);
        
    }

    private void Update()
    {

        InputField.ActivateInputField();

    }

    public void KeyPress()
    {
    }


    public void KeyPress(string c)
    {
        InputField.text += c;
        InputField.ActivateInputField();
        InputField.UpdateCaretPosition();

    }


    public void KeyLeft()
    {
        localPos++;
        InputField.caretPosition = InputField.selectionFocusPosition = InputField.text.Length - localPos;

    }




    public void KeyRight()
    {
        localPos--;
        InputField.caretPosition = InputField.selectionFocusPosition = InputField.text.Length - localPos;
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
   
   
   
    #endregion


}
