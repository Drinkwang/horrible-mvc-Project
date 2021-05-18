using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
public class StringProxy : Baseproxy<StringModel>
{

    public bool isTrue;
    private static StringProxy instance;
    public static StringProxy instances()
    {
        if (instance == null)
        {
            instance = new StringProxy();

        }
        instance.ModelToDoView();
        return instance;

    }

    public StringProxy() : base()
    {

    }
    public StringModel GetStringModel(bool b)
    {
        List<StringModel> stringList=modellist.FindAll(t => t.isTrue == b);
        int index = 0;
        index = UnityEngine.Random.Range(index, stringList.Count);
        return stringList[index];
    }

   
    
}
