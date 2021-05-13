using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StringCommand : IC
{
    public void Todo(Observer t)
    {
        if (t.msg == Cmd.ChangeString)
        {
            //BoolMedel.instances().ChangeBool((bool)t.body);
            ShowStringComponent.instance.ChangeStringInImage((string)t.body);
        }
    }
}
