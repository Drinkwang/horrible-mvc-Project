using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightImageCommand : IC
{
    public void Todo(Observer o)
    {
        if (o.msg == Cmd.ChangeColorInImage)
        {
            LigthComponent.instance.ChangeColorInImage((int)o.body);
        }
    }
}
