using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class dialogview : Vmediator
{
    public dialogComponent D;
    public override List<string> msglist
    {
        get
        {
            List<string> mlist = new List<string>();
            mlist.Add("dialogadd");
            mlist.Add("dialog");
            return mlist;
        }
    }
    public override string name
    {
        get
        {
            return "dialogview";
        }
    }
    public override void Todo(Observer o)
    {
        switch (o.msg)
        {
            case "dialogadd":
                Dictionary<string, List<string>> packmodelList = (Dictionary<string, List<string>>)o.body;
                D.add(packmodelList);
                break;
            case "dialog":
                D.todo((string)o.body);
                break;
            default:
                ;
                break;


        }
    }

    public override void refresh()
    {
        throw new NotImplementedException();
    }

    public dialogview()
    { D = dialogComponent.instance; }


}
