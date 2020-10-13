using System;

using System.Linq;
public class Taskproxy:Baseproxy<Taskmodel>
{public bool ismainTask;
	public Taskproxy ():base()
		{
		
		}
	private static Taskproxy instance;
	public static Taskproxy instances ()
	{if (instance == null) {

			instance = new Taskproxy ();
			//instance.saywhat = new Dictionary<string,List<string>>();
		}
		return instance;
		}
	public bool TryGethaveModel(int id,out Taskmodel t)
	{
		t=this.modellist.FirstOrDefault (s=>id==s.HaveTid);
		if (t != null)
			return true;
		else
			return false;
	}
	}

