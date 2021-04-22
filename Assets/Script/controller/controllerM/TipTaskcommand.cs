using System;
using System.Collections.Generic;
using UnityEngine;
public class TipTaskcommand : IC
{

    public void Todo(Observer t)
    {
        tipCompnoent.instance.show((string)t.body);
           
    }
}



