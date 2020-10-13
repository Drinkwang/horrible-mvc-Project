using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class controller  {
	private Dictionary<string,IC> CommandFlow;
	// Use this for initialization
	public controller()
	{
		CommandFlow = new Dictionary<string, IC> ();
	}
	public void AdjustCommand(string msg,IC i)
	{
		if (!CommandFlow.ContainsKey (msg)) {
			CommandFlow.Add (msg, i);

		}

	}
	public void Todo(Observer o)
	{
		if (CommandFlow.ContainsKey (o.msg)) {
			CommandFlow [o.msg].Todo (o);
			Debug.Log (CommandFlow[o.msg].ToString ());

		}

	}

}
