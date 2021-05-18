using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentProxy :Baseproxy<StudentModel>
{//Model  旧的名字叫Controller

    private  static StudentProxy instance;
    public List<Color> colorList;
    public static StudentProxy instances()
    {
        if (instance == null)
        {
            instance= new StudentProxy();
        }
        return instance;
    }
    public StudentProxy()
    {
        this.addmodeltolist(new StudentModel("马钰浩", 21, "201641110109", 4, Major.Chinese, 81.35f));
        this.addmodeltolist(new StudentModel("汪鑫", 24, "201641110103", 3, Major.Math, 87.42f));
        this.addmodeltolist(new StudentModel("李军", 23, "201641110139", 3, Major.Chemical, 69.62f));
        this.addmodeltolist(new StudentModel("郭元奇", 22, "201641110143", 3, Major.Physical, 83.34f));
        this.addmodeltolist(new StudentModel("王志鹏", 25, "201641110125", 4, Major.Geographic, 84.76f));
    }
    public float FindScoreMax()
    {
        float max = modellist[0].averscore;
        if (modellist.Count == 0) { return 0; }
        else
        {
            for (int i = 1; i < modellist.Count; i++)
            {
                if (modellist[i].averscore > max) { max = modellist[i].averscore; }
            }
        }
        return max;
    }
    public void DeleteMinScore()
    {
        int index = 0;
        for(int i = 1; i < modellist.Count; i++)
        {
            if (modellist[index].averscore > modellist[i].averscore)
            {
                index = i;
            }
        }
        modellist.Remove(modellist[index]);
    }
    public float AverAge()
    {
        float aver = 0.0f;
        for (int i = 0; i < modellist.Count; i++)
        {
            aver += modellist[i].age;
        }
        aver /= modellist.Count;
        return aver;
    }

}
