using UnityEngine;
using UnityEngine.UI;
public class VirtualKeyboard : MonoBehaviour
{
    public MyInputField InputField;
    public VirtualKeyboard virtualKeyboard;

    public Button buttonLeft;
    public Button buttonRight;
    public Button backSpace;

    protected int localPos = 0;



    private void Awake()
    {
        Button btn = buttonLeft.GetComponent<Button>();
        Button btnR = buttonRight.GetComponent<Button>();
        Button backspace = backSpace.GetComponent<Button>();
        btn.onClick.AddListener(KeyLeft);
        btnR.onClick.AddListener(KeyRight);
        backspace.onClick.AddListener(KeyDelete);

    }

    private void Update()
    {
        InputField.ActivateInputField();
    }

    public void KeyPress(string c)
    {
        InputField.text += c;
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
        if(backSpace.onClick != null)
        {
            InputField.BackSpacePub();
        }


        //string last = this.InputField.text;
        //string newText = "";
        //if (InputField.text == null) return;


        //for (int i = 0; i <= last.Length - 1; i++)
        //{
        //    if (i != last.Length - 1)
        //    {
        //        newText += last[i];
        //    }
        //}


        //this.InputField.text = newText;
        //InputField.ActivateInputField();

    }



}
