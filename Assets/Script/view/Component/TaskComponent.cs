using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TaskComponent : MonoBehaviour {
	public static TaskComponent instance;
	public Text srctitle;
	public Text detail;
	public GameObject iscomplete;
	public Transform guazai;
	public GameObject main;
	public GameObject alert;
	// Use this for initialization
	void Awake()
	{instance = this;
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void showTask(List<Taskmodel> t)
	{
		foreach (Transform i in guazai)
		{//print (t.name);
			Destroy (i.gameObject);
		}
		if (t.Count <= 0) {
			GameObject.Instantiate (main, guazai);
			GameObject.Instantiate (alert, guazai);
		}
		if (t.Count > 0) {
			if (t [0].alltaskmodel.ischoice) {

				GameObject.Instantiate (main, guazai);
				GameObject.Instantiate (alert, guazai);
				GameObject temp = (GameObject)Resources.Load ("task");
				for (int i = 0; i < t.Count; i++) {
					GameObject w;
					w = GameObject.Instantiate (temp, guazai);
					Taskitem a = w.GetComponent<Taskitem> ();
					a.Model = t [i];
					//temp.AddComponent<Taskitem> ();

				}

			} else {

				GameObject.Instantiate (main, guazai);

				GameObject temp = (GameObject)Resources.Load ("task");
				for (int i = 0; i < t.Count; i++) {
					GameObject w;
					w = GameObject.Instantiate (temp, guazai);
					Taskitem a = w.GetComponent<Taskitem> ();
					a.Model = t [i];
					//temp.AddComponent<Taskitem> ();

				}
				GameObject.Instantiate (alert, guazai);
		
			}
		}
	}
}
