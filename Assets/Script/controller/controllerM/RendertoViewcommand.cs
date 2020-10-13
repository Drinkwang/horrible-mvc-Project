using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendertoViewcommand : IC {
	Goodproxy goodproxy=Goodproxy.instances();
	PackProxy packproxy=PackProxy.instances();

	// Use this for initialization

	public void Todo(Observer a)
	{
		List<Packagemodel>packmodellist=packproxy.getmodellist ();
		for(int i=0;i<packmodellist.Count;i++)
		{
			if(packmodellist[i].goodid!=0)
			{//Debug .Log("a");
				packmodellist[i].good=goodproxy.GetmodelbyId(packmodellist[i].goodid);
			}
			
		}
		AppFactory.instances.viewTodo (new Observer ("show", packmodellist));

	}
}
