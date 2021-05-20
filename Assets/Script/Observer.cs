﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer  {
	
	public string msg;//cmd
	public object body;
    public object data;
    // Use this for initialization

    public Observer(string msg, object body,object data)
    {
        this.msg = msg;
        this.body = body;
        this.data = data;

    }
    public Observer(string msg,object body)
	{
        this.msg = msg;
		this.body = body;
	
	}
	public Observer(string msg):this(msg,null)
	{

	}


}
