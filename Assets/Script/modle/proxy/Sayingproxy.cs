using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sayingproxy
{

    private Dictionary<string, List<string>> saywhat;

    private static Sayingproxy instance;
    public static Sayingproxy instances()
    {
        if (instance == null)
        {

            instance = new Sayingproxy();
            instance.saywhat = new Dictionary<string, List<string>>();
        }
        return instance;
    }
    public void Add(string name, List<string> what)
    {
        if (saywhat.ContainsKey(name))
        {
            foreach (string k in what)
                saywhat[name].Add(k);
        }
        else
        {
            saywhat.Add(name, what);
        }
    }
    public Dictionary<string, List<string>> returnLs()
    {
        return saywhat;

    }

    // Update is called once per frame

}
