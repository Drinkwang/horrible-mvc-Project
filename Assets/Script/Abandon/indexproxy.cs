using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indexproxy : Baseproxy<IndexModel>
{
    private static Indexproxy instance;

    public Indexproxy()
    {
    }

    public static Indexproxy instances()
    {
        if (instance == null)
        {
            instance = new Indexproxy();
        }
        instance.ModelToDoView();
        return instance;
    }
    public IndexModel GetIndexModel(int i)
    {
       return  modellist[i];
    }
    
}
