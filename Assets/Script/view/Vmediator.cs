using System.Collections;
using System.Collections.Generic;
using System;

public abstract class Vmediator  {

	// Use this for initialization
	public abstract string name{ get; }
	public abstract List<string> msglist{ get; }

	public abstract void Todo(Observer o);

}
