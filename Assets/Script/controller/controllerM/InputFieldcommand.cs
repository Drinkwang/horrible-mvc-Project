using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFieldcommand : IC
{
    public void Todo(Observer t)
    {
        if (t.msg == Cmd.ShowImageAndText)
        {
            //InputFieldComponent.instance.ShowImageAndText();
            //AppFactory.instances.Todo(new Observer(Cmd.ShowImageAndText, string));
            InputFieldComponent.instance.ShowImageAndText((string)t.body);
        }

        if (t.msg == Cmd.changeColor) {

            StudentProxy.instances().FindScoreMax();
        }
    }
    
}
