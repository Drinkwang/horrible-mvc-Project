using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taskmodel : Basemodel
{
    //private string srctitle;
    //private string src;

    public bool IScamplete;
    private ALLTaskmodel AllTask;
    /*public Taskmodel(int id,string srctitle,string src):base(id)
	{this.src = src;
		this.srctitle = srctitle;

	}	public Taskmodel(int id,string srctitle,string src):base(id)
	{this.src = src;
		this.srctitle = srctitle;
	}*/
    public ALLTaskmodel alltaskmodel;
    private int havatid;
    public int HaveTid
    {
        get { return havatid; }
        set
        {
            havatid = value;
            IScamplete = false;
        }
    }
    public Taskmodel(int id) : base(id)
    {
    }
    public Taskmodel()
    {

    }
}
