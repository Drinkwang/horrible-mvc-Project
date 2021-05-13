using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Studentcommand : IC
{
    public void Todo(Observer t)
    {
        if (t.msg == Cmd.DeleteMinScore)
        {
            StudentProxy.instances().DeleteMinScore();
        }
        else if (t.msg== Cmd.ShowStudentInformtion)
        {
            StudentComponent.instance.ShowStudentInformtion();
        }
        else if (t.msg == Cmd.ShowMajorColor)
        {
            StudentComponent.instance.ShowMajorColor();
        }
        else if(t.msg == Cmd.GetStudentModel)
        {
            StudentComponent.instance.studentList = StudentProxy.instances().getmodellist();
            
        }
        
    }
}