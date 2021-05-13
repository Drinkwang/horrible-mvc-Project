using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LigthComponent : MonoBehaviour
{
    public static LigthComponent instance;
    public Image[] items;
    void Awake()
    {
        instance = this;
        

        for (int i=0;i<items.Length; i++)
            Indexproxy.instances().addmodeltolist(new IndexModel(Color.red));
    }
    public void ChangeColorInImage(int i)
    {
        IndexModel t= Indexproxy.instances().GetIndexModel(i);
        items[i].color = t.color;
    }
}
