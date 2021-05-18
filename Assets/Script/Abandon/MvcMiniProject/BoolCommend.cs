using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolCommend : IC
{
    public void Todo(Observer t)
    {
        if (t.msg == Cmd.ChangeBool)
        {
            //BoolMedel.instances().ChangeBool((bool)t.body);
            StringProxy.instances().isTrue = (bool)t.body;
        }
       /* if (t.msg == Cmd.ChangeBoolFalse)
        {
            BoolMedel.instances().ChangeBoolFalse((bool)t.body);
        }*/
    }
}
