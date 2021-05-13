using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorcommand : IC
{
    public void Todo(Observer t)
    {

        if (t.msg == "changeColor") {
            ColorModel.instances().red = Color.black;
        }
      //  StudentProxy.instances().FindScoreMax();
        ColorCompnoent.instance.ShowColor(ColorModel.instances().red);

    }
}
