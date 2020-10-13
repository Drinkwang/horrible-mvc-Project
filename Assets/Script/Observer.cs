using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer  {
	
	public string msg;
	public object body;

	// Use this for initialization

	public Observer(string msg,object body)
	{this.msg = msg;
		this.body = body;
	
	}
	public Observer(string msg):this(msg,null)
	{

	}


}
