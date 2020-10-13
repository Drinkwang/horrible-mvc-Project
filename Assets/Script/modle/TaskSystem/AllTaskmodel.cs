public class ALLTaskmodel : Basemodel {
	
	public string srctitle;
	public string src;
	// Use this for initialization
	public bool ischoice;
	public ALLTaskmodel(string srctitle,string src,bool ischoice,int id):base(id)
	{this.src = src;
		this.srctitle = srctitle;
		this.ischoice = ischoice;}

	// Update is called once per frame
	public ALLTaskmodel()
	{}
}