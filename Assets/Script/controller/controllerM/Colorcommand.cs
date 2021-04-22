using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorcommand : IC
{
    public void Todo(Observer t)
    {
        ColorCompnoent.instance.showColor((Color)t.body);

    }
}
