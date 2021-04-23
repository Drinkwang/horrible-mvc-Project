using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject inputText;
    public Color color;
    public void ShowInput()
    {
        AppFactory.instances.Todo(new Observer(Cmd.ShowImageAndText, inputText.GetComponentInChildren<Text>().text));
    }
    public void ChangeColor()
    {
        AppFactory.instances.Todo(new Observer(Cmd.changeColor, color));
    }
}
