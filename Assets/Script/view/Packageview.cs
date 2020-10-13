using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packageview : Vmediator {
	public static Packageview instance;
	packageComponent pack;
	// Use this for initialization
	public Packageview()
	{pack=packageComponent.instante;
		
	}

	public override string name {
		get {
			return "Packageview";
		}

	}
	public override List<string> msglist {
		get {
			List<string> mlist = new List<string> ();
			mlist.Add ("show");
			return mlist;
		}
	}
	public override void Todo (Observer x)
	{

			List<Packagemodel> packmodelList = (List<Packagemodel>)x.body;
			pack.showPackage (packmodelList);


	}

}
