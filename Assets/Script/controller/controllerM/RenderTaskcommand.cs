using System;
using System.Collections.Generic;
using UnityEngine;
public class RenderTaskcommand : IC
{

    public void Todo(Observer isa)
    {
        List<Taskmodel> taskmodellist = Taskproxy.instances().getmodellist();

        for (int i = 0; i < taskmodellist.Count; i++)
        {
            if (taskmodellist[i].HaveTid != 0)
            {
                taskmodellist[i].alltaskmodel = AllTaskproxy.instances().GetmodelbyId(taskmodellist[i].HaveTid);
            }

        }

        if ((string)isa.body == "main")
        {
            AppFactory.instances.viewTodo(new Observer("showtask", taskmodellist));
 
        }
        else if ((string)isa.body == "else")
        {
            AppFactory.instances.viewTodo(new Observer("showAlerttask", taskmodellist));

        }

    }
}



