using System;
using UnityEngine;

public class AddTaskcommand : IC
{
    public Taskproxy taskproxy = Taskproxy.instances();
    public AllTaskproxy AllTask = AllTaskproxy.instances();
    public AddTaskcommand()
    {
    }
    public void Todo(Observer o)
    {
        int id = 1;
        Taskmodel model = null;
        if (!int.TryParse(o.body.ToString(), out id))
        {
            return;
        }
        if (taskproxy.TryGethaveModel(id, out model))
        {


        }
        else
        {
            ALLTaskmodel a;
            if (AllTask.TryGetModel(id, out a))
            {

                model = new Taskmodel(taskproxy.getMaxid() + 1);
                model.HaveTid = a.id;
                taskproxy.addmodeltolist(model);
                if (a.ischoice)
                {
                    AppFactory.instances.Todo(new Observer("rtask", "else"));
                }
                else
                {
                    AppFactory.instances.Todo(new Observer("rtask", "main"));
                }
            }
        }
    }
}


