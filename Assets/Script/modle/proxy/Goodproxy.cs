using System.Collections;
using System.Collections.Generic;

public class Goodproxy : Baseproxy<Goodsmodel> {
                   
	private static Goodproxy  instance;
	public static Goodproxy instances()
	{
		if (instance == null) {
			instance = new Goodproxy ();

		}
		instance.ModelToDoView();
		return instance;

	}
	// Use this for initialization
	public Goodproxy():base()
	{
        //物品生成，可以通过读表来实现
		this.addmodeltolist (new Goodsmodel("宝剑", this.getMaxid () + 1));
		this.addmodeltolist (new Goodsmodel ("药水", this.getMaxid () + 1));//goodid=2
		this.addmodeltolist (new Goodsmodel ("蓝药", this.getMaxid () + 1));//goodid=3
        this.addmodeltolist (new Goodsmodel ("复活币", this.getMaxid () + 1));//goodid=4
    }
}
