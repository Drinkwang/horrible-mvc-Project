using System;
using System.Collections.Generic;

public class AllTaskproxy : Baseproxy<ALLTaskmodel>
{

    private static AllTaskproxy instance;
    public static AllTaskproxy instances()
    {
        if (instance == null)
        {
            instance = new AllTaskproxy();

        }
        instance.ModelToDoView();
        return instance;

    }



    public AllTaskproxy() : base()
    {
        this.addmodeltolist(new ALLTaskmodel("寻找真相", "宁和幽暗谷为何带有阵阵杀气，一股蓝色的能量爆发在道路的前方，你需要探索那片光芒，并查询所谓的真相", false, this.getMaxid() + 1));
        this.addmodeltolist(new ALLTaskmodel("消灭白鬼", "不好，有敌人入侵，你需要杀光所有敌人，赢得胜利", true, this.getMaxid() + 1));
        this.addmodeltolist(new ALLTaskmodel("消除黑鬼", "不好，有敌人入侵，你需要杀光所有敌人，赢得胜利", true, this.getMaxid() + 1));
        this.addmodeltolist(new ALLTaskmodel("消灭老板", "哀伤谷幕后黑手终于出现了，这次定要全力以赴，还哀伤谷一片太平！", false, this.getMaxid() + 1));
        this.addmodeltolist(new ALLTaskmodel("从前有一只鸡", "某某山头有一只很厉害的鸡，而我们需要斗鸡", false, this.getMaxid() + 1));
        this.addmodeltolist(new ALLTaskmodel("从前有一只鸡", "某某山头有一只很厉害的鸡，而我们需要斗鸡", false, this.getMaxid() + 1));
    }
}


