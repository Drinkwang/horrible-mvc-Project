using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject inputText;
    public Color color;
    public InputField inputColorIndex;
    public void Awake()
    {
        StringProxy.instances().addmodeltolist(new StringModel("读书破万卷", true));
        StringProxy.instances().addmodeltolist(new StringModel("下笔如有神", true));
        StringProxy.instances().addmodeltolist(new StringModel("好好学习", true));
        StringProxy.instances().addmodeltolist(new StringModel("天天向上", true));
        StringProxy.instances().addmodeltolist(new StringModel("三天打鱼", false));
        StringProxy.instances().addmodeltolist(new StringModel("两天晒网", false));
        StringProxy.instances().getmodellist().Add(new StringModel("少壮不努力", false));


    }
    public void ShowInput()
    {
        AppFactory.instances.Todo(new Observer(Cmd.ShowImageAndText, inputText.GetComponentInChildren<Text>().text));
    }
    public void ChangeColor()
    {
        AppFactory.instances.Todo(new Observer(Cmd.changeColor, color));
    }
    public void ButtonChangeBoolTrue()
    {
        AppFactory.instances.Todo(new Observer(Cmd.ChangeBool, true));

    }
    public void ButtonChangeBoolFalse()
    {
        AppFactory.instances.Todo(new Observer(Cmd.ChangeBool, false));
    }
    public void ButtonShowStudentInformtion()
    {
        AppFactory.instances.Todo(new Observer(Cmd.GetStudentModel));
        //AppFactory.instances.Todo(new Observer(Cmd.ShowStudentInformtion));
        AppFactory.instances.viewTodo(new Observer(Cmd.ShowStudentInformtion));
    }
    public void ButtonShowMajorColor()
    {
        //AppFactory.instances.Todo(new Observer(Cmd.ShowMajorColor));
        AppFactory.instances.viewTodo(new Observer(Cmd.ShowMajorColor));
    }

    public void ButtonChangeString()
    {
        bool isTrue = StringProxy.instances().isTrue;
        string s = StringProxy.instances().GetStringModel(isTrue).myString;
        AppFactory.instances.Todo(new Observer(Cmd.ChangeString, s));


    }


    public void ButtonChangeCColor() {
        int index = int.Parse(inputColorIndex.text);
        AppFactory.instances.Todo(new Observer(Cmd.ChangeColorInImage, index));

    }
}
