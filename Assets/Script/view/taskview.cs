using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taskview:Vmediator {
	public TaskComponent task=TaskComponent.instance;
	public override List<string> msglist {
		get {
			List<string> mlist = new List<string> ();
			mlist.Add ("showtask");
			mlist.Add ("showAlerttask");
			return mlist;
		}
	}
	public override string name {
		get {
			return "taskview";
		}
	}

    public override void refresh()
    {
        throw new System.NotImplementedException();
    }

    public override void Todo (Observer o)
	{//Debug.Log ("aaa");
		List<Taskmodel> taskmodelList = (List<Taskmodel>)o.body;
		switch (o.msg) {
		case "showtask":
			List<Taskmodel> taskmodelList2=new List<Taskmodel>();
			for(int i=0;i<taskmodelList.Count;i++) {
				if(taskmodelList[i].alltaskmodel.ischoice==false)
				{taskmodelList2.Add(taskmodelList[i]);}
			}
			task.showTask (taskmodelList2);;
			break;
		case "showAlerttask":        
			List<Taskmodel> taskmodelList3=new List<Taskmodel>();
			for(int i=0;i<taskmodelList.Count;i++) {
				if(taskmodelList[i].alltaskmodel.ischoice==true)
				{taskmodelList3.Add(taskmodelList[i]);}
			}
			task.showTask (taskmodelList3);;
			break;
		default:
			;
			break;
		}
	}
	// Use this for initialization

	
	// Update is called once per frame

}
