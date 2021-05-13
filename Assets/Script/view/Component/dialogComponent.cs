using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
public class dialogComponent : MonoBehaviour {
	public static dialogComponent instance;
	//private GameObject t;
	public Image Q;
	private Dictionary <string,List<string>> dialogues;
	//public move s;
	public GameObject dialogue;
	public Text saying;
	//public  bool issaying=false;
	//public List<string> dialogues;
	private static int num=0;
//	public bool one,two;
	//public Dictionary<string,List<string>> a;

	void Awake()
	{instance = this;
		//dialogue = this.gameObject;
	}
	// Use this for initializaWtion
	void Start () {
		
		//saying = dialogue.GetComponentInChildren<Text> ();

	}

	public void add(Dictionary<string,List<string>> a)
	{//my = a;
		//foreach (Dictionary<string,string> r in a)
			dialogues = a; 
		//	a[a[0]];

	}

	// Update is called once per frame
	public void todo(string a){
//		print ("aa");
			dialogue.SetActive (true);
        this.transform.Find("black").gameObject.SetActive(true);
        //if (Input.GetMouseButtonDown (0)) {
        if (a.Length != 0)
            if (dialogues[a].Count != 0)
            {

                List<string> t = dialogues[a];
                textchange(t[0].ToString());
                dialogues[a].RemoveAt(0);
                //		issaying = false;
                //	} 

            }
            else
            {
                dialogue.SetActive(false);
                this.transform.Find("black").gameObject.SetActive(false);
                //AppFactory.instances.playercontrolpower.enabled = true;
            }
        else {
            print("you need debug");
        }
	
		}

	void textchange(string a)
	{//print ("aa");
		
		saying.text = a;
		num++;
	}
}
	


/*	public void OnPointerClick(PointerEventData eventData)
	{
		if (eventData.pointerId == -1) {
			Debug.Log ("Left Mouse Clicked");

		}
	}

	public void OnPointerEnter(PointerEventData eventData)
	{if (one == false) {
			t =	this.GetComponent<Button> ().onClick.GetPersistentTarget (0)as GameObject;
			t.SetActive (true);
		}
	}

	public void OnPointerExit(PointerEventData eventData)
	{t.SetActive (false);
		Debug.Log("Pointer Exit");
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (two == false) {
			Debug.Log ("Pointer Down");
			s.enabled = true;
			issaying = true;

			title.SetActive (false);
			task.SetActive (true);
			this.GetComponent<Text>().enabled=false;
			two = true;}
	}
*/



