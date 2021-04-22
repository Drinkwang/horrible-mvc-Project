using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Taskitem : MonoBehaviour,IPointerClickHandler{
	private Image image;
	private Text text;
	public string titile;
	public string detail;
	public bool iscomplete;
	private bool ischoice;
	void Awake()
	{image = transform.GetComponentInChildren<Image> ();
		text = transform.GetComponentInChildren<Text> ();
	}
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	private Taskmodel model;
	public Taskmodel Model
	{
		get{return this.model; }
		set{ model = value;
			if (model.alltaskmodel.id != 0) {
		//		this.image.sprite = Resources.Load<Sprite> (model.good.src);
			//	this.text.text = model.count + "";
				this.titile = model.alltaskmodel.srctitle;
				if(this.text!=null)
				text.text=this.titile;
				this.detail = model.alltaskmodel.src;
				this.ischoice = model.alltaskmodel.ischoice;
				this.iscomplete = model.IScamplete;
			
					Color a = new Color (200, 5, 5, 150);
				if(this.image!=null)
					image.color = a;
				

			} else {
				//	this.image.sprite = null;
			//	this.text.text = 0+"";

			}
		}
}
	public void OnPointerClick(PointerEventData eventData)
	{if (eventData.pointerId == -1) {
			if(this.name=="maintask(Clone)")
			{AppFactory.instances.Todo (new Observer("rtask", "main"));
				Debug.Log ("aa");}
			else if(this.name=="choicetask(Clone)")
			{AppFactory.instances.Todo (new Observer("rtask", "else"));}
			Transform taskparent = this.transform.parent.parent.parent.parent.parent;
			taskparent.GetComponent<TaskComponent>().srctitle.text=this.titile;
			taskparent.GetComponent<TaskComponent>().detail.text=this.detail;
		
			if (iscomplete == true) {
				//taskparent.GetComponent<TaskComponent> ().iscomplete.GetComponent<FrameAnimator> ().Play();

			}
			else if (iscomplete == false) {
		//		taskparent.GetComponent<TaskComponent> ().iscomplete.GetComponent<FrameAnimator> ().Stop();

			}
		}
	else if (eventData.pointerId == -2) {
		}
		
	}
}
