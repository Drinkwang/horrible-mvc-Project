using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Studentview : Vmediator
{
    public static Studentview instance;
    StudentComponent studentComponent;
    public Studentview()
    {
        studentComponent = StudentComponent.instance;

    }

    public override string name
    {
        get
        {
            return "Studentview";
        }

    }
    public override List<string> msglist
    {
        get
        {
            List<string> mlist = new List<string>();
            mlist.Add("ShowStudentInformtion");
            mlist.Add("ShowMajorColor");
            mlist.Add("GetStudentModel");
            return mlist;
        }
    }

    public override void refresh()
    {
        throw new System.NotImplementedException();
    }

    public override void Todo(Observer x)
    {
        switch (x.msg)
        {
            case "ShowStudentInformtion": studentComponent.ShowStudentInformtion();  break;
            case "ShowMajorColor": studentComponent.ShowMajorColor(); break;
        }

    }


}
